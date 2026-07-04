using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRegistrarCaso : Form
    {
        private NCaso nCaso = new NCaso();
        private int idClienteAsociado = 1;
        private int idAdminLogueado = 1;

        public FormRegistrarCaso(int idCliente, int idAdminSession)
        {
            InitializeComponent();
            this.idClienteAsociado = idCliente;
            this.idAdminLogueado = idAdminSession;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCaso.DataSource = null;
            var lista = nCaso.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCaso.DataSource = lista;

                if (dgCaso.Columns.Contains("Administrador")) dgCaso.Columns["Administrador"].Visible = false;
                if (dgCaso.Columns.Contains("Cliente")) dgCaso.Columns["Cliente"].Visible = false;
                if (dgCaso.Columns.Contains("Especialista")) dgCaso.Columns["Especialista"].Visible = false;
                if (dgCaso.Columns.Contains("Cita")) dgCaso.Columns["Cita"].Visible = false;

                if (dgCaso.Columns.Contains("activo")) dgCaso.Columns["activo"].Visible = false;
                if (dgCaso.Columns.Contains("createdBy")) dgCaso.Columns["createdBy"].Visible = false;
                if (dgCaso.Columns.Contains("createdAt")) dgCaso.Columns["createdAt"].Visible = false;
                if (dgCaso.Columns.Contains("modifiedBy")) dgCaso.Columns["modifiedBy"].Visible = false;
                if (dgCaso.Columns.Contains("modifiedAt")) dgCaso.Columns["modifiedAt"].Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cbEstado.SelectedIndex = -1;
            cbFechaInicio.Clear();
            btnFechaFin.Text = "Seleccionar Fin";
            richTextBox1.Clear();
            dgCaso.ClearSelection();
        }

        private void dgCaso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count > 0)
            {
                var fila = dgCaso.SelectedRows[0];
                txtNombre.Text = fila.Cells["titulo"].Value?.ToString();
                txtDocumento.Text = fila.Cells["documento"].Value?.ToString();
                cbEstado.Text = fila.Cells["estado"].Value?.ToString();
                cbFechaInicio.Text = Convert.ToDateTime(fila.Cells["fechaHoraInicio"].Value).ToShortDateString();
                var fechaFinVal = fila.Cells["fechaHoraFin"].Value ?? fila.Cells["FechaHoraFin"].Value;
                btnFechaFin.Text = (fechaFinVal != null && fechaFinVal != DBNull.Value)
                    ? Convert.ToDateTime(fechaFinVal).ToShortDateString()
                    : "Seleccionar Fin";
                richTextBox1.Text = fila.Cells["descripcion"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El título del caso es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEspecialistaPredeterminado = 3; 

            Caso nuevoCaso = new Caso()
            {
                idCliente = idClienteAsociado,
                idAdministrador = this.idAdminLogueado, 
                idEspecialista = idEspecialistaPredeterminado,
                titulo = txtNombre.Text.Trim(),
                descripcion = richTextBox1.Text.Trim(),
                estado = string.IsNullOrWhiteSpace(cbEstado.Text) ? "Abierto" : cbEstado.Text,
                fechaHoraInicio = DateTime.Now,
                fechaHoraFin = null,
                documento = txtDocumento.Text.Trim(),
                activo = true,

                createdBy = this.idAdminLogueado,
                createdAt = DateTime.Now
            };

            string mensaje = nCaso.Registrar(nuevoCaso);
            MessageBox.Show(mensaje, "Sistema ALBAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarTabla();
            LimpiarCampos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgCaso.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione primero un caso de la tabla para poder modificarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El título del caso no puede quedar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dgCaso.CurrentRow;

            Caso casoModificado = new Caso()
            {
                nroCaso = Convert.ToInt32(fila.Cells["nroCaso"].Value),
                idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value),
                idEspecialista = Convert.ToInt32(fila.Cells["idEspecialista"].Value),
                idAdministrador = Convert.ToInt32(fila.Cells["idAdministrador"].Value),
                titulo = txtNombre.Text.Trim(),
                descripcion = richTextBox1.Text.Trim(),
                estado = cbEstado.Text,
                fechaHoraInicio = Convert.ToDateTime(fila.Cells["fechaHoraInicio"].Value),
                fechaHoraFin = (fila.Cells["fechaHoraFin"].Value != null && fila.Cells["fechaHoraFin"].Value != DBNull.Value)
                                ? Convert.ToDateTime(fila.Cells["fechaHoraFin"].Value)
                                : (DateTime?)null,
                documento = txtDocumento.Text.Trim(),
                activo = true,

                modifiedBy = this.idAdminLogueado,
                modifiedAt = DateTime.Now
            };

            string mensaje = nCaso.Modificar(casoModificado);
            MessageBox.Show(mensaje, "Sistema ALBAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarTabla();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tBuscado = txtNombre.Text.Trim();
            var lista = nCaso.ListarTodo();
            if (lista != null && !string.IsNullOrWhiteSpace(tBuscado))
            {
                dgCaso.DataSource = lista.Where(c => c.titulo != null && c.titulo.IndexOf(tBuscado, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
        }

        private void FormRegistrarCaso_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un caso.");
                return;
            }

            var fila = dgCaso.SelectedRows[0];

            int nroCaso = int.Parse(fila.Cells["nroCaso"].Value.ToString());
            string tituloCaso = fila.Cells["titulo"].Value.ToString();

            Usuario objetoUsuarioProvisional = new Usuario() { idUsuario = this.idAdminLogueado };
            FormRegistrarCitas formRegistrarCitas = new FormRegistrarCitas(nroCaso, tituloCaso, objetoUsuarioProvisional);
            formRegistrarCitas.Show();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Este caso no tiene ningún enlace o ruta de documento registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string rutaOEnlace = txtDocumento.Text.Trim();

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = rutaOEnlace,
                    UseShellExecute = true 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el documento. Verifique que el enlace o la ruta sean válidos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgCaso.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la tabla para exportar a Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);

                int indiceColumna = 0;
                foreach (DataGridViewColumn columna in dgCaso.Columns)
                {
                    if (columna.Visible)
                    {
                        indiceColumna++;
                        excel.Cells[1, indiceColumna] = columna.HeaderText;
                        // Le ponemos negrita al encabezado
                        excel.Cells[1, indiceColumna].Font.Bold = true;
                    }
                }

                int indiceFila = 1;
                foreach (DataGridViewRow fila in dgCaso.Rows)
                {
                    indiceFila++;
                    int colCelda = 0;
                    foreach (DataGridViewColumn columna in dgCaso.Columns)
                    {
                        if (columna.Visible)
                        {
                            colCelda++;
                            excel.Cells[indiceFila, colCelda] = fila.Cells[columna.Name].Value?.ToString();
                        }
                    }
                }

                excel.Columns.AutoFit();
                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear(); 
            CargarTabla();     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCaso.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un caso de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nroCasoSeleccionado = Convert.ToInt32(dgCaso.CurrentRow.Cells["nroCaso"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar (cerrar) este caso de forma lógica?",
                                                  "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mensaje = nCaso.EliminarLogico(nroCasoSeleccionado, this.idAdminLogueado);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarTabla();
                LimpiarCampos();
            }
        }
    }
}

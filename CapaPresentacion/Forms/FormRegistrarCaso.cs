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
        private Usuario usuarioActual;
        private NCaso nCaso = new NCaso();
        private int idClienteAsociado = 1;

        public FormRegistrarCaso(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            //this.idClienteAsociado = idCliente;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCaso.DataSource = null;
            var lista = nCaso.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCaso.DataSource = lista;
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
                MessageBox.Show("El título del caso es obligatorio.");
                return;
            }

            Caso nuevoCaso = new Caso()
            {
                nroCaso = 0,
                idCliente = idClienteAsociado,
                idAdministrador = 1,
                idEspecialista = 3,  
                titulo = txtNombre.Text.Trim(),
                estado = cbEstado.Text ?? "Abierto",
                fechaHoraInicio = string.IsNullOrWhiteSpace(cbFechaInicio.Text) ? DateTime.Now : Convert.ToDateTime(cbFechaInicio.Text),
                fechaHoraFin = null,
                descripcion = richTextBox1.Text.Trim(),
                documento = txtDocumento.Text.Trim()
            };

            string mensaje = nCaso.Registrar(nuevoCaso);
            MessageBox.Show(mensaje);

            CargarTabla();
            LimpiarCampos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione primero un caso de la tabla para poder modificarlo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El título del caso no puede quedar vacío.");
                return;
            }

            var fila = dgCaso.SelectedRows[0];

            Caso casoModificado = new Caso()
            {
                nroCaso = int.Parse(fila.Cells["nroCaso"].Value.ToString()),
                idCliente = int.Parse(fila.Cells["idCliente"].Value.ToString()),
                idEspecialista = int.Parse(fila.Cells["idEspecialista"].Value.ToString()),
                idAdministrador = int.Parse(fila.Cells["idAdministrador"].Value.ToString()),

                titulo = txtNombre.Text.Trim(),
                estado = cbEstado.Text,
                fechaHoraInicio = Convert.ToDateTime(cbFechaInicio.Text),
                fechaHoraFin = (string.IsNullOrWhiteSpace(btnFechaFin.Text) || btnFechaFin.Text == "Seleccionar Fin")
                    ? (DateTime?)null
                    : Convert.ToDateTime(btnFechaFin.Text),
                descripcion = richTextBox1.Text.Trim(),
                documento = txtDocumento.Text.Trim()
            };

            string mensaje = nCaso.Modificar(casoModificado);
            MessageBox.Show(mensaje);

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

            FormRegistrarCitas formRegistrarCitas = new FormRegistrarCitas(nroCaso, tituloCaso, usuarioActual);
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

 
    }
}

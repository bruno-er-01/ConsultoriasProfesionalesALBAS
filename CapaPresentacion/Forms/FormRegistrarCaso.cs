using CapaDatos;
using CapaNegocios;
using CapaPresentacion.Forms;
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
        private NUsuario nUsuario = new NUsuario();
        private int idClienteAsociado;
        private int idAdminLogueado;

        public FormRegistrarCaso()
        {
            InitializeComponent();
            CargarEspecialistas();
            CargarTabla();
        }

        public FormRegistrarCaso(int idCliente, int idAdminSession)
        {
            InitializeComponent();
            idClienteAsociado = idCliente;
            idAdminLogueado = idAdminSession;
            CargarEspecialistas();
            CargarTablaPorCliente(idCliente);
        }

        private void CargarEspecialistas()
        {
            var listaFormateada = nUsuario.ListarEspecialistas()
                .Select(u => new
                {
                    idUsuario = u.idUsuario,
                    NombreCompleto = u.nombre + " " + u.apellido
                }).ToList();

            cbEspecialista.DataSource = listaFormateada;
            cbEspecialista.ValueMember = "idUsuario";
            cbEspecialista.DisplayMember = "NombreCompleto";
            cbEspecialista.SelectedIndex = -1;
        }

        private void CargarTabla()
        {
            dgCaso.DataSource = null;
            var lista = nCaso.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCaso.DataSource = lista.Select(c => new
                {
                    NroCaso = c.nroCaso,
                    Título = c.titulo,
                    Cliente = c.Cliente != null ? (c.Cliente.nombre + " " + c.Cliente.apellido) : "Sin asignar",
                    Especialista = c.Especialista != null ? (c.Especialista.Usuario.nombre + " " + c.Especialista.Usuario.apellido) : "Sin asignar",
                    Área = (c.Especialista != null && c.Especialista.Area != null) ? c.Especialista.Area.nombre : "Sin asignar",
                    Descripción = c.descripcion,
                    Estado = c.estado,
                    FechaInicio = c.fechaHoraInicio,
                    FechaFin = c.fechaHoraFin,
                    Documento = c.documento,
                    idCliente = c.idCliente,
                    idEspecialista = c.idEspecialista 
                }).ToList();

                if (dgCaso.Columns.Contains("idCliente")) dgCaso.Columns["idCliente"].Visible = false;
                if (dgCaso.Columns.Contains("idEspecialista")) dgCaso.Columns["idEspecialista"].Visible = false;
            }
        }

        private void CargarTablaPorCliente(int idCliente)
        {
            dgCaso.DataSource = null;
            var listaCompleta = nCaso.ListarTodo();

            if (listaCompleta != null)
            {
                var listaFiltrada = listaCompleta.Where(c => c.idCliente == idCliente).ToList();

                dgCaso.DataSource = listaFiltrada.Select(c => new
                {
                    NroCaso = c.nroCaso,
                    Título = c.titulo,
                    Cliente = c.Cliente != null ? (c.Cliente.nombre + " " + c.Cliente.apellido) : "Sin asignar",
                    Especialista = c.Especialista != null ? (c.Especialista.Usuario.nombre + " " + c.Especialista.Usuario.apellido) : "Sin asignar",
                    Área = (c.Especialista != null && c.Especialista.Area != null) ? c.Especialista.Area.nombre : "Sin asignar",
                    Descripción = c.descripcion,
                    Estado = c.estado,
                    FechaInicio = c.fechaHoraInicio,
                    FechaFin = c.fechaHoraFin,
                    Documento = c.documento,
                    idCliente = c.idCliente,
                    idEspecialista = c.idEspecialista
                }).ToList();

                if (dgCaso.Columns.Contains("idCliente")) dgCaso.Columns["idCliente"].Visible = false;
                if (dgCaso.Columns.Contains("idEspecialista")) dgCaso.Columns["idEspecialista"].Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cbEstado.SelectedIndex = -1;
            cbEspecialista.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddMonths(1);
            richTextBox1.Clear();
            txtDocumento.Clear();
            dgCaso.ClearSelection();
        }

        private void dgCaso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count > 0)
            {
                var fila = dgCaso.SelectedRows[0];
                txtNombre.Text = fila.Cells["Título"].Value?.ToString();
                txtDocumento.Text = fila.Cells["Documento"].Value?.ToString();
                cbEstado.Text = fila.Cells["Estado"].Value?.ToString();
                richTextBox1.Text = fila.Cells["Descripción"].Value?.ToString();

                if (fila.Cells["FechaInicio"].Value != null)
                    dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);

                if (fila.Cells["FechaFin"].Value != null)
                    dtpFechaFin.Value = Convert.ToDateTime(fila.Cells["FechaFin"].Value);

                if (fila.Cells["idEspecialista"].Value != null)
                {
                    cbEspecialista.SelectedValue = Convert.ToInt32(fila.Cells["idEspecialista"].Value);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cbEspecialista.SelectedValue == null)
            {
                MessageBox.Show("El título del caso y el especialista son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Caso nuevoCaso = new Caso()
            {
                idCliente = idClienteAsociado,
                idAdministrador = idAdminLogueado,
                idEspecialista = Convert.ToInt32(cbEspecialista.SelectedValue), 
                titulo = txtNombre.Text.Trim(),
                descripcion = richTextBox1.Text.Trim(),
                estado = string.IsNullOrWhiteSpace(cbEstado.Text) ? "Abierto" : cbEstado.Text,
                fechaHoraInicio = dtpFechaInicio.Value, 
                fechaHoraFin = dtpFechaFin.Value,    
                documento = txtDocumento.Text.Trim()
            };

            string mensaje = nCaso.Registrar(nuevoCaso);
            MessageBox.Show(mensaje, "Sistema ALBAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (idClienteAsociado > 0) CargarTablaPorCliente(idClienteAsociado); else CargarTabla();
            LimpiarCampos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgCaso.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un caso de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dgCaso.CurrentRow;

            Caso casoModificado = new Caso()
            {
                nroCaso = Convert.ToInt32(fila.Cells["nroCaso"].Value),
                idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value),
                idEspecialista = Convert.ToInt32(cbEspecialista.SelectedValue),
                idAdministrador = Convert.ToInt32(fila.Cells["idAdministrador"].Value),
                titulo = txtNombre.Text.Trim(),
                descripcion = richTextBox1.Text.Trim(),
                estado = cbEstado.Text,
                fechaHoraInicio = dtpFechaInicio.Value,
                fechaHoraFin = dtpFechaFin.Value,
                documento = txtDocumento.Text.Trim(),
                modifiedBy = idAdminLogueado
            };

            string mensaje = nCaso.Modificar(casoModificado);
            MessageBox.Show(mensaje, "Sistema ALBAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (idClienteAsociado > 0) CargarTablaPorCliente(idClienteAsociado); else CargarTabla();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tBuscado = txtNombre.Text.Trim();
            var lista = nCaso.ListarTodo();
            if (lista != null && !string.IsNullOrWhiteSpace(tBuscado))
            {
                var listaFiltrada = lista.Where(c => c.titulo != null && c.titulo.IndexOf(tBuscado, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                if (idClienteAsociado > 0) listaFiltrada = listaFiltrada.Where(c => c.idCliente == idClienteAsociado).ToList();
                dgCaso.DataSource = listaFiltrada;
            }
        }

        private void FormRegistrarCaso_Load(object sender, EventArgs e)
        {
            if (idClienteAsociado > 0)
            {
                CargarTablaPorCliente(idClienteAsociado);
            }
            else
            {
                CargarTabla();
            }
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un caso para asignarle una cita.");
                return;
            }
            var fila = dgCaso.SelectedRows[0];
 
            int nroCaso = Convert.ToInt32(fila.Cells["NroCaso"].Value);
            string tituloCaso = fila.Cells["Título"].Value.ToString();

            FormRegistrarCitas formRegistrarCitas = new FormRegistrarCitas(nroCaso, tituloCaso, idAdminLogueado);
            formRegistrarCitas.Show();
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
                MessageBox.Show("Seleccione un caso para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nroCasoSeleccionado = Convert.ToInt32(dgCaso.CurrentRow.Cells["nroCaso"].Value);
            DialogResult result = MessageBox.Show("¿Desea eliminar este caso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mensaje = nCaso.EliminarLogico(nroCasoSeleccionado, idAdminLogueado);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (idClienteAsociado > 0) CargarTablaPorCliente(idClienteAsociado); else CargarTabla();
                LimpiarCampos();
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

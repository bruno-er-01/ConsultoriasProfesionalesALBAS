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
    public partial class FormRegistrarBuscarClientes : Form
    {
        private NCliente nCliente = new NCliente();
        private int idClienteSeleccionado = 0;
        public FormRegistrarBuscarClientes()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgClientes.DataSource = null;
            var lista = nCliente.ListarTodo();
            if (lista.Count > 0)
            {
                dgClientes.DataSource = lista;
            }
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow == null)
                return;

            var filaActual = dgClientes.CurrentRow;

            txtNombre.Text = (filaActual.Cells["nombre"]?.Value ?? filaActual.Cells["Nombre"]?.Value)?.ToString();
            txtApellido.Text = (filaActual.Cells["apellido"]?.Value ?? filaActual.Cells["Apellido"]?.Value)?.ToString();
            txtDNI.Text = (filaActual.Cells["dni"]?.Value ?? filaActual.Cells["DNI"]?.Value)?.ToString();
            txtTelefono.Text = (filaActual.Cells["telefono"]?.Value ?? filaActual.Cells["Telefono"]?.Value)?.ToString();
            txtDireccion.Text = (filaActual.Cells["direccion"]?.Value ?? filaActual.Cells["Direccion"]?.Value)?.ToString();
            txtCorreo.Text = (filaActual.Cells["correo"]?.Value ?? filaActual.Cells["Correo"]?.Value)?.ToString();

            if (dgClientes.Columns.Contains("genero"))
                cbGenero.Text = filaActual.Cells["genero"].Value?.ToString();
            else if (dgClientes.Columns.Contains("Genero"))
                cbGenero.Text = filaActual.Cells["Genero"].Value?.ToString();

            if (dgClientes.Columns.Contains("areaAtencion") && dgClientes.CurrentRow.Cells["areaAtencion"].Value != null)
            {
                cbAreaAtencion.Text = dgClientes.CurrentRow.Cells["areaAtencion"].Value.ToString();
            }
            else if (dgClientes.Columns.Contains("AreaAtencion") && dgClientes.CurrentRow.Cells["AreaAtencion"].Value != null)
            {
                cbAreaAtencion.Text = dgClientes.CurrentRow.Cells["AreaAtencion"].Value.ToString();
            }
            else if (dgClientes.CurrentRow.Cells[7].Value != null)
            {
                cbAreaAtencion.Text = dgClientes.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtApellido.Focus();
                return;
            }

            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                txtDNI.Focus();
                return;
            }

            if (cbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un género.");
                return;
            }

            if (cbAreaAtencion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un área.");
                return;
            }
        }

        private void btnRegistrarCaso_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista para registrarle un caso.");
                return;
            }
          
            FormRegistrarCaso formCaso = new FormRegistrarCaso(idClienteSeleccionado);
            formCaso.ShowDialog();
            CargarTabla();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cbGenero.SelectedIndex = -1;
            cbAreaAtencion.SelectedIndex = -1;
            idClienteSeleccionado = 0;
            dgClientes.ClearSelection();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarTabla();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void FormRegistrarBuscarClientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}

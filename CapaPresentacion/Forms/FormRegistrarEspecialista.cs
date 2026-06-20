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
    public partial class FormRegistrarEspecialista : Form
    {
        private NUsuario nUsuario = new NUsuario();

        public FormRegistrarEspecialista()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgEspecialista.DataSource = null;
            var lista = nUsuario.ListarEspecialistas();
            if (lista != null && lista.Count > 0)
            {
                dgEspecialista.DataSource = lista;
            }
        }

        private void dgEspecialistas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEspecialista.SelectedRows.Count > 0)
            {
                var fila = dgEspecialista.SelectedRows[0];
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["apellido"].Value?.ToString();
                txtDNI.Text = fila.Cells["dni"].Value?.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value?.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value?.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value?.ToString();
                txtUsername.Text = fila.Cells["username"].Value?.ToString();
                txtContrasena.Text = fila.Cells["password"].Value?.ToString();
                cbGenero.Text = fila.Cells["disponibilidad"].Value?.ToString();
                cbAreaAtencion.Text = fila.Cells["areaAtencion"].Value?.ToString();
                cbActividad.Text = fila.Cells["actividad"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("El DNI y Username son obligatorios.");
                return;
            }

            Usuario usuario = new Usuario()
            {
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                dni = txtDNI.Text,
                telefono = txtTelefono.Text,
                direccion = txtDireccion.Text,
                correo = txtCorreo.Text,
                username = txtUsername.Text,
                password = txtContrasena.Text,
                activo = cbActividad.Text == "Activo"
            };

            string mensaje = (dgEspecialista.SelectedRows.Count == 0)
                ? nUsuario.RegistrarEspecialista(usuario, 0, true)
                : nUsuario.Modificar(usuario);

            MessageBox.Show(mensaje);
            CargarTabla();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniBuscado = txtDNI.Text.Trim();
            var lista = nUsuario.ListarEspecialistas();
            if (lista != null && !string.IsNullOrWhiteSpace(dniBuscado))
            {
                dgEspecialista.DataSource = lista.Where(u => u.dni != null && u.dni.Contains(dniBuscado)).ToList();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}

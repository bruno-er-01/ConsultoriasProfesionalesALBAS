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

namespace CapaPresentacion.Forms
{
    public partial class FormEspecialistaMiCuenta : Form
    {
        private Usuario usuarioActual;
        private NUsuario nUsuario = new NUsuario();
        public FormEspecialistaMiCuenta( Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {
            lblNombre.Text = usuarioActual.nombre;
            lblApellido.Text = usuarioActual.apellido;
            lblDNI.Text = usuarioActual.dni;
            lblTelefono.Text = usuarioActual.telefono;
            lblCorreo.Text = usuarioActual.correo;
            lblDireccion.Text = usuarioActual.direccion;

            lblUsuario.Text = usuarioActual.username;
            lblRol.Text = usuarioActual.rol;
            lblArea.Text = nUsuario.BuscarAreaEspecialista(usuarioActual.idUsuario);
            bool disponible = nUsuario.BuscarDisponibilidadEspecialista(usuarioActual.idUsuario);
            MostrarDisponibilidad(disponible);

            if (usuarioActual.activo == true)
            {
                lblEstadoCuenta.Text = "Activo";
            }
            else
            {
                lblEstadoCuenta.Text = "Inactivo";
            }
        }
        private void MostrarDisponibilidad(bool disponible)
        {
            if (disponible == true)
            {
                lblDiponible.Text = "DISPONIBLE";
                lblDiponible.BackColor = Color.Green;
                lblDiponible.ForeColor = Color.White;
            }
            else
            {
                lblDiponible.Text = "NO DISPONIBLE";
                lblDiponible.BackColor = Color.DarkGray;
                lblDiponible.ForeColor = Color.White;
            }
        }
        private void btnActualizaContra_Click(object sender, EventArgs e)
        {
            string contraActual = txtxContraActual.Text.Trim();
            string contraNueva = txtContraNueva.Text.Trim();
            string contraConfirmada = txtContraNuevaConfirmada.Text.Trim();

            if (contraActual == "" || contraNueva == "" || contraConfirmada == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (contraNueva != contraConfirmada)
            {
                MessageBox.Show("La nueva contraseña no coincide con la confirmación.");
                return;
            }

            string mensaje = nUsuario.ActualizarPassword(
                usuarioActual,
                contraActual,
                contraNueva
            );

            MessageBox.Show(mensaje);
            LimpiarCampos();

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            txtxContraActual.Text = "";
            txtContraNueva.Text = "";
            txtContraNuevaConfirmada.Text = "";
            txtxContraActual.Focus();
        }

        private void FormEspecialistaMiCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}

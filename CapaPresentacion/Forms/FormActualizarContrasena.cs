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
    public partial class FormActualizarContrasena : Form
    {
        private NUsuario nUsuario = new NUsuario();

        private String correoRecuperacion;
        public FormActualizarContrasena(String correoRecuperacion)
        {
            InitializeComponent();
            this.correoRecuperacion = correoRecuperacion;
        }

        private void btnRegresarLogin_Click(object sender, EventArgs e)
        {
            FormRecuperarCuenta formRecuperarCuenta = new FormRecuperarCuenta();
            formRecuperarCuenta.Show();

            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevaPassword = txtNuevaPassword.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();

            if (nuevaPassword == "" || confirmarPassword == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (nuevaPassword != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            string mensaje = nUsuario.ActualizarPasswordPorCorreo(correoRecuperacion, nuevaPassword);

            MessageBox.Show(mensaje);

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Close();
        }
    }
}

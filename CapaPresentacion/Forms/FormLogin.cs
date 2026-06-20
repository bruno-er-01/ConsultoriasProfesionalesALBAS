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
    public partial class FormLogin : Form
    {
        private NUsuario nUsuario = new NUsuario();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            Usuario usuario = nUsuario.IniciarSesion(txtUsuario.Text, txtPassword.Text);
            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            if (usuario.rol == "Administrador")
            {
                this.Hide();
                FormMenuPrincipalAdmin menu = new FormMenuPrincipalAdmin(usuario);
                menu.Show();
            }
            else
            {
                this.Hide();
                FormMenuPrincipalEspecialista menu = new FormMenuPrincipalEspecialista(usuario);
                menu.Show();
            }
        }

        private void lklOlvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarCuenta formRecuperarCuenta = new FormRecuperarCuenta();
            formRecuperarCuenta.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

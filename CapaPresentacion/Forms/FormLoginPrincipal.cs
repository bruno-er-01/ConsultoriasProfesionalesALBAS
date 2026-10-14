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
    public partial class FormLoginPrincipal : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormLoginPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Usuario usuario = nUsuario.IniciarSesion(
                txtUsuario.Text.Trim(),
                txtPassword.Text.Trim()
            );

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            if (usuario.rol == "Administrador")
            {
                this.Hide();

                FormMenuPrincipalAdmin menu = new FormMenuPrincipalAdmin(usuario);
                menu.ShowDialog();

                this.Show();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else if (usuario.rol == "Especialista")
            {
                this.Hide();

                FormMenuPrincipalEspecialista menu = new FormMenuPrincipalEspecialista(usuario);
                menu.ShowDialog();

                this.Show();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Rol no reconocido.");
            }
        }

        private void lklOlvidoContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarCuenta formRecuperarCuenta = new FormRecuperarCuenta();
            formRecuperarCuenta.Show();

            this.Hide();
        }
    }
}

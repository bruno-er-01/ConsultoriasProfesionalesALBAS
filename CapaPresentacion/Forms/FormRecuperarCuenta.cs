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
    public partial class FormRecuperarCuenta : Form
    {
        private NUsuario nUsuario = new NUsuario();

        private string codigoGenerado = "";
        private string correoRecuperacion = "";

        public FormRecuperarCuenta()
        {
            InitializeComponent();
        }
   
        private void btnRegresarLoginq_Click(object sender, EventArgs e)
        {
            FormLoginPrincipal formLogin = new FormLoginPrincipal();
            formLogin.Show();

            this.Close();
        }

        private void btnEnviarCodigo_Click_1(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (correo == "")
            {
                MessageBox.Show("Ingrese su correo.");
                return;
            }

            Usuario usuario = nUsuario.BuscarPorCorreo(correo);

            if (usuario == null)
            {
                MessageBox.Show("Correo inválido");
                return;
            }

            Random random = new Random();
            codigoGenerado = random.Next(100000, 999999).ToString();
            correoRecuperacion = correo;

            MessageBox.Show("Código: " + codigoGenerado);
        }

        private void btnVerificarCodigo_Click_1(object sender, EventArgs e)
        {
            string codigoIngresado = txtCodigo.Text.Trim();

            if (codigoGenerado == "")
            {
                MessageBox.Show("Primero debe enviar el código.");
                return;
            }

            if (codigoIngresado == "")
            {
                MessageBox.Show("Ingrese el código.");
                return;
            }

            if (codigoIngresado != codigoGenerado)
            {
                MessageBox.Show("Código incorrecto.");
                return;
            }

            MessageBox.Show("Código verificado correctamente.");

            FormActualizarContrasena formActualizar = new FormActualizarContrasena(correoRecuperacion);
            formActualizar.Show();

            this.Close();
        }
    }
}

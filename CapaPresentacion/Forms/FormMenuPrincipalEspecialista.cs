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
    public partial class FormMenuPrincipalEspecialista : Form
    {

        private Usuario usuarioActual;

        public FormMenuPrincipalEspecialista(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;

        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            pnlFormularios.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnlFormularios.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaInicio(usuarioActual));
        }

 
        private void pnlBuscarCasosCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaBuscarCita());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBuscarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaBuscarCliente());
        }
        
        private void pnlMiPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaMiCuenta(usuarioActual));
        }

        private void pnlMisCasos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaBuscarCaso(usuarioActual));
        }
        //jiji
    }
}

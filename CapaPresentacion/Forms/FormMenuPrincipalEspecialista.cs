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
            ReiniciarColorPaneles();
            SeleccionarPanel(pnlInicio);
            ActivarClickEnControles();
        }
        private void ActivarClickEnControles()
        {
            foreach (Control control in pnlInicio.Controls)
                control.Click += pnlInicio_Click;

            foreach (Control control in pnlMiPerfil.Controls)
                control.Click += pnlMiPerfil_Click;

            foreach (Control control in pnlMisCasos.Controls)
                control.Click += pnlMisCasos_Click;
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
        private void ReiniciarColorPaneles()
        {
            Color colorNormal = Color.FromArgb(66, 15, 29);

            pnlInicio.BackColor = colorNormal;
            pnlMisCasos.BackColor = colorNormal;
            pnlMiPerfil.BackColor = colorNormal;
        }
        private void SeleccionarPanel(Panel panelSeleccionado)
        {
            ReiniciarColorPaneles();
            panelSeleccionado.BackColor = Color.FromArgb(26, 2, 9);
        }
        private void pnlInicio_Click(object sender, EventArgs e)
        {
            SeleccionarPanel(pnlInicio);
            AbrirFormEnPanel(new FormEspecialistaInicio(usuarioActual));
        }

        private void pnlMiPerfil_Click(object sender, EventArgs e)
        {
            SeleccionarPanel(pnlMiPerfil);
            AbrirFormEnPanel(new FormEspecialistaMiCuenta(usuarioActual));
        }

        private void pnlMisCasos_Click(object sender, EventArgs e)
        {
            SeleccionarPanel(pnlMisCasos);
            AbrirFormEnPanel(new FormEspecialistaBuscarCaso(usuarioActual));
        }
        private void pnlBuscarCasosCitas_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new FormEspecialistaBuscarCita());
        }

        private void pnlBuscarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormEspecialistaBuscarCliente());
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
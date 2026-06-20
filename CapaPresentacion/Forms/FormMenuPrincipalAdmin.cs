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
    public partial class FormMenuPrincipalAdmin : Form
    {
        private Usuario usuarioActual;

        public FormMenuPrincipalAdmin(Usuario usuario)
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
            AbrirFormEnPanel(new FormInicio());
        }

        private void pnlUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMenuRegistroUsuarios());
        }

        private void pnlClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarBuscarClientes());
        }

        private void pnlRegistrarCasosCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarCaso());
        }

        private void pnlReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormReportes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

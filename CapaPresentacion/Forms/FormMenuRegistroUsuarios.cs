using CapaDatos;
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
    public partial class FormMenuRegistroUsuarios : Form
    {
        private Usuario usuarioActual;
        public FormMenuRegistroUsuarios(Usuario usuario)
        {
            this.usuarioActual = usuario;
            InitializeComponent();
        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            pnlMenuUsuarios.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnlMenuUsuarios.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnFormAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarAdministrador(usuarioActual));
        }

        private void btnFormEspecialista_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistrarEspecialista(usuarioActual));
        }
    }
}

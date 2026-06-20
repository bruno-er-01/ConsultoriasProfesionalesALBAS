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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            pnlMenuReportes.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnlMenuReportes.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void btnDashBoardClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashBoardClientes());
        }

        private void btnDashBoardCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormDashBoardCitas());
        }
    }
}

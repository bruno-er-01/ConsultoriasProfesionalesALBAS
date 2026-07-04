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

        private void btnReporteAreasCasos_Click(object sender, EventArgs e)
        {
           FormDashBoardReporteAreas form =  new FormDashBoardReporteAreas();
           form.ShowDialog();
        }

        private void btnDashBoardAntiguedadCasosPorAreas_Click(object sender, EventArgs e)
        {
            FormDashboardReporteAntiguedadCasos form = new FormDashboardReporteAntiguedadCasos();
            form.Show();
        }

        private void btnReporteCargaLaboralXEspecialista_Click(object sender, EventArgs e)
        {
            FormDashboardCargaLaboralxEspecialista form = new FormDashboardCargaLaboralxEspecialista();
            form.Show();
        }

    }
}

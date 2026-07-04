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
    public partial class FormEspecialistaCaso : Form
    {
        private Usuario usuarioActual;
        private int nroCaso;
        private NCaso nCaso = new NCaso();
        public FormEspecialistaCaso(Usuario usuarioActual, int nroCaso)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.nroCaso = nroCaso;

        }
        private void CargarDatosCaso()
        {
            Caso caso = nCaso.BuscarPorNroCaso(nroCaso);
            MessageBox.Show("Se abrió el caso Nro: " + caso.nroCaso);

        }
        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }
    }
}

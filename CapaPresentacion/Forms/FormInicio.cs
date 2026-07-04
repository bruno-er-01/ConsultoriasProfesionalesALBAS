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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class FormInicio : Form
    {
        private NUsuario nUsuario = new NUsuario();
        private NCliente nCliente = new NCliente();
        private NEspecialista nEspecialista = new NEspecialista();
        private NCaso nCaso = new NCaso();
        Usuario usuarioActual;
        public FormInicio(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            CargarDatosInicio();
        }
        private void CargarDatosInicio()
        {
            CargarResumenGeneral();
            CargarGraficoClientesPorMes();
            CargarGraficoCasosPorEstado();
        }

        private void CargarResumenGeneral()
        {
            lblAdmin.Text = $"{usuarioActual.nombre} {usuarioActual.apellido}";
            lblNumUsuarioActivos.Text = nUsuario.ContarUsuariosActivos().ToString();
            lblClientesRegistrados.Text = nCliente.ContarClientesRegistrados().ToString();
            lblEspecialistasDispo.Text = nUsuario.ContarEspecialistasDisponibles().ToString();
            lblNumCasosActivos.Text = nCaso.ContarCasosActivos().ToString();
        }
        private void CargarGraficoClientesPorMes()
        {
            cClienteMes.Series.Clear();
            cClienteMes.ChartAreas.Clear();
            cClienteMes.Titles.Clear();

            ChartArea area = new ChartArea();
            cClienteMes.ChartAreas.Add(area);

            Series serie = new Series("Clientes");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            List<object> datos = nCliente.ListarClientesPorMes();

            foreach (object item in datos)
            {
                string mes = item.GetType().GetProperty("Mes").GetValue(item, null).ToString();
                int cantidad = Convert.ToInt32(item.GetType().GetProperty("Cantidad").GetValue(item, null));

                serie.Points.AddXY(mes, cantidad);
            }

            cClienteMes.Series.Add(serie);
            cClienteMes.Titles.Add("Clientes registrados por mes");

            cClienteMes.ChartAreas[0].AxisX.Title = "Mes";
            cClienteMes.ChartAreas[0].AxisY.Title = "Cantidad";
            cClienteMes.ChartAreas[0].AxisX.Interval = 1;
        }

        private void CargarGraficoCasosPorEstado()
        {
            cRegistroEstado.Series.Clear();
            cRegistroEstado.ChartAreas.Clear();
            cRegistroEstado.Titles.Clear();

            ChartArea area = new ChartArea();
            cRegistroEstado.ChartAreas.Add(area);

            Series serie = new Series("Casos");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.IsValueShownAsLabel = true;

            List<object> datos = nCaso.ListarCasosPorEstado();

            foreach (object item in datos)
            {
                string estado = item.GetType().GetProperty("Estado").GetValue(item, null).ToString();
                int cantidad = Convert.ToInt32(item.GetType().GetProperty("Cantidad").GetValue(item, null));

                serie.Points.AddXY(estado, cantidad);
            }

            cRegistroEstado.Series.Add(serie);
            cRegistroEstado.Titles.Add("Casos registrados por estado");
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}

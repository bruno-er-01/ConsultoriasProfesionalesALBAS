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
    public partial class FormDashBoardMontos : Form
    {
        private NReporte nReporte = new NReporte();
        private List<ReporteDemandaArea> reporteActual = new List<ReporteDemandaArea>();
        private NArea nArea = new NArea();
        private NCita nCita = new NCita();
        public FormDashBoardMontos()
        {
            InitializeComponent();
            MostrarComboAreaAtencion(nArea.ListarTodo());
        }

        void MostrarComboAreaAtencion(List<Area> lista)
        {
            cbAreaAtencion.DataSource = null;
            if (lista.Count > 0)
            {
                cbAreaAtencion.DataSource = lista;
                cbAreaAtencion.ValueMember = "idArea";
                cbAreaAtencion.DisplayMember = "nombre";
            }
        }

        private void FormDashBoardMontos_Load(object sender, EventArgs e)
        {

        }

        private void CargarGraficoLinea(List<object> reporte)
        {
            ctMontoscitas.Series.Clear();

            var serie = ctMontoscitas.Series.Add("Monto total");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            serie.BorderWidth = 3;

            ctMontoscitas.ChartAreas[0].AxisX.Title = "Meses";
            ctMontoscitas.ChartAreas[0].AxisY.Title = "Monto recaudado";


            foreach (object item in reporte)
            {
                int mes = Convert.ToInt32(item.GetType().GetProperty("Mes").GetValue(item));
                decimal monto = Convert.ToDecimal(item.GetType().GetProperty("MontoTotal").GetValue(item));

                serie.Points.AddXY(mes, monto);
            }
        }

        private void CargarGraficoPie(List<object> reporte)
        {
            chartPieModalidadMontos.Series.Clear();

            var serie = chartPieModalidadMontos.Series.Add("Modalidad");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            foreach (object item in reporte)
            {
                string modalidad = item.GetType().GetProperty("Modalidad").GetValue(item).ToString();
                decimal monto = Convert.ToDecimal(item.GetType().GetProperty("MontoTotal").GetValue(item));

                serie.Points.AddXY(modalidad, monto);
            }
        }

        private string ObtenerNombreMes(int mes)
        {
            string[] meses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                       "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            return meses[mes];
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            int idarea = Convert.ToInt32(cbAreaAtencion.SelectedValue);
            string orden = cbOrden.Text;
            string modalidad = cbModalidad.Text;

            if (orden == "" || modalidad == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.");
                return;
            }

            var reporteLinea = nReporte.ReporteMontosPorArea(fechaInicio, fechaFin, idarea, modalidad, orden);
            var reportePie = nReporte.ReporteMontosPorModalidad(fechaInicio, fechaFin, idarea);

            dgReportes.DataSource = reporteLinea;

            CargarGraficoLinea(reporteLinea);
            CargarGraficoPie(reportePie);

            lblTotalCitas.Text = reporteLinea
                .Sum(x => Convert.ToInt32(x.GetType().GetProperty("CantidadCitas").GetValue(x)))
                .ToString();

            lblMesMejorMonto.Text = reporteLinea.Count > 0
                ? reporteLinea
                    .OrderByDescending(x => Convert.ToDecimal(x.GetType().GetProperty("MontoTotal").GetValue(x)))
                    .Select(x => x.GetType().GetProperty("Mes").GetValue(x).ToString())
                    .First()
                : "-";

            lblModalidadMayorDemanda.Text = reportePie.Count > 0
                ? reportePie
                    .OrderByDescending(x => Convert.ToDecimal(x.GetType().GetProperty("MontoTotal").GetValue(x)))
                    .Select(x => x.GetType().GetProperty("Modalidad").GetValue(x).ToString())
                    .First()
                : "-";

            if (reporteLinea.Count > 0)
            {
                var mayor = reporteLinea
                    .OrderByDescending(x => Convert.ToDecimal(x.GetType().GetProperty("MontoTotal").GetValue(x)))
                    .First();

                var menor = reporteLinea
                    .OrderBy(x => Convert.ToDecimal(x.GetType().GetProperty("MontoTotal").GetValue(x)))
                    .First();

                int mesMayor = Convert.ToInt32(mayor.GetType().GetProperty("Mes").GetValue(mayor));
                int mesMenor = Convert.ToInt32(menor.GetType().GetProperty("Mes").GetValue(menor));

                decimal montoMayor = Convert.ToDecimal(mayor.GetType().GetProperty("MontoTotal").GetValue(mayor));
                decimal montoMenor = Convert.ToDecimal(menor.GetType().GetProperty("MontoTotal").GetValue(menor));

                if (montoMayor == montoMenor)
                {
                    lblInterpretacion.Text = "No hubo cambios en los montos recaudados durante el intervalo seleccionado.";
                }
                else
                {
                    lblInterpretacion.Text = "Durante el intervalo seleccionado, el mayor nivel de recaudación se registró en "
                         + ObtenerNombreMes(mesMayor) +
                         ", alcanzando un monto total de S/ " + montoMayor.ToString("0.00") +
                         ". Por otro lado, el menor nivel de recaudación corresponde a "
                         + ObtenerNombreMes(mesMenor) +
                         ", con un total de S/ " + montoMenor.ToString("0.00") + ".";
                }
            }
            else
            {
                lblInterpretacion.Text = "No hay datos para interpretar en el intervalo seleccionado.";
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExpoPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using CapaNegocios;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Forms
{
    public partial class FormDashBoardReportesCitasCanceladasAusencias : Form
    {
        private NReporte nReporte = new NReporte();

        public FormDashBoardReportesCitasCanceladasAusencias()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarGrafico();
            CargarGraficoBarras();
        }

        private void ConfigurarGrafico()
        {
            chartPerdidas.Series.Clear();
            chartPerdidas.Titles.Clear();

            Title titulo = chartPerdidas.Titles.Add("Pérdida Económica por Citas Canceladas e Inasistencias (Efecto No-Show)");
            titulo.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            Series serieBarras = chartPerdidas.Series.Add("Pérdida en S/.");
            serieBarras.ChartType = SeriesChartType.Column;
            serieBarras.XValueType = ChartValueType.String;
            serieBarras.YValueType = ChartValueType.Double;

            serieBarras.Color = System.Drawing.Color.FromArgb(140, 24, 55);

            serieBarras.IsValueShownAsLabel = true;
            serieBarras.LabelFormat = "S/. #,##0";
        }

        private void CargarGraficoBarras()
        {
            try
            {
                List<ReporteNoShowEstructura> datos = nReporte.ObtenerPerdidaNoShow();

                foreach (var item in datos)
                {
                    chartPerdidas.Series["Pérdida en S/."].Points.AddXY(item.Mes, item.TotalPerdido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el gráfico analítico: " + ex.Message,
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

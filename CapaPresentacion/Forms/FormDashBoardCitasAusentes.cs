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

namespace CapaPresentacion.Forms
{
    public partial class FormDashBoardCitasAusentes : Form
    {
        private NCita nCita = new NCita();
        public FormDashBoardCitasAusentes()
        {
            InitializeComponent();
            ConfigurarControlesAnaliticos();
        }

        private void ConfigurarControlesAnaliticos()
        {

            cbOrdenarPor.Items.Clear();
            cbOrdenarPor.Items.Add("Cronológico Semántico");
            cbOrdenarPor.Items.Add("Pérdida Económica (Mayor a Menor)");
            cbOrdenarPor.Items.Add("Pérdida Económica (Menor a Mayor)");
            cbOrdenarPor.SelectedIndex = 0;

            txtAnchoBarra.Text = "6"; 

            DateTime fechaMinimaBD;
            DateTime fechaMaximaBD;
            nCita.ObtenerRangoFechasCanceladas(out fechaMinimaBD, out fechaMaximaBD);

            dtpFechaInicio.Value = fechaMinimaBD;
            dtpFechaFin.Value = fechaMaximaBD;

            ProcesarYRenderizarGrafico(true);
        }

        private void ProcesarYRenderizarGrafico(bool esCargaInicial)
        {
            DateTime inicio;
            DateTime fin;

            if (esCargaInicial)
            {
                inicio = new DateTime(1753, 1, 1);
                fin = new DateTime(9999, 12, 31);
            }
            else
            {
                inicio = dtpFechaInicio.Value.Date;
                fin = dtpFechaFin.Value.Date;

                if (fin < inicio)
                {
                    MessageBox.Show("La fecha de fin no puede ser menor a la fecha de inicio.", "Error Cronológico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            List<ReporteCitasAusentes> datos = nCita.ObtenerMetricasAusencias(inicio, fin);

            chartAusencias.Series.Clear();
            chartAusencias.ChartAreas.Clear();
            chartAusencias.Titles.Clear();
            rtbInterpretacion.Clear();

            if (datos == null || datos.Count == 0)
            {
                rtbInterpretacion.Text = "Interpretación:\nNo se encontraron registros de citas canceladas en el rango de fechas seleccionado.";
                return;
            }

            if (cbOrdenarPor.Text == "Pérdida Económica (Mayor a Menor)")
            {
                datos = datos.OrderByDescending(d => d.CostoPerdida).ToList();
            }
            else if (cbOrdenarPor.Text == "Pérdida Económica (Menor a Mayor)")
            {
                datos = datos.OrderBy(d => d.CostoPerdida).ToList();
            }
            else if (cbOrdenarPor.Text == "Cronológico Semántico")
            {
                datos = datos.OrderBy(d => d.Criterio).ToList();
            }

            ChartArea areaGrafico = new ChartArea("AreaPrincipal");
            areaGrafico.AxisX.Title = "Meses Evaluados";
            areaGrafico.AxisX.Interval = 1;
            areaGrafico.AxisY.Title = "Impacto de Pérdida Económica (S/.)";
            areaGrafico.AxisY.LabelStyle.Format = "C0";
            chartAusencias.ChartAreas.Add(areaGrafico);

            double totalPerdidoMuestra = datos.Sum(d => d.CostoPerdida);

            Title tituloDashboard = new Title();
            string subTitulo = esCargaInicial ? "HISTORIAL HISTÓRICO COMPLETO" : "PERIODO SELECCIONADO";
            tituloDashboard.Text = "PÉRDIDAS FINANCIERAS POR CITAS CANCELADAS\n" + subTitulo + " | Total: S/. " + totalPerdidoMuestra.ToString("N2");
            tituloDashboard.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tituloDashboard.ForeColor = Color.Maroon;
            chartAusencias.Titles.Add(tituloDashboard);

            Series serieBarras = new Series("Pérdidas");
            serieBarras.ChartType = SeriesChartType.Column;
            serieBarras.Palette = ChartColorPalette.Chocolate;

            int grosorBarra = 6;
            if (int.TryParse(txtAnchoBarra.Text.Trim(), out grosorBarra) && grosorBarra >= 1 && grosorBarra <= 10)
            {
                serieBarras["PointWidth"] = (grosorBarra / 10.0).ToString();
            }
            else
            {
                serieBarras["PointWidth"] = "0.6";
                txtAnchoBarra.Text = "6";
            }

            foreach (var fila in datos)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(fila.Criterio, fila.CostoPerdida);
                punto.Label = "S/. " + fila.CostoPerdida.ToString("N2");
                punto.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                punto.LabelForeColor = Color.DarkBlue;
                serieBarras.Points.Add(punto);
            }
            chartAusencias.Series.Add(serieBarras);

            var peorMes = datos.OrderByDescending(d => d.CostoPerdida).First();
            double porcentajeDelPeorMes = totalPerdidoMuestra > 0 ? (peorMes.CostoPerdida / totalPerdidoMuestra) * 100 : 0;

            string nivelImpacto = "";
            string recomendacionCorta = "";

            if (totalPerdidoMuestra > 3000)
            {
                nivelImpacto = "una fuga económica crítica";
                recomendacionCorta = "se recomienda implementar de urgencia cobros anticipados del 50% al reservar.";
            }
            else if (totalPerdidoMuestra > 1000)
            {
                nivelImpacto = "un impacto financiero moderado";
                recomendacionCorta = "se sugiere reforzar el envío automatizado de recordatorios 24 horas antes.";
            }
            else
            {
                nivelImpacto = "un impacto financiero bajo";
                recomendacionCorta = "se recomienda mantener el seguimiento continuo del área y revisar su evolución."; // Idéntico a tu cap
            }

            StringBuilder analisis = new StringBuilder();
            analisis.AppendLine("Interpretación:");
            analisis.AppendLine(string.Format("El mes de {0} concentra la mayor pérdida con {1} citas canceladas, representando el {2:0.0}% del total (S/. {3:N2}). Esto indica {4}, por lo que {5}",
                peorMes.Criterio,
                peorMes.TotalAusencias,
                porcentajeDelPeorMes,
                peorMes.CostoPerdida,
                nivelImpacto,
                recomendacionCorta));

            rtbInterpretacion.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            rtbInterpretacion.Text = analisis.ToString();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ProcesarYRenderizarGrafico(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

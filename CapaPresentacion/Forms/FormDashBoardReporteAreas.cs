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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using FontPDF = iTextSharp.text.Font;

namespace CapaPresentacion
{
    public partial class FormDashBoardReporteAreas : Form
    {
        private NReporte nReporte = new NReporte();

        private List<ReporteDemandaArea> reporteActual = new List<ReporteDemandaArea>();

        public FormDashBoardReporteAreas()
        {
            InitializeComponent();
        }

        private void FormDashBoardReporteAreas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarReporte();
        }

        private void CargarCombos()
        {
            cbEstado.DataSource = null;
            cbEstado.DataSource = nReporte.ListarEstadosCaso();

            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            string estado = cbEstado.Text;
            string orden = cbOrden.Text;

            if (estado == "" || orden == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.");
                return;
            }

            reporteActual = nReporte.ReporteDemandaPorArea(fechaInicio, fechaFin, estado, orden);

            if (reporteActual.Count == 0)
            {
                LimpiarReporte();
                MessageBox.Show("No se encontraron datos para los filtros seleccionados.");
                return;
            }

            MostrarTabla(reporteActual);
            MostrarGrafico(reporteActual);
            MostrarTarjetas(reporteActual);
            MostrarInterpretacion(reporteActual);
        }

        private void MostrarTabla(List<ReporteDemandaArea> reporte)
        {
            dgReportes.DataSource = null;
            if (reporte.Count > 0)
            {
                dgReportes.DataSource = reporte;

                dgReportes.Columns["Area"].HeaderText = "Área";
                dgReportes.Columns["TotalCasos"].HeaderText = "Total de casos";
                dgReportes.Columns["CasosActivos"].HeaderText = "Casos activos";
                dgReportes.Columns["CasosCerrados"].HeaderText = "Casos cerrados";
                dgReportes.Columns["PorcentajeDemanda"].HeaderText = "% Demanda";
                dgReportes.Columns["EspecialistasDisponibles"].HeaderText = "Especialistas disponibles";
                dgReportes.Columns["Recomendacion"].HeaderText = "Recomendación";

                dgReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void MostrarGrafico(List<ReporteDemandaArea> reporte)
        {
            ctAreas.Series.Clear();
            ctAreas.ChartAreas.Clear();
            ctAreas.Titles.Clear();

            ChartArea chartArea = new ChartArea();
            ctAreas.ChartAreas.Add(chartArea);

            Series serie = new Series("Demanda por área");

            if (cbGrafico.Text == "Circular")
            {
                serie.ChartType = SeriesChartType.Pie;
                serie.IsValueShownAsLabel = true;
            }
            else
            {
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;
            }

            foreach (ReporteDemandaArea item in reporte)
            {
                serie.Points.AddXY(item.Area, item.TotalCasos);
            }

            ctAreas.Series.Add(serie);
            ctAreas.Titles.Add("Demanda de casos por área");
        }

        private void MostrarTarjetas(List<ReporteDemandaArea> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);
            int totalEspecialistas = reporte.Sum(r => r.EspecialistasDisponibles);

            ReporteDemandaArea areaMayor = reporte
                .OrderByDescending(r => r.TotalCasos)
                .FirstOrDefault();

            lblTotalCasos.Text = totalCasos.ToString();
            lblEspecialistasDispo.Text = totalEspecialistas.ToString();

            if (areaMayor != null)
            {
                lblMayorArea.Text = areaMayor.Area;
            }
            else
            {
                lblMayorArea.Text = "-";
            }
        }

        private void MostrarInterpretacion(List<ReporteDemandaArea> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);

            ReporteDemandaArea areaMayor = reporte
                .OrderByDescending(r => r.TotalCasos)
                .FirstOrDefault();

            if (areaMayor == null || totalCasos == 0)
            {
                lblInterpretacion.Text = "No hay información suficiente para generar una interpretación.";
                return;
            }

            lblInterpretacion.Text =
                "El área " + areaMayor.Area +
                " concentra la mayor demanda con " + areaMayor.TotalCasos +
                " casos registrados, representando el " + areaMayor.PorcentajeDemanda +
                "% del total. ";

            if (areaMayor.PorcentajeDemanda >= 50)
            {
                lblInterpretacion.Text +=
                    "Esto indica una alta concentración de casos en dicha área, por lo que se recomienda evaluar la contratación de más especialistas o redistribuir la carga laboral.";
            }
            else if (areaMayor.PorcentajeDemanda >= 20)
            {
                lblInterpretacion.Text +=
                    "Esto indica una demanda moderada, por lo que se recomienda mantener el seguimiento del área y revisar su evolución.";
            }
            else
            {
                lblInterpretacion.Text +=
                    "Esto indica una demanda baja, por lo que no se requiere reforzar el área por el momento.";
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarReporte();
        }

        private void LimpiarReporte()
        {
            reporteActual = new List<ReporteDemandaArea>();

            dgReportes.DataSource = null;

            ctAreas.Series.Clear();
            ctAreas.ChartAreas.Clear();
            ctAreas.Titles.Clear();

            lblTotalCasos.Text = "0";
            lblMayorArea.Text = "-";
            lblEspecialistasDispo.Text = "0";
            lblInterpretacion.Text = " ";

            if (cbEstado.Items.Count > 0)
            {
                cbEstado.SelectedIndex = 0;
            }

            if (cbGrafico.Items.Count > 0)
            {
                cbGrafico.SelectedIndex = 0;
            }

            if (cbOrden.Items.Count > 0)
            {
                cbOrden.SelectedIndex = 0;
            }

            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reporteActual == null || reporteActual.Count == 0)
            {
                return;
            }

            MostrarGrafico(reporteActual);
        }

        private void btnExpoPDF_Click(object sender, EventArgs e)
        {
            if (reporteActual == null || reporteActual.Count == 0)
            {
                MessageBox.Show("Primero debe generar un reporte.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo PDF|*.pdf";
            save.Title = "Guardar reporte PDF";
            save.FileName = "Reporte_Demanda_Areas.pdf";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                Document documento = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);

                PdfWriter.GetInstance(
                    documento,
                    new FileStream(save.FileName, FileMode.Create)
                );

                documento.Open();

                FontPDF fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                FontPDF fuenteSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                FontPDF fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                FontPDF fuenteTablaHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9);
                FontPDF fuenteTabla = FontFactory.GetFont(FontFactory.HELVETICA, 8);

                Paragraph titulo = new Paragraph("REPORTE DE DEMANDA POR ÁREA DE CONSULTORÍA", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 10;
                documento.Add(titulo);

                Paragraph empresa = new Paragraph("CONSULTORÍAS PROFESIONALES ALBA", fuenteSubtitulo);
                empresa.Alignment = Element.ALIGN_CENTER;
                empresa.SpacingAfter = 20;
                documento.Add(empresa);

                PdfPTable tablaInfo = new PdfPTable(4);
                tablaInfo.WidthPercentage = 100;
                tablaInfo.SpacingAfter = 15;
                tablaInfo.SetWidths(new float[] { 20, 30, 20, 30 });

                AgregarCeldaInfo(tablaInfo, "Fecha inicio:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, dtpFechaInicio.Value.ToShortDateString(), fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Fecha fin:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, dtpFechaFin.Value.ToShortDateString(), fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Estado:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, cbEstado.Text, fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Fecha de emisión:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal);

                documento.Add(tablaInfo);

                Paragraph subtituloResumen = new Paragraph("1. RESUMEN EJECUTIVO", fuenteSubtitulo);
                subtituloResumen.SpacingAfter = 8;
                documento.Add(subtituloResumen);

                PdfPTable tablaResumen = new PdfPTable(4);
                tablaResumen.WidthPercentage = 100;
                tablaResumen.SpacingAfter = 15;
                tablaResumen.SetWidths(new float[] { 25, 25, 25, 25 });

                int totalActivosPDF = reporteActual.Sum(r => r.CasosActivos);

                AgregarCeldaResumen(tablaResumen, "Total de casos", lblTotalCasos.Text, fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Área con mayor demanda", lblMayorArea.Text, fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Casos activos", totalActivosPDF.ToString(), fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Especialistas disponibles", lblEspecialistasDispo.Text, fuenteTablaHeader, fuenteNormal);

                documento.Add(tablaResumen);

                Paragraph subtituloDetalle = new Paragraph("2. DETALLE DEL REPORTE", fuenteSubtitulo);
                subtituloDetalle.SpacingAfter = 8;
                documento.Add(subtituloDetalle);

                PdfPTable tabla = new PdfPTable(7);
                tabla.WidthPercentage = 100;
                tabla.SpacingAfter = 15;
                tabla.SetWidths(new float[] { 22, 12, 12, 12, 12, 15, 25 });

                AgregarEncabezado(tabla, "Área", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Total casos", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Activos", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Cerrados", fuenteTablaHeader);
                AgregarEncabezado(tabla, "% Demanda", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Especialistas", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Recomendación", fuenteTablaHeader);

                foreach (ReporteDemandaArea item in reporteActual)
                {
                    AgregarCelda(tabla, item.Area, fuenteTabla);
                    AgregarCelda(tabla, item.TotalCasos.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.CasosActivos.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.CasosCerrados.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.PorcentajeDemanda.ToString("0.00") + "%", fuenteTabla);
                    AgregarCelda(tabla, item.EspecialistasDisponibles.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.Recomendacion, fuenteTabla);
                }

                documento.Add(tabla);

                Paragraph subtituloInterpretacion = new Paragraph("3. INTERPRETACIÓN DEL REPORTE", fuenteSubtitulo);
                subtituloInterpretacion.SpacingAfter = 8;
                documento.Add(subtituloInterpretacion);

                Paragraph interpretacion = new Paragraph(lblInterpretacion.Text, fuenteNormal);
                interpretacion.Alignment = Element.ALIGN_JUSTIFIED;
                interpretacion.SpacingAfter = 15;
                documento.Add(interpretacion);

                Paragraph subtituloConclusion = new Paragraph("4. CONCLUSIÓN", fuenteSubtitulo);
                subtituloConclusion.SpacingAfter = 8;
                documento.Add(subtituloConclusion);

                ReporteDemandaArea areaMayor = reporteActual
                    .OrderByDescending(r => r.TotalCasos)
                    .FirstOrDefault();

                string conclusion = "";

                if (areaMayor != null)
                {
                    conclusion =
                        "De acuerdo con los resultados obtenidos, el área de " + areaMayor.Area +
                        " presenta la mayor concentración de demanda. Por ello, se recomienda a la administración evaluar la disponibilidad de especialistas, la distribución de casos y la necesidad de reforzar dicha área para mejorar la atención de los clientes.";
                }
                else
                {
                    conclusion = "No se cuenta con información suficiente para emitir una conclusión.";
                }

                Paragraph parrafoConclusion = new Paragraph(conclusion, fuenteNormal);
                parrafoConclusion.Alignment = Element.ALIGN_JUSTIFIED;
                documento.Add(parrafoConclusion);

                documento.Close();

                MessageBox.Show("PDF exportado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message);
            }
        }

        private void AgregarEncabezado(PdfPTable tabla, string texto, FontPDF fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Padding = 6;
            tabla.AddCell(celda);
        }

        private void AgregarCelda(PdfPTable tabla, string texto, FontPDF fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Padding = 5;
            tabla.AddCell(celda);
        }

        private void AgregarCeldaInfo(PdfPTable tabla, string texto, FontPDF fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.Padding = 5;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabla.AddCell(celda);
        }

        private void AgregarCeldaResumen(PdfPTable tabla, string titulo, string valor, FontPDF fuenteTitulo, FontPDF fuenteValor)
        {
            PdfPCell celda = new PdfPCell();

            Paragraph pTitulo = new Paragraph(titulo, fuenteTitulo);
            pTitulo.Alignment = Element.ALIGN_CENTER;

            Paragraph pValor = new Paragraph(valor, fuenteValor);
            pValor.Alignment = Element.ALIGN_CENTER;

            celda.AddElement(pTitulo);
            celda.AddElement(pValor);
            celda.Padding = 8;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;

            tabla.AddCell(celda);
        }

        private void cbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            // no va nada me equivoqué 
        }
    }
}
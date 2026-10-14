using CapaDatos;
using CapaNegocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FontPDF = iTextSharp.text.Font;

namespace CapaPresentacion.Forms
{
    public partial class FormDashboardCargaLaboralxEspecialista : Form
    {
        private NReporte nReporte = new NReporte();
        private List<ReporteCargaEspecialista> reporteActual = new List<ReporteCargaEspecialista>();

        public FormDashboardCargaLaboralxEspecialista()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            string orden = cbOrden.Text;

            if (orden == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.");
                return;
            }

            reporteActual = nReporte.ReporteCargaLaboralPorEspecialista(fechaInicio, fechaFin, orden);

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

        private void MostrarTabla(List<ReporteCargaEspecialista> reporte)
        {
            dgReportes.DataSource = null;

            if (reporte != null && reporte.Count > 0)
            {
                dgReportes.DataSource = reporte;

                if (dgReportes.Columns["IdEspecialista"] != null)
                    dgReportes.Columns["IdEspecialista"].Visible = false;

                dgReportes.Columns["NombreEspecialista"].HeaderText = "Especialista";
                dgReportes.Columns["Area"].HeaderText = "Área";
                dgReportes.Columns["TotalCasos"].HeaderText = "Total de casos";
                dgReportes.Columns["CasosActivos"].HeaderText = "Casos activos";
                dgReportes.Columns["CasosCerrados"].HeaderText = "Casos cerrados";
                dgReportes.Columns["TotalCitas"].HeaderText = "Total de citas";
                dgReportes.Columns["PorcentajeDemanda"].HeaderText = "% Carga Laboral";
                dgReportes.Columns["Recomendacion"].Visible = false;

                dgReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LimpiarReporte()
        {
            reporteActual = new List<ReporteCargaEspecialista>();

            dgReportes.DataSource = null;

            ctCasos.Series.Clear();
            ctCasos.ChartAreas.Clear();
            ctCasos.Titles.Clear();

            lblTotalCasos.Text = "0";
            lblNumEspecialista.Text = "0";
            lblInterpretacion.Text = " ";

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

        private void MostrarGrafico(List<ReporteCargaEspecialista> reporte)
        {
            ctCasos.Series.Clear();
            ctCasos.ChartAreas.Clear();
            ctCasos.Titles.Clear();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            ctCasos.ChartAreas.Add(chartArea);

            System.Windows.Forms.DataVisualization.Charting.Series serie = new System.Windows.Forms.DataVisualization.Charting.Series("Carga por especialista");

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

            foreach (ReporteCargaEspecialista item in reporte)
            {
                serie.Points.AddXY(item.NombreEspecialista, item.TotalCasos);
            }

            ctCasos.Series.Add(serie);
            ctCasos.Titles.Add("Distribución de casos por especialista");
        }

        /*private void MostrarTarjetas(List<ReporteCargaEspecialista> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);
            int totalEspecialistas = reporte.Count;

            ReporteCargaEspecialista especialistaMayorCarga = reporte
                .OrderByDescending(r => r.TotalCasos)
                .FirstOrDefault();

            lblTotalCasos.Text = totalCasos.ToString();
            lblNumEspecialista.Text = totalEspecialistas.ToString();

            if (especialistaMayorCarga != null)
            {
                lblEspecialistaSaturado.Text = especialistaMayorCarga.NombreEspecialista;
            }
        }*/

        private void MostrarTarjetas(List<ReporteCargaEspecialista> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);
            int totalEspecialistas = reporte.Count;

            lblTotalCasos.Text = totalCasos.ToString();
            lblNumEspecialista.Text = totalEspecialistas.ToString();

            int maxCasos = reporte.Max(r => r.TotalCasos);
            var especialistasEmpatados = reporte.Where(r => r.TotalCasos == maxCasos).ToList();

            if (especialistasEmpatados.Count > 0)
            {
                List<string> nombres = new List<string>();
                foreach (var especialista in especialistasEmpatados)
                {
                    nombres.Add(especialista.NombreEspecialista);
                }
                lblEspecialistaSaturado.Text = string.Join(", ", nombres);
            }
            else
            {
                lblEspecialistaSaturado.Text = "-";
            }
        }

        /*private void MostrarInterpretacion(List<ReporteCargaEspecialista> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);

            ReporteCargaEspecialista especialistaMayor = reporte
                .OrderByDescending(r => r.TotalCasos)
                .FirstOrDefault();

            if (especialistaMayor == null || totalCasos == 0)
            {
                lblInterpretacion.Text = "No hay información suficiente para generar una interpretación.";
                return;
            }

            lblInterpretacion.Text =
                "El especialista " + especialistaMayor.NombreEspecialista + " (" + especialistaMayor.Area + ")" +
        " concentra la mayor carga laboral con " + especialistaMayor.TotalCasos +
        " casos asignados, representando el " + especialistaMayor.PorcentajeDemanda +
        "% de la operación total. ";

            if (especialistaMayor.PorcentajeDemanda >= 50)
            {
                lblInterpretacion.Text +=
                    "Esto indica una alta concentración de expedientes en un solo miembro del equipo, por lo que se recomienda pausar nuevas asignaciones para él y redistribuir los casos urgentes.";
            }
            else if (especialistaMayor.PorcentajeDemanda >= 20)
            {
                lblInterpretacion.Text +=
                    "Esto indica una carga laboral moderada y sostenible, aunque se aconseja monitorear que el número de citas semanales no interfiera con sus plazos de entrega.";
            }
            else
            {
                lblInterpretacion.Text +=
                    "Esto indica un escenario de carga baja o distribución equitativa. El equipo cuenta con disponibilidad inmediata para asumir nuevos procesos sin riesgo de saturación.";
            }
        }*/

        private void MostrarInterpretacion(List<ReporteCargaEspecialista> reporte)
        {
            int totalCasos = reporte.Sum(r => r.TotalCasos);

            if (reporte == null || reporte.Count == 0 || totalCasos == 0)
            {
                lblInterpretacion.Text = "No hay información suficiente para generar una interpretación.";
                return;
            }
            int maxCasos = reporte.Max(r => r.TotalCasos);
            var lideresCarga = reporte.Where(r => r.TotalCasos == maxCasos).ToList();
            var primerLider = lideresCarga.FirstOrDefault();

            if (lideresCarga.Count > 1)
            {
                lblInterpretacion.Text =
                    "Se detecta un empate técnico en la asignación operativa. Un total de " + lideresCarga.Count +
                    " especialistas concentran de manera equitativa la mayor carga laboral con " + maxCasos +
                    " casos cada uno, representando individualmente el " + primerLider.PorcentajeDemanda +
                    "% de la operación total. ";
            }
            else
            {
                lblInterpretacion.Text =
                    "El especialista " + primerLider.NombreEspecialista + " (" + primerLider.Area + ")" +
                    " concentra la mayor carga laboral con " + primerLider.TotalCasos +
                    " casos asignados, representando el " + primerLider.PorcentajeDemanda +
                    "% de la operación total. ";
            }
            if (primerLider.PorcentajeDemanda >= 50)
            {
                lblInterpretacion.Text +=
                    "Esto indica una alta concentración de expedientes en un sector reducido del equipo, " +
                    "por lo que se recomienda pausar nuevas asignaciones operativas en este rango.";
            }
            else if (primerLider.PorcentajeDemanda >= 20)
            {
                lblInterpretacion.Text +=
                    "Esto indica una carga laboral moderada y sostenible, aunque se aconseja monitorear " +
                    "las agendas semanales del personal más solicitado.";
            }
            else
            {
                lblInterpretacion.Text +=
                    "Esto indica un escenario de carga baja o distribución equitativa. El equipo cuenta con " +
                    "disponibilidad inmediata para asumir nuevos procesos sin riesgo de saturación.";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarReporte();
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
            save.FileName = "Reporte_Carga_Laboral_Especialistas.pdf";

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

                Paragraph titulo = new Paragraph("REPORTE DE CARGA LABORAL POR ESPECIALISTA", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 10;
                documento.Add(titulo);

                Paragraph empresa = new Paragraph("CONSULTORÍAS PROFESIONALES ALBA", fuenteSubtitulo);
                empresa.Alignment = Element.ALIGN_CENTER;
                empresa.SpacingAfter = 20;
                documento.Add(empresa);

                // Tabla con metadatos del reporte (Se removió la fila del Combo de áreas)
                PdfPTable tablaInfo = new PdfPTable(4);
                tablaInfo.WidthPercentage = 100;
                tablaInfo.SpacingAfter = 15;
                tablaInfo.SetWidths(new float[] { 20, 30, 20, 30 });

                AgregarCeldaInfo(tablaInfo, "Fecha inicio:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, dtpFechaInicio.Value.ToShortDateString(), fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Fecha fin:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, dtpFechaFin.Value.ToShortDateString(), fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Filtro aplicado:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, "General (Todos)", fuenteNormal);

                AgregarCeldaInfo(tablaInfo, "Fecha de emisión:", fuenteTablaHeader);
                AgregarCeldaInfo(tablaInfo, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal);

                documento.Add(tablaInfo);

                Paragraph subtituloResumen = new Paragraph("1. RESUMEN EJECUTIVO", fuenteSubtitulo);
                subtituloResumen.SpacingAfter = 8;
                documento.Add(subtituloResumen);

                // Tabla de Resumen Ejecutivo adaptada a tus tarjetas reales
                PdfPTable tablaResumen = new PdfPTable(4);
                tablaResumen.WidthPercentage = 100;
                tablaResumen.SpacingAfter = 15;
                tablaResumen.SetWidths(new float[] { 25, 25, 25, 25 });

                int totalCitasPDF = reporteActual.Sum(r => r.TotalCitas);

                AgregarCeldaResumen(tablaResumen, "Total de casos", lblTotalCasos.Text, fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Total de citas", totalCitasPDF.ToString(), fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Número de especialistas", lblNumEspecialista.Text, fuenteTablaHeader, fuenteNormal);
                AgregarCeldaResumen(tablaResumen, "Especialista con mayor carga", lblEspecialistaSaturado.Text, fuenteTablaHeader, fuenteNormal);

                documento.Add(tablaResumen);

                Paragraph subtituloDetalle = new Paragraph("2. DETALLE DEL REPORTE", fuenteSubtitulo);
                subtituloDetalle.SpacingAfter = 8;
                documento.Add(subtituloDetalle);

                // Tabla detalle configurada con las 7 columnas visibles de tu DataGrid
                PdfPTable tabla = new PdfPTable(7);
                tabla.WidthPercentage = 100;
                tabla.SpacingAfter = 15;
                tabla.SetWidths(new float[] { 25, 12, 12, 12, 12, 12, 15 });

                AgregarEncabezado(tabla, "Especialista", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Área", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Total casos", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Activos", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Cerrados", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Total citas", fuenteTablaHeader);
                AgregarEncabezado(tabla, "% Carga Laboral", fuenteTablaHeader);

                foreach (ReporteCargaEspecialista item in reporteActual)
                {
                    AgregarCelda(tabla, item.NombreEspecialista, fuenteTabla);
                    AgregarCelda(tabla, item.Area, fuenteTabla);
                    AgregarCelda(tabla, item.TotalCasos.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.CasosActivos.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.CasosCerrados.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.TotalCitas.ToString(), fuenteTabla);
                    AgregarCelda(tabla, item.PorcentajeDemanda.ToString("0.00") + "%", fuenteTabla);
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

                // Lógica de conclusión adaptada al especialista con mayor asignación de expedientes
                ReporteCargaEspecialista especialistaMayor = reporteActual
                    .OrderByDescending(r => r.TotalCasos)
                    .FirstOrDefault();

                string conclusion = "";

                if (especialistaMayor != null)
                {
                    conclusion =
                        "De acuerdo con los resultados analizados en el periodo seleccionado, el especialista " + especialistaMayor.NombreEspecialista +
                        " perteneciente al área de " + especialistaMayor.Area +
                        " presenta el índice más alto de carga operativa dentro del bufete. Por lo tanto, se sugiere al área de gestión corporativa evaluar la distribución de futuros ingresos de causas procesales o coordinar medidas de apoyo administrativo para mitigar riesgos operacionales.";
                }
                else
                {
                    conclusion = "No se cuenta con información suficiente para emitir una conclusión sobre la carga del personal.";
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
    }
}

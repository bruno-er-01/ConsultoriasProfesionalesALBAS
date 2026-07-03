using CapaDatos;
using CapaNegocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FontPDF = iTextSharp.text.Font;

namespace CapaPresentacion.Forms
{
    public partial class FormDashboardReporteAntiguedadCasos : Form
    {
        private NCaso nCaso = new NCaso();
        private List<ReporteAntiguedadCaso> listaCasos;
        private List<ReporteAntiguedadCaso> listaFiltradaActual;
        private DataPoint puntoAnterior;
        private Color colorAnterior;

        public FormDashboardReporteAntiguedadCasos()
        {
            InitializeComponent();
            CargarReporte();
            cbArea.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0; 
        }

        private void CargarReporte()
        {
            listaCasos = nCaso.ListarReporteAntiguedad();
            dgCasos.DataSource = null;
            dgCasos.DataSource = nCaso.ListarReporteAntiguedad();
            dgCasos.Columns["NroCaso"].Visible = false;
            MostrarIndicadores(listaCasos);
        }

        private void FiltrarReporte()
        {
            List<ReporteAntiguedadCaso> listaFiltrada =
                new List<ReporteAntiguedadCaso>();

            string areaSeleccionada = cbArea.Text;
            string estadoSeleccionado = cbEstado.Text;

            foreach (ReporteAntiguedadCaso caso in listaCasos)
            {
                bool cumpleArea =
                    areaSeleccionada == "Todas las áreas" ||
                    caso.Area == areaSeleccionada;

                bool cumpleEstado =
                    estadoSeleccionado == "Todos" ||
                    caso.Estado == estadoSeleccionado;

                if (cumpleArea && cumpleEstado)
                {
                    listaFiltrada.Add(caso);
                }
            }

            listaFiltradaActual = listaFiltrada;
            dgCasos.DataSource = null;
            dgCasos.DataSource = listaFiltrada;
            dgCasos.Columns["NroCaso"].Visible = false;

            MostrarIndicadores(listaFiltrada);

            if (cbArea.Text == "Todas las áreas")
            {
                MostrarGraficoTodasLasAreas(listaFiltrada);
            }
            else
            {
                MostrarGraficoArea(listaFiltrada);
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarReporte();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarReporte();
        }

        private void MostrarIndicadores(List<ReporteAntiguedadCaso> listaFiltrada)
        {
            lblTotalCasos.Text = listaFiltrada.Count.ToString();

            int cantidadCriticos = 0;
            int sumaDias = 0;

            foreach (ReporteAntiguedadCaso caso in listaFiltrada)
            {
                sumaDias += caso.DiasAntiguedad;

                if (caso.Clasificacion == "Crítico")
                {
                    cantidadCriticos++;
                }
            }

            lblCasosCriticos.Text = cantidadCriticos.ToString();

            if (listaFiltrada.Count > 0)
            {
                double promedio = (double)sumaDias / listaFiltrada.Count;
                lblPromedioAntiguedad.Text = promedio.ToString("0.0") + " días";
            }
            else
            {
                lblPromedioAntiguedad.Text = "0 días";
            }

            MostrarAreaConMasCriticos(listaFiltrada);
        }

        private void MostrarAreaConMasCriticos(List<ReporteAntiguedadCaso> listaFiltrada)
        {
            if (cbArea.Text == "Todas las áreas")
            {
                titleAreaCasosCriticos.Text = "Área con más casos críticos:";
                string areaMayor = "-";
                int mayorCantidad = 0;
                string[] areas = {"Familiar", "Civil", "Judicial", "Conciliación"};

                foreach (string area in areas)
                {
                    int cantidad = 0;

                    foreach (ReporteAntiguedadCaso caso in listaFiltrada)
                    {
                        if (caso.Area == area &&
                            caso.Clasificacion == "Crítico")
                        {
                            cantidad++;
                        }
                    }

                    if (cantidad > mayorCantidad)
                    {
                        mayorCantidad = cantidad;
                        areaMayor = area;
                    }
                }

                lblAreaCritica.Text = areaMayor;
            }
            else
            {
                titleAreaCasosCriticos.Text = "Cantidad de casos más antiguos:";

                if (listaFiltrada.Count == 0)
                {
                    lblAreaCritica.Text = "0";
                    return;
                }

                int mayorAntiguedad = listaFiltrada[0].DiasAntiguedad;
                int cantidadCasos = 0;

                foreach (ReporteAntiguedadCaso caso in listaFiltrada)
                {
                    if (caso.DiasAntiguedad > mayorAntiguedad)
                    {
                        mayorAntiguedad = caso.DiasAntiguedad;
                    }
                }

                foreach (ReporteAntiguedadCaso caso in listaFiltrada)
                {
                    if (caso.DiasAntiguedad == mayorAntiguedad)
                    {
                        cantidadCasos++;
                    }
                }

                lblAreaCritica.Text = cantidadCasos.ToString();
            }
        }

        private void MostrarGraficoTodasLasAreas(List<ReporteAntiguedadCaso> listaFiltrada)
        {
            chartAntiguedad.Series.Clear();
            //Centrar
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Auto = false;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.X = 18;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Y = 10;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Width = 77;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Height = 66;

            Series serieRecientes = new Series("Reciente");
            Series serieSeguimiento = new Series("En seguimiento");
            Series serieCriticos = new Series("Crítico");

            serieRecientes.ChartType = SeriesChartType.Column;
            serieSeguimiento.ChartType = SeriesChartType.Column;
            serieCriticos.ChartType = SeriesChartType.Column;

            serieRecientes.Color = Color.LimeGreen;
            serieSeguimiento.Color = Color.Yellow;
            serieCriticos.Color = Color.Red;

            string[] areas = {"Familiar", "Civil", "Judicial", "Conciliación"};

            foreach (string area in areas)
            {
                int recientes = 0;
                int seguimiento = 0;
                int criticos = 0;

                foreach (ReporteAntiguedadCaso caso in listaFiltrada)
                {
                    if (caso.Area == area)
                    {
                        if (caso.Clasificacion == "Reciente")
                        {
                            recientes++;
                        }
                        else if (caso.Clasificacion == "En seguimiento")
                        {
                            seguimiento++;
                        }
                        else if (caso.Clasificacion == "Crítico")
                        {
                            criticos++;
                        }
                    }
                }

                serieRecientes.Points.AddXY(area, recientes);
                serieSeguimiento.Points.AddXY(area, seguimiento);
                serieCriticos.Points.AddXY(area, criticos);
            }

            chartAntiguedad.Series.Add(serieRecientes);
            chartAntiguedad.Series.Add(serieSeguimiento);
            chartAntiguedad.Series.Add(serieCriticos);
        }

        private void MostrarGraficoArea(List<ReporteAntiguedadCaso> listaFiltrada)
        {
            chartAntiguedad.Series.Clear();
            //Centrar
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Auto = false;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.X = 20;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Y = 8;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Width = 60;
            chartAntiguedad.ChartAreas[0].InnerPlotPosition.Height = 80;

            Series serie = new Series("Antigüedad");
            serie.ChartType = SeriesChartType.Pie; 
            serie.IsValueShownAsLabel = true;
            serie.Label = "#PERCENT{P0}";

            int recientes = listaFiltrada.Count(c => c.Clasificacion == "Reciente");
            int seguimiento = listaFiltrada.Count(c => c.Clasificacion == "En seguimiento");
            int criticos = listaFiltrada.Count(c => c.Clasificacion == "Crítico");

            if (recientes > 0)
            {
                int p = serie.Points.AddXY("Reciente", recientes);
                serie.Points[p].Color = Color.LimeGreen;
            }

            if (seguimiento > 0)
            {
                int p = serie.Points.AddXY("En seguimiento", seguimiento);
                serie.Points[p].Color = Color.Yellow;
            }

            if (criticos > 0)
            {
                int p = serie.Points.AddXY("Crítico", criticos);
                serie.Points[p].Color = Color.Red;
            }

            chartAntiguedad.Series.Add(serie);
        }

        private void chartAntiguedad_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult resultado = chartAntiguedad.HitTest(e.X, e.Y);

            if (resultado.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint punto = resultado.Series.Points[resultado.PointIndex];

                string clasificacion = resultado.Series.Name;
                string area = punto.AxisLabel;

                List<ReporteAntiguedadCaso> listaSeleccionada = new List<ReporteAntiguedadCaso>();

                foreach (ReporteAntiguedadCaso caso in listaFiltradaActual)
                {
                    if (cbArea.Text == "Todas las áreas")
                    {
                        if (caso.Area == area &&
                            caso.Clasificacion == clasificacion)
                        {
                            listaSeleccionada.Add(caso);
                        }
                    }
                    else
                    {
                        clasificacion = punto.AxisLabel;

                        if (caso.Clasificacion == clasificacion)
                        {
                            listaSeleccionada.Add(caso);
                        }
                    }
                }

                dgCasos.DataSource = null;
                dgCasos.DataSource = listaSeleccionada;
                dgCasos.Columns["NroCaso"].Visible = false;
            }
        }

        private void chartAntiguedad_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult resultado = chartAntiguedad.HitTest(e.X, e.Y);

            if (resultado.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint punto = resultado.Series.Points[resultado.PointIndex];

                chartAntiguedad.Cursor = Cursors.Hand;

                if (puntoAnterior != punto)
                {
                    if (puntoAnterior != null)
                    {
                        puntoAnterior.SetCustomProperty("Exploded", "False");

                        if (!colorAnterior.IsEmpty)
                        {
                            puntoAnterior.Color = colorAnterior;
                        }
                    }

                    colorAnterior = Color.Empty;

                    if (resultado.Series.ChartType == SeriesChartType.Pie)
                    {
                        punto.SetCustomProperty("Exploded", "True");
                    }
                    else if (resultado.Series.ChartType == SeriesChartType.Column)
                    {
                        colorAnterior = punto.Color;
                        punto.Color = ControlPaint.LightLight(punto.Color);
                    }

                    puntoAnterior = punto;
                    chartAntiguedad.Invalidate();
                }
            }
            else
            {
                chartAntiguedad.Cursor = Cursors.Default;

                if (puntoAnterior != null)
                {
                    puntoAnterior.SetCustomProperty("Exploded", "False");

                    if (!colorAnterior.IsEmpty)
                    {
                        puntoAnterior.Color = colorAnterior;
                    }

                    puntoAnterior = null;
                    colorAnterior = Color.Empty;

                    chartAntiguedad.Invalidate();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbArea.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
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

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (listaFiltradaActual == null || listaFiltradaActual.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo PDF|*.pdf";
            save.Title = "Guardar reporte PDF";
            save.FileName = "Reporte_Antiguedad_Casos.pdf";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                Document documento = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);

                PdfWriter.GetInstance(documento, new FileStream(save.FileName, FileMode.Create));

                documento.Open();

                FontPDF fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                FontPDF fuenteSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                FontPDF fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                FontPDF fuenteTablaHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);
                FontPDF fuenteTabla = FontFactory.GetFont(FontFactory.HELVETICA, 7);
                Paragraph titulo = new Paragraph("REPORTE DE ANTIGÜEDAD DE CASOS",fuenteTitulo);

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

                AgregarCeldaInfo(
                    tablaInfo,
                    "Área:",
                    fuenteTablaHeader
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    cbArea.Text,
                    fuenteNormal
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    "Estado:",
                    fuenteTablaHeader
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    cbEstado.Text,
                    fuenteNormal
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    "Fecha de emisión:",
                    fuenteTablaHeader
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    fuenteNormal
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    "Cantidad de registros:",
                    fuenteTablaHeader
                );

                AgregarCeldaInfo(
                    tablaInfo,
                    listaFiltradaActual.Count.ToString(),
                    fuenteNormal
                );

                documento.Add(tablaInfo);
                //----
                Paragraph subtituloResumen = new Paragraph("1. RESUMEN DEL REPORTE", fuenteSubtitulo);

                subtituloResumen.SpacingAfter = 8;
                documento.Add(subtituloResumen);

                PdfPTable tablaResumen = new PdfPTable(4);

                tablaResumen.WidthPercentage = 100;
                tablaResumen.SpacingAfter = 15;

                tablaResumen.SetWidths(new float[] { 25, 25, 25, 25 });

                AgregarCeldaResumen(
                    tablaResumen,
                    "Total de casos",
                    lblTotalCasos.Text,
                    fuenteTablaHeader,
                    fuenteNormal
                );

                AgregarCeldaResumen(
                    tablaResumen,
                    "Casos críticos",
                    lblCasosCriticos.Text,
                    fuenteTablaHeader,
                    fuenteNormal
                );

                AgregarCeldaResumen(
                    tablaResumen,
                    "Promedio de antigüedad",
                    lblPromedioAntiguedad.Text,
                    fuenteTablaHeader,
                    fuenteNormal
                );

                AgregarCeldaResumen(
                    tablaResumen,
                    titleAreaCasosCriticos.Text,
                    lblAreaCritica.Text,
                    fuenteTablaHeader,
                    fuenteNormal
                );

                documento.Add(tablaResumen);
                //----
                Paragraph subtituloDetalle = new Paragraph("2. DETALLE DE LOS CASOS", fuenteSubtitulo);

                subtituloDetalle.SpacingAfter = 8;
                documento.Add(subtituloDetalle);

                PdfPTable tabla = new PdfPTable(8);

                tabla.WidthPercentage = 100;
                tabla.SpacingAfter = 15;

                tabla.SetWidths(
                    new float[]
                    {20, 18, 13, 18, 13, 12, 10, 14}
                );

                AgregarEncabezado(tabla, "Título", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Cliente", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Área", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Especialista", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Fecha inicio", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Estado", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Días", fuenteTablaHeader);
                AgregarEncabezado(tabla, "Clasificación", fuenteTablaHeader);

                foreach (ReporteAntiguedadCaso caso in listaFiltradaActual)
                {

                    AgregarCelda(
                        tabla,
                        caso.Titulo,
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.Cliente,
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.Area,
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.Especialista,
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.FechaInicio.ToString("dd/MM/yyyy"),
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.Estado,
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.DiasAntiguedad.ToString(),
                        fuenteTabla
                    );

                    AgregarCelda(
                        tabla,
                        caso.Clasificacion,
                        fuenteTabla
                    );
                }

                documento.Add(tabla);
                //-----
                Paragraph subtituloInterpretacion = new Paragraph("3. INTERPRETACIÓN", fuenteSubtitulo);

                subtituloInterpretacion.SpacingAfter = 8;
                documento.Add(subtituloInterpretacion);

                int cantidadCriticos = 0;

                foreach (ReporteAntiguedadCaso caso in listaFiltradaActual)
                {
                    if (caso.Clasificacion == "Crítico")
                    {
                        cantidadCriticos++;
                    }
                }

                string interpretacion = "El reporte contiene " + listaFiltradaActual.Count 
                    + " casos según los filtros seleccionados. " + cantidadCriticos +
                    " casos presentan una antigüedad crítica, " +
                    "por lo que requieren mayor seguimiento y prioridad.";

                Paragraph parrafoInterpretacion =
                    new Paragraph(interpretacion, fuenteNormal);

                parrafoInterpretacion.Alignment = Element.ALIGN_JUSTIFIED;

                documento.Add(parrafoInterpretacion);
                documento.Close();

                MessageBox.Show("PDF exportado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al exportar PDF: " + ex.Message
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

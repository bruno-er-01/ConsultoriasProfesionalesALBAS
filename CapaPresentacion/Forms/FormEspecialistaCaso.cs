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
            CargarDatosCaso();
        }
        private void CargarDatosCaso()
        {
            Caso caso = nCaso.BuscarPorNroCaso(nroCaso);

            if (caso == null)
            {
                MessageBox.Show("No se encontró el caso seleccionado.");
                this.Close();
                return;
            }

            lblCliente.Text = caso.Cliente.nombre + " " + caso.Cliente.apellido;
            lblDNI.Text = caso.Cliente.dni;
            lblNroCaso.Text = caso.nroCaso.ToString();
            lblTitulo.Text = caso.titulo;
            lblDescripcion.Text = caso.descripcion;
            lblDocumento.Text = caso.documento;
            lblFechaInicio.Text = caso.fechaHoraInicio.ToString("dd/MM/yyyy HH:mm");

            if (caso.fechaHoraFin == null)
            {
                lblFechaFin.Text = "Sin finalizar";
            }
            else
            {
                lblFechaFin.Text = caso.fechaHoraFin.Value.ToString("dd/MM/yyyy HH:mm");
            }

            lblEstadoActual.Text = caso.estado;

            if (caso.estado == "Cerrado" || caso.estado == "Archivado" || caso.estado == "Anulado")
            {
                cbEstadoCaso.Enabled = false;
                btnActualizarEstado.Enabled = false;
            }
            else
            {
                cbEstadoCaso.Enabled = true;
                btnActualizarEstado.Enabled = true;
            }
        }
        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (cbEstadoCaso.Text == "")
            {
                MessageBox.Show("Seleccione el nuevo estado.");
                return;
            }

            string estadoNuevo = cbEstadoCaso.Text;

            string mensaje = nCaso.ActualizarEstadoEspecialista(
                nroCaso,
                estadoNuevo,
                usuarioActual.idUsuario
            );

            MessageBox.Show(mensaje);

            CargarDatosCaso();
        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            FormEspecialistaBuscarCita form = new FormEspecialistaBuscarCita(usuarioActual, nroCaso);
            form.ShowDialog();

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo PDF (*.pdf)|*.pdf";
            save.FileName = "Caso_" + lblNroCaso.Text + ".pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                doc.Open();

                Paragraph titulo = new Paragraph("Reporte del Caso",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(2);
                tabla.WidthPercentage = 100;

                tabla.AddCell("Cliente");
                tabla.AddCell(lblCliente.Text);

                tabla.AddCell("DNI");
                tabla.AddCell(lblDNI.Text);

                tabla.AddCell("Nro. Caso");
                tabla.AddCell(lblNroCaso.Text);

                tabla.AddCell("Título");
                tabla.AddCell(lblTitulo.Text);

                tabla.AddCell("Descripción");
                tabla.AddCell(lblDescripcion.Text);

                tabla.AddCell("Documento");
                tabla.AddCell(lblDocumento.Text);

                tabla.AddCell("Fecha Inicio");
                tabla.AddCell(lblFechaInicio.Text);

                tabla.AddCell("Fecha Fin");
                tabla.AddCell(lblFechaFin.Text);

                tabla.AddCell("Estado Actual");
                tabla.AddCell(lblEstadoActual.Text);

                doc.Add(tabla);

                doc.Add(new Paragraph("\nGenerado por: " + usuarioActual.nombre + " " + usuarioActual.apellido));
                doc.Add(new Paragraph("Fecha de generación: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")));

                doc.Close();

                MessageBox.Show("PDF exportado correctamente.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
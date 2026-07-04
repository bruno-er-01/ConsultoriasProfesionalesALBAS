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

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de actualizar el estado del caso a " + estadoNuevo + "?",
                "Confirmar actualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

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
            //falta modificar
            //FormEspecialistaBuscarCita form = new FormEspecialistaBuscarCita(nroCaso);
            //form.ShowDialog();

        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }
    }
}

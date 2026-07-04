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

namespace CapaPresentacion
{
    public partial class FormEspecialistaBuscarCita : Form
    {
        private NCita nCita = new NCita();
        private int nroCaso;

        public FormEspecialistaBuscarCita(int nroCaso)
        {
            InitializeComponent();
            this.nroCaso = nroCaso;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCita.DataSource = null;

            var lista = nCita.ListarPorCaso(nroCaso);

            if (lista != null && lista.Count > 0)
            {
                dgCita.DataSource = lista;

                if (dgCita.Columns["idCita"] != null)
                {
                    dgCita.Columns["idCita"].Visible = false;
                }

                if (dgCita.Columns["nroCaso"] != null)
                {
                    dgCita.Columns["nroCaso"].Visible = false;
                }

                if (dgCita.Columns["Caso"] != null)
                {
                    dgCita.Columns["Caso"].Visible = false;
                }

                if (dgCita.Columns["tiempoAnticipacion"] != null)
                {
                    dgCita.Columns["tiempoAnticipacion"].Visible = false;
                }

                if (dgCita.Columns["activo"] != null)
                {
                    dgCita.Columns["activo"].Visible = false;
                }

                if (dgCita.Columns["createdBy"] != null)
                {
                    dgCita.Columns["createdBy"].Visible = false;
                }

                if (dgCita.Columns["createdAt"] != null)
                {
                    dgCita.Columns["createdAt"].Visible = false;
                }

                if (dgCita.Columns["modifiedBy"] != null)
                {
                    dgCita.Columns["modifiedBy"].Visible = false;
                }

                if (dgCita.Columns["modifiedAt"] != null)
                {
                    dgCita.Columns["modifiedAt"].Visible = false;
                }
            }
        }

        private void dgCita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCita.SelectedRows.Count > 0)
            {
                var fila = dgCita.SelectedRows[0];

                if (fila.Cells["idCita"].Value != null)
                {
                    tbId.Text = fila.Cells["idCita"].Value.ToString();
                }

                if (fila.Cells["fecha"].Value != null)
                {
                    tbFecha.Text = Convert.ToDateTime(fila.Cells["fecha"].Value).ToShortDateString();
                }

                if (fila.Cells["estado"].Value != null)
                {
                    cbEstado.Text = fila.Cells["estado"].Value.ToString();
                }

                if (fila.Cells["confirmacionAsistencia"].Value != null)
                {
                    bool asistencia = Convert.ToBoolean(fila.Cells["confirmacionAsistencia"].Value);

                    if (asistencia == true)
                    {
                        cbAsistencia.Text = "Si";
                    }
                    else
                    {
                        cbAsistencia.Text = "No";
                    }
                }

                if (fila.Cells["observacion"].Value != null)
                {
                    rtcDescripcion.Text = fila.Cells["observacion"].Value.ToString();
                }
                else
                {
                    rtcDescripcion.Text = "";
                }
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Seleccione una cita de la lista para actualizar.");
                return;
            }

            if (dgCita.SelectedRows.Count > 0)
            {
                var fila = dgCita.SelectedRows[0];

                Cita cita = new Cita()
                {
                    idCita = int.Parse(tbId.Text),
                    nroCaso = nroCaso,
                    fecha = Convert.ToDateTime(tbFecha.Text),
                    horaInicio = (TimeSpan)fila.Cells["horaInicio"].Value,
                    horaFin = (TimeSpan)fila.Cells["horaFin"].Value,
                    estado = cbEstado.Text,
                    observacion = rtcDescripcion.Text,
                    modalidad = fila.Cells["modalidad"].Value.ToString(),
                    confirmacionAsistencia = cbAsistencia.Text == "Si"
                };

                string mensaje = nCita.Modificar(cita);
                MessageBox.Show(mensaje);
                CargarTabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaCompleta = nCita.ListarPorCaso(nroCaso);

            if (listaCompleta != null && listaCompleta.Count > 0)
            {
                var filtrado = listaCompleta.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(tbId.Text) && int.TryParse(tbId.Text.Trim(), out int idBuscado))
                {
                    filtrado = filtrado.Where(c => c.idCita == idBuscado);
                }

                if (cbEstado.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cbEstado.Text))
                {
                    filtrado = filtrado.Where(c => c.estado.Equals(cbEstado.Text, StringComparison.OrdinalIgnoreCase));
                }

                dgCita.DataSource = null;
                dgCita.DataSource = filtrado.ToList();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            tbFecha.Clear();
            cbEstado.SelectedIndex = -1;
            cbAsistencia.SelectedIndex = -1;
            rtcDescripcion.Clear();
            CargarTabla();
        }

        private void FormEspecialistaBuscarCita_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
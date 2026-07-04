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
    public partial class FormRegistrarCitas : Form
    {
        private NCita nCita = new NCita();
        private NCliente nCliente = new NCliente();
        private NCaso nCaso = new NCaso();
        private NEspecialista nEspecialista = new NEspecialista();

        private int nroCaso;
        private String tituloCaso;
        private bool fechaAscendente = true;

        public FormRegistrarCitas(int nroCaso, String tituloCaso)
        {
            InitializeComponent();
            this.nroCaso = nroCaso;
            this.tituloCaso = tituloCaso;

            CargarDatosCaso();
            CargarTabla(nCita.ListarPorCaso(nroCaso));
        }

        private void CargarTabla(List<Cita> citas)
        {
            dgCita.DataSource = null;

            if (citas.Count > 0)
            {
                dgCita.DataSource = citas;

                if (dgCita.Columns["fecha"] != null)
                {
                    dgCita.Columns["fecha"].SortMode = DataGridViewColumnSortMode.Automatic;
                }

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

        private void LimpiarCampos()
        {
            cbModalidad.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            txtFecha.Text = "";
            rtbObservacion.Text = "";
            chkAsistencia.Checked = false;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now.AddHours(1);
            dgCita.ClearSelection();
        }

        private void dgCita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCita.SelectedRows.Count == 0)
            {
                return;
            }

            var fila = dgCita.SelectedRows[0];

            cbModalidad.Text = fila.Cells["modalidad"].Value.ToString();
            cbEstado.Text = fila.Cells["estado"].Value.ToString();
            dtpHoraInicio.Text = fila.Cells["horaInicio"].Value.ToString();
            dtpHoraFin.Text = fila.Cells["horaFin"].Value.ToString();
            chkAsistencia.Checked = Convert.ToBoolean(fila.Cells["confirmacionAsistencia"].Value);

            if (fila.Cells["observacion"].Value != null)
            {
                rtbObservacion.Text = fila.Cells["observacion"].Value.ToString();
            }
            else
            {
                rtbObservacion.Text = "";
            }

            if (fila.Cells["fecha"].Value != null)
            {
                DateTime fecha = Convert.ToDateTime(fila.Cells["fecha"].Value);

                clCitas.SelectionStart = fecha;
                txtFecha.Text = fecha.ToShortDateString();
            }
        }

        private void CargarDatosCaso()
        {
            lblTituloCaso.Text = tituloCaso;

            Caso caso = nCaso.BuscarPorNroCaso(nroCaso);

            if (caso != null)
            {
                if (caso.Cliente != null)
                {
                    lblCliente.Text = caso.Cliente.nombre + " " + caso.Cliente.apellido + " - " + caso.Cliente.dni;
                }

                Usuario especialista = nEspecialista.BuscarPorId(caso.idEspecialista);

                if (especialista != null)
                {
                    lblEspecialista.Text = especialista.nombre + " " + especialista.apellido + " - " + especialista.dni;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TimeSpan horaInicio = TimeSpan.Parse(dtpHoraInicio.Text);
            TimeSpan horaFin = TimeSpan.Parse(dtpHoraFin.Text);

            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora fin debe ser mayor que la hora inicio");
                return;
            }

            if (cbModalidad.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Cita cita = new Cita()
            {
                nroCaso = nroCaso,
                fecha = clCitas.SelectionStart,
                modalidad = cbModalidad.Text,
                horaInicio = horaInicio,
                horaFin = horaFin,
                confirmacionAsistencia = chkAsistencia.Checked,
                observacion = rtbObservacion.Text
            };

            string mensaje = nCita.Registrar(cita);
            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarPorCaso(nroCaso));
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbEstado.Text == "")
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            var lista = nCita.ListarPorCaso(nroCaso)
                .Where(c => c.estado == cbEstado.Text).ToList();

            CargarTabla(lista);
            LimpiarCampos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgCita.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }

            if (cbModalidad.Text == "" || cbEstado.Text == "" || txtFecha.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            TimeSpan horaInicio = TimeSpan.Parse(dtpHoraInicio.Text);
            TimeSpan horaFin = TimeSpan.Parse(dtpHoraFin.Text);

            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora fin debe ser mayor que la hora inicio");
                return;
            }

            var fila = dgCita.SelectedRows[0];

            Cita cita = new Cita()
            {
                idCita = int.Parse(fila.Cells["idCita"].Value.ToString()),
                nroCaso = nroCaso,
                fecha = clCitas.SelectionStart,
                estado = cbEstado.Text,
                modalidad = cbModalidad.Text,
                horaInicio = horaInicio,
                horaFin = horaFin,
                observacion = rtbObservacion.Text,
                confirmacionAsistencia = chkAsistencia.Checked
            };

            string mensaje = nCita.Modificar(cita);
            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarPorCaso(nroCaso));
            LimpiarCampos();
        }

        private void btnAgregarRecordatorio_Click(object sender, EventArgs e)
        {
            FormRecordatorio formRecordatorio = new FormRecordatorio();
            formRecordatorio.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clCitas_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = e.Start.ToShortDateString();
        }

        private void dgCita_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgCita.Columns[e.ColumnIndex].Name == "fecha")
            {
                var lista = nCita.ListarPorCaso(nroCaso);

                if (fechaAscendente)
                {
                    CargarTabla(lista.OrderBy(c => c.fecha).ToList());
                }
                else
                {
                    CargarTabla(lista.OrderByDescending(c => c.fecha).ToList());
                }

                fechaAscendente = !fechaAscendente;
            }
        }
    }
}
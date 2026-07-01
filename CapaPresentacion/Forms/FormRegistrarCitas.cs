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
        //private NCliente nCliente = new NCliente();

        private int nroCaso;
        private int idCliente;
        private String tituloCaso;
        private bool fechaAscendente = true;

        public FormRegistrarCitas(int nroCaso, int idCliente, String tituloCaso)
        {
            InitializeComponent();
            this.nroCaso = nroCaso;
            this.idCliente = idCliente;
            this.tituloCaso = tituloCaso;

            lblTituloCaso.Text = tituloCaso;
            /*var cliente = nCliente.BuscarporId(idCliente);
            if (cliente != null)
            {
                lblCliente.Text = cliente.nombre + " " + cliente.apellido;
            }*/
            CargarTabla(nCita.ListarPorCasoCliente(nroCaso, idCliente));
        }

        private void CargarTabla(List<Cita> citas)
        {
            dgCita.DataSource = null;
        
            if (citas.Count > 0)
            {
                dgCita.DataSource = citas;
                dgCita.Columns["fecha"].SortMode = DataGridViewColumnSortMode.Automatic;
                dgCita.Columns["idCita"].Visible = false;
                dgCita.Columns["nroCaso"].Visible = false;
                dgCita.Columns["idCliente"].Visible = false;
                dgCita.Columns["Caso"].Visible = false;
                dgCita.Columns["createdBy"].Visible = false;
                dgCita.Columns["createdAt"].Visible = false;
                dgCita.Columns["modifiedBy"].Visible = false;
                dgCita.Columns["modifiedAt"].Visible = false;
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

            if (fila.Cells["fecha"].Value != null)
            {
                DateTime fecha = Convert.ToDateTime(fila.Cells["fecha"].Value);

                clCitas.SelectionStart = fecha;
                txtFecha.Text = fecha.ToShortDateString();
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

            if(cbModalidad.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }



            Cita cita = new Cita()
            {
                nroCaso = nroCaso,
                idCliente = idCliente,
                fecha = clCitas.SelectionStart,
                modalidad = cbModalidad.Text,
                horaInicio = horaInicio,
                horaFin = horaFin,
                confirmacionAsistencia = chkAsistencia.Checked,
                observacion = rtbObservacion.Text
            };

            string mensaje = nCita.Registrar(cita);
            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarPorCasoCliente(nroCaso, idCliente));
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbEstado.Text == "")
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            var lista = nCita.ListarPorCasoCliente(nroCaso, idCliente)
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

            if (cbModalidad.Text == "" || cbEstado.Text == "" ||txtFecha.Text == "")
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
                idCliente = idCliente,
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

            CargarTabla(nCita.ListarPorCasoCliente(nroCaso, idCliente));
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
                var lista = nCita.ListarPorCasoCliente(nroCaso, idCliente);

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

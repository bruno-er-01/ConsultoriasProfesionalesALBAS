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

        public FormRegistrarCitas()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCita.DataSource = null;
            var lista = nCita.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCita.DataSource = lista;
            }
        }

        private void dgCita_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCita.SelectedRows.Count > 0)
            {
                var fila = dgCita.SelectedRows[0];

                txtModalidad.Text = fila.Cells["modalidad"].Value?.ToString();
                cbEstado.Text = fila.Cells["estado"].Value?.ToString();
                cbHoraInicio.Text = fila.Cells["horaInicio"].Value?.ToString();
                btnHoraFin.Text = fila.Cells["horaFin"].Value?.ToString();
                cbAsistencia.Text = fila.Cells["confirmacionAsistencia"].Value?.ToString();

                if (fila.Cells["fecha"].Value != null)
                {
                    clClientes.SelectionStart = Convert.ToDateTime(fila.Cells["fecha"].Value);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cita cita = new Cita()
            {
                nroCaso = 1,
                idCliente = 1,
                fecha = clClientes.SelectionStart,
                modalidad = txtModalidad.Text,
                estado = cbEstado.Text ?? "Pendiente",
                horaInicio = string.IsNullOrWhiteSpace(cbHoraInicio.Text) ? DateTime.Now.TimeOfDay : TimeSpan.Parse(cbHoraInicio.Text),
                horaFin = string.IsNullOrWhiteSpace(btnHoraFin.Text) ? DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(1)) : TimeSpan.Parse(btnHoraFin.Text),
                confirmacionAsistencia = cbAsistencia.Text == "Asistio" || cbAsistencia.Text == "Si"
            };

            string mensaje = (dgCita.SelectedRows.Count == 0) ? nCita.Registrar(cita) : nCita.Modificar(cita);
            MessageBox.Show(mensaje);
            CargarTabla();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var lista = nCita.ListarTodo();
            if (lista != null && cbEstado.SelectedIndex != -1)
            {
                dgCita.DataSource = lista.Where(c => c.estado == cbEstado.Text).ToList();
            }
        }
    }
}

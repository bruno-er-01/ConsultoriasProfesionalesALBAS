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

        public FormEspecialistaBuscarCita()
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

                tbId.Text = (fila.Cells["idCita"].Value ?? fila.Cells["IdCita"].Value ?? fila.Cells[0].Value)?.ToString();

                var fechaVal = fila.Cells["fecha"].Value ?? fila.Cells["Fecha"].Value;
                tbFecha.Text = fechaVal != null ? Convert.ToDateTime(fechaVal).ToShortDateString() : "";

                cbEstado.Text = (fila.Cells["estado"].Value ?? fila.Cells["Estado"].Value)?.ToString();
                cbAsistencia.Text = (fila.Cells["confirmacionAsistencia"].Value ?? fila.Cells["ConfirmacionAsistencia"].Value)?.ToString();
                rtcDescripcion.Text = (fila.Cells["observacion"].Value ?? fila.Cells["Observacion"].Value)?.ToString();
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
                    nroCaso = int.Parse(fila.Cells["nroCaso"].Value.ToString()),
                    idCliente = int.Parse(fila.Cells["idCliente"].Value.ToString()),
                    fecha = Convert.ToDateTime(tbFecha.Text),
                    horaInicio = (TimeSpan)fila.Cells["horaInicio"].Value,
                    horaFin = (TimeSpan)fila.Cells["horaFin"].Value,
                    estado = cbEstado.Text,
                    observacion = rtcDescripcion.Text,
                    modalidad = fila.Cells["modalidad"].Value?.ToString() ?? "Presencial",
                    confirmacionAsistencia = cbAsistencia.Text == "Si"
                };

                string mensaje = nCita.Modificar(cita);
                MessageBox.Show(mensaje);
                CargarTabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaCompleta = nCita.ListarTodo();
            if (listaCompleta != null && listaCompleta.Count > 0)
            {
                var filtrado = listaCompleta.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(tbId.Text) && int.TryParse(tbId.Text.Trim(), out int idBuscado))
                    filtrado = filtrado.Where(c => c.idCita == idBuscado);

                if (cbEstado.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cbEstado.Text))
                    filtrado = filtrado.Where(c => c.estado.Equals(cbEstado.Text, StringComparison.OrdinalIgnoreCase));

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

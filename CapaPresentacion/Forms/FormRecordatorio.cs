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
    public partial class FormRecordatorio : Form
    {
        private NCita nCita = new NCita();
        public FormRecordatorio()
        {
            InitializeComponent();
            List<object> citas = nCita.ListarCitasParaRecordatorio();
            CargarTabla(citas);
        }

        private void CargarTabla(List<object> citas)
        {
            dgRecordatorio.DataSource = null;

            if (citas.Count > 0)
            {
                dgRecordatorio.DataSource = citas;
                dgRecordatorio.Columns["IdCita"].Visible = false;
            }
        }

        private void LimpiarCampos()
        {
            txtDNICliente.Text = "";
            txtDNIEspecialista.Text = "";
            lblFechaCita.Text = "";
            lblHoraInicio.Text = "";
            lblModalidad.Text = "";
            cbTiempoAnticipacion.SelectedIndex = -1;
            dgRecordatorio.ClearSelection();
        }

        private void dgRecordatorio_SelectionChanged(object sender, EventArgs e)
        {
            if (dgRecordatorio.SelectedRows.Count == 0)
            {
                return;
            }

            var fila = dgRecordatorio.SelectedRows[0];
            txtDNICliente.Text = fila.Cells["DNICliente"].Value.ToString();
            txtDNIEspecialista.Text = fila.Cells["DNIEspecialista"].Value.ToString();
            lblHoraInicio.Text = fila.Cells["HoraInicio"].Value.ToString();
            lblFechaCita.Text = Convert.ToDateTime(fila.Cells["Fecha"].Value).ToString("dd/MM/yyyy");
            lblModalidad.Text = fila.Cells["Modalidad"].Value.ToString();

            if (fila.Cells["TiempoAnticipacion"].Value == null)
            {
                cbTiempoAnticipacion.Text = "";
            }
            else
            {
                cbTiempoAnticipacion.Text = fila.Cells["TiempoAnticipacion"].Value.ToString() + " minutos";
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dgRecordatorio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita");
                return;
            }

            if (cbTiempoAnticipacion.Text == "")
            {
                MessageBox.Show("Seleccione el tiempo de anticipación");
                return;
            }

            var fila = dgRecordatorio.SelectedRows[0];

            if (fila.Cells["TiempoAnticipacion"].Value != null)
            {
                MessageBox.Show("La cita ya tiene un recordatorio");
                return;
            }

            int idCita = int.Parse(fila.Cells["IdCita"].Value.ToString());
            int tiempoAnticipacion = 0;

            if (cbTiempoAnticipacion.Text == "5 minutos")
            {
                tiempoAnticipacion = 5;
            }
            else if (cbTiempoAnticipacion.Text == "10 minutos")
            {
                tiempoAnticipacion = 10;
            }
            else if (cbTiempoAnticipacion.Text == "15 minutos")
            {
                tiempoAnticipacion = 15;
            }
            else if (cbTiempoAnticipacion.Text == "20 minutos")
            {
                tiempoAnticipacion = 20;
            }
            else if (cbTiempoAnticipacion.Text == "25 minutos")
            {
                tiempoAnticipacion = 25;
            }
            else if (cbTiempoAnticipacion.Text == "30 minutos")
            {
                tiempoAnticipacion = 30;
            }
            else if (cbTiempoAnticipacion.Text == "60 minutos")
            {
                tiempoAnticipacion = 60;
            }

            if (tiempoAnticipacion == 0)
            {
                MessageBox.Show("El tiempo seleccionado no es válido");
                return;
            }

            string mensaje = nCita.AgregarRecordatorio(
                idCita,
                tiempoAnticipacion
            );

            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarCitasParaRecordatorio());
            LimpiarCampos();
        }

        private void btnModificarRecordatorio_Click(object sender, EventArgs e)
        {
            if (dgRecordatorio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita");
                return;
            }

            if (cbTiempoAnticipacion.Text == "")
            {
                MessageBox.Show("Seleccione el nuevo tiempo de anticipación");
                return;
            }

            var fila = dgRecordatorio.SelectedRows[0];

            if (fila.Cells["TiempoAnticipacion"].Value == null || fila.Cells["TiempoAnticipacion"].Value.ToString() == "")
            {
                MessageBox.Show("La cita todavía no tiene un recordatorio");
                return;
            }

            int idCita = int.Parse(fila.Cells["IdCita"].Value.ToString());

            int tiempoAnticipacion = 0;

            if (cbTiempoAnticipacion.Text == "5 minutos")
            {
                tiempoAnticipacion = 5;
            }
            else if (cbTiempoAnticipacion.Text == "10 minutos")
            {
                tiempoAnticipacion = 10;
            }
            else if (cbTiempoAnticipacion.Text == "15 minutos")
            {
                tiempoAnticipacion = 15;
            }
            else if (cbTiempoAnticipacion.Text == "20 minutos")
            {
                tiempoAnticipacion = 20;
            }
            else if (cbTiempoAnticipacion.Text == "25 minutos")
            {
                tiempoAnticipacion = 25;
            }
            else if (cbTiempoAnticipacion.Text == "30 minutos")
            {
                tiempoAnticipacion = 30;
            }
            else if (cbTiempoAnticipacion.Text == "60 minutos")
            {
                tiempoAnticipacion = 60;
            }

            if (tiempoAnticipacion == 0)
            {
                MessageBox.Show("El tiempo seleccionado no es válido");
                return;
            }

            string mensaje = nCita.ModificarRecordatorio(
                idCita,
                tiempoAnticipacion
            );

            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarCitasParaRecordatorio());
            LimpiarCampos();
        }

        private void btnCancelarRecordatorio_Click(object sender, EventArgs e)
        {
            if (dgRecordatorio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cita");
                return;
            }

            var fila = dgRecordatorio.SelectedRows[0];

            if (fila.Cells["TiempoAnticipacion"].Value == null || fila.Cells["TiempoAnticipacion"].Value.ToString() == "")
            {
                MessageBox.Show("La cita no tiene un recordatorio");
                return;
            }

            int idCita = int.Parse(fila.Cells["IdCita"].Value.ToString());
            string mensaje = nCita.CancelarRecordatorio(idCita);
            MessageBox.Show(mensaje);

            CargarTabla(nCita.ListarCitasParaRecordatorio());
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text == "" && txtDNIEspecialista.Text == "")
            {
                MessageBox.Show("Ingrese el DNI del cliente o del especialista");
                return;
            }

            List<object> citas = nCita.BuscarCitasParaRecordatorio(txtDNICliente.Text, txtDNIEspecialista.Text);

            if (citas.Count == 0)
            {
                MessageBox.Show("No se encontraron próximas citas");
                CargarTabla(citas);
                return;
            }
            CargarTabla(citas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarTabla(nCita.ListarCitasParaRecordatorio());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

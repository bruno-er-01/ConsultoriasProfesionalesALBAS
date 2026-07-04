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
    public partial class FormRegistrarCaso : Form
    {
        private NCaso nCaso = new NCaso();
        private int idClienteAsociado = 1;

        public FormRegistrarCaso()
        {
            InitializeComponent();
            CargarTabla();
        }

        public FormRegistrarCaso(int idCliente)
        {
            InitializeComponent();
            this.idClienteAsociado = idCliente;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgCaso.DataSource = null;
            var lista = nCaso.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgCaso.DataSource = lista;
            }
        }

        private void dgCaso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count > 0)
            {
                var fila = dgCaso.SelectedRows[0];
                txtNombre.Text = fila.Cells["titulo"].Value?.ToString();
                cbEstado.Text = fila.Cells["estado"].Value?.ToString();
                cbFechaInicio.Text = Convert.ToDateTime(fila.Cells["fechaHoraInicio"].Value).ToShortDateString();
                var fechaFinVal = fila.Cells["fechaHoraFin"].Value ?? fila.Cells["FechaHoraFin"].Value;
                btnFechaFin.Text = (fechaFinVal != null && fechaFinVal != DBNull.Value)
                    ? Convert.ToDateTime(fechaFinVal).ToShortDateString()
                    : "Seleccionar Fin";
                richTextBox1.Text = fila.Cells["descripcion"].Value?.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El título del caso es obligatorio.");
                return;
            }

            bool esNuevo = dgCaso.SelectedRows.Count == 0;

            Caso caso = new Caso()
            {
                nroCaso = esNuevo ? 0 : int.Parse(dgCaso.SelectedRows[0].Cells["nroCaso"].Value.ToString()),
                idCliente = idClienteAsociado,

                idAdministrador = 1,
                idEspecialista = 3,

                titulo = txtNombre.Text.Trim(),
                estado = esNuevo ? "Abierto" : cbEstado.Text,
                fechaHoraInicio = string.IsNullOrWhiteSpace(cbFechaInicio.Text) ? DateTime.Now : Convert.ToDateTime(cbFechaInicio.Text),
                fechaHoraFin = string.IsNullOrWhiteSpace(btnFechaFin.Text) || btnFechaFin.Text == "Seleccionar Fin"
                                ? (DateTime?)null
                                : Convert.ToDateTime(btnFechaFin.Text),
                descripcion = richTextBox1.Text.Trim()
            };

            string mensaje = esNuevo ? nCaso.Registrar(caso) : nCaso.Modificar(caso);
            MessageBox.Show(mensaje);

            CargarTabla();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tBuscado = txtNombre.Text.Trim();
            var lista = nCaso.ListarTodo();
            if (lista != null && !string.IsNullOrWhiteSpace(tBuscado))
            {
                dgCaso.DataSource = lista.Where(c => c.titulo != null && c.titulo.IndexOf(tBuscado, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
        }

        private void FormRegistrarCaso_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            if (dgCaso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un caso.");
                return;
            }

            var fila = dgCaso.SelectedRows[0];

            int nroCaso = int.Parse(fila.Cells["nroCaso"].Value.ToString());
            int idCliente = int.Parse(fila.Cells["idCliente"].Value.ToString());
            string tituloCaso = fila.Cells["titulo"].Value.ToString();

            FormRegistrarCitas formRegistrarCitas = new FormRegistrarCitas(nroCaso, idCliente, tituloCaso);
            formRegistrarCitas.Show();
        }
    }
}

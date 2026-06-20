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
    public partial class FormEspecialistaBuscarCliente : Form
    {
        private NCliente nCliente = new NCliente();

        public FormEspecialistaBuscarCliente()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgClientes.DataSource = null;
            var lista = nCliente.ListarTodo();
            if (lista != null && lista.Count > 0)
            {
                dgClientes.DataSource = lista;
            }
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                var fila = dgClientes.SelectedRows[0];
                txtDNI.Text = fila.Cells["dni"].Value?.ToString();
            }
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                var fila = dgClientes.SelectedRows[0];
                int idCliente = int.Parse(fila.Cells["idCliente"].Value.ToString());

                FormEspecialistaBuscarCaso frmCaso = new FormEspecialistaBuscarCaso();
                frmCaso.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para consultar sus casos activos.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            CargarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniBuscado = txtDNI.Text.Trim();
            if (string.IsNullOrWhiteSpace(dniBuscado))
            {
                MessageBox.Show("Ingrese un número de DNI para realizar la búsqueda.");
                return;
            }

            var listaCompleta = nCliente.ListarTodo();
            if (listaCompleta != null && listaCompleta.Count > 0)
            {
                dgClientes.DataSource = null;
                dgClientes.DataSource = listaCompleta.Where(c => c.dni != null && c.dni.Contains(dniBuscado)).ToList();
            }
        }

        private void FormEspecialistaBuscarCliente_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}

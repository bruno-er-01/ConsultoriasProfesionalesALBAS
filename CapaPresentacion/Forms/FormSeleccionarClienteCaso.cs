using System;
using CapaDatos;
using CapaNegocios;
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
    public partial class FormSeleccionarClienteCaso : Form
    {
        private NCliente nCliente = new NCliente();
        private int idAdminLogueado;

        public FormSeleccionarClienteCaso(int idAdminSession)
        {
            InitializeComponent();
            idAdminLogueado = idAdminSession;
            CargarTablaClientes();
        }

        private void CargarTablaClientes()
        {
            List<Cliente> clientes = nCliente.ListarTodoActivos();
            MostrarData(clientes);
        }

        private void MostrarData(List<Cliente> clientes)
        {
            dgClientesCasos.DataSource = null;

            if (clientes.Count > 0)
            {
                dgClientesCasos.DataSource = clientes
                    .Select(c => new
                    {
                        idCliente = c.idCliente,
                        nombre = c.nombre,
                        apellido = c.apellido,
                        dni = c.dni,
                        correo = c.correo,
                        telefono = c.telefono,
                        direccion = c.direccion,
                        genero = c.genero,
                        activo = c.activo,
                        createdBy = c.createdBy,
                        createdAt = c.createdAt,
                        modifiedBy = c.modifiedBy,
                        modifiedAt = c.modifiedAt
                    })
                    .ToList();
            }
            else
            {
                return;
            }

            dgClientesCasos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgClientesCasos.Columns["idCliente"].Visible = false;
            dgClientesCasos.Columns["activo"].Visible = false;
            dgClientesCasos.Columns["createdBy"].Visible = false;
            dgClientesCasos.Columns["createdAt"].Visible = false;
            dgClientesCasos.Columns["modifiedBy"].Visible = false;
            dgClientesCasos.Columns["modifiedAt"].Visible = false;
        }

        private void btnListarTodoClientes_Click(object sender, EventArgs e)
        {
            tbDNI.Text = "";
            tbNombre.Text = "";
            CargarTablaClientes();
        }

        private void btnRegistrarCaso_Click(object sender, EventArgs e)
        {
            if (dgClientesCasos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dgClientesCasos.SelectedRows[0];
            int idClienteSeleccionado = Convert.ToInt32(fila.Cells["idCliente"].Value);

            FormRegistrarCaso formularioCasos = new FormRegistrarCaso(idClienteSeleccionado, idAdminLogueado);
            formularioCasos.Show();
        }

        private void dgClientesCasos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgClientesCasos.SelectedRows.Count > 0)
            {
                var fila = dgClientesCasos.SelectedRows[0];

                tbNombre.Text = fila.Cells["nombre"].Value?.ToString();
                tbApellido.Text = fila.Cells["apellido"].Value?.ToString();
                tbDNI.Text = fila.Cells["dni"].Value?.ToString();
                tbCorreo.Text = fila.Cells["correo"].Value?.ToString();
                tbTelefono.Text = fila.Cells["telefono"].Value?.ToString();
                tbDireccion.Text = fila.Cells["direccion"].Value?.ToString();

                cbGenero.Text = fila.Cells["genero"].Value?.ToString();
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            MostrarData(nCliente.ListarClientesPorTexto(txtBuscarCliente.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDNI.Text = "";
            cbGenero.SelectedIndex = -1;
            tbDireccion.Text = "";
            tbCorreo.Text = "";
            tbTelefono.Text = "";
        }
    }
}
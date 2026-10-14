using CapaDatos;
using CapaNegocios;
using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRegistrarBuscarClientes : Form
    {
        private NCliente nCliente = new NCliente();
        private Usuario usuarioactual = new Usuario();

        public FormRegistrarBuscarClientes(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioactual = usuario;
            dgClientes.CurrentCellDirtyStateChanged += dgClientes_CurrentCellDirtyStateChanged;
            dgClientes.CellValueChanged += dgClientes_CellValueChanged;
        }

        private void MostrarDataGrid(List<Cliente> lista)
        {
            dgClientes.DataSource = null;

            if (lista.Count > 0)
            {
                dgClientes.DataSource = lista
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

                dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgClientes.Columns["idCliente"].Visible = false;
                dgClientes.Columns["createdBy"].Visible = false;
                dgClientes.Columns["createdAt"].Visible = false;
                dgClientes.Columns["modifiedBy"].Visible = false;
                dgClientes.Columns["modifiedAt"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbApellido.Text == "" || tbNombre.Text == "" || tbCorreo.Text == "" || tbDireccion.Text == "" || tbDNI.Text == ""
                || tbTelefono.Text == "" || cbGenero.Text == "")
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            Cliente cliente = new Cliente()
            {
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                genero = cbGenero.Text,
                correo = tbCorreo.Text,
                direccion = tbDireccion.Text,
                dni = tbDNI.Text,
                telefono = tbTelefono.Text,
                createdBy = usuarioactual.idUsuario,
                createdAt = DateTime.Now
            };

            String mesaje = nCliente.Registrar(cliente);
            MessageBox.Show(mesaje);
            MostrarDataGrid(nCliente.ListarTodo());
        }


        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            int idcliente = int.Parse(dgClientes.CurrentRow.Cells["idCliente"].Value.ToString());

            if (tbApellido.Text == "" || tbNombre.Text == "" || tbCorreo.Text == "" || tbDireccion.Text == "" || tbDNI.Text == ""
                || tbTelefono.Text == "" || cbGenero.Text == "")
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            Cliente cliente = new Cliente()
            {
                idCliente = idcliente,
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                genero = cbGenero.Text,
                correo = tbCorreo.Text,
                direccion = tbDireccion.Text,
                dni = tbDNI.Text,
                telefono = tbTelefono.Text,
                modifiedBy = usuarioactual.idUsuario,
                modifiedAt = DateTime.Now
            };

            string mesaje = nCliente.Modificar(cliente);
            MessageBox.Show(mesaje);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            int idcliente = int.Parse(dgClientes.CurrentRow.Cells["idCliente"].Value.ToString());
            string mesaje = nCliente.EliminarLogico(idcliente);
            MessageBox.Show(mesaje);
            MostrarDataGrid(nCliente.ListarTodo());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(nCliente.ListarTodoActivos());
        }

        private void btnListarTodoClientes_Click(object sender, EventArgs e)
        {
            MostrarDataGrid(nCliente.ListarTodo());
        }

        private void dgClientes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgClientes.IsCurrentCellDirty)
            {
                dgClientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgClientes.Columns[e.ColumnIndex].Name == "activo")
            {
                int idCliente = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["idCliente"].Value);
                bool activo = Convert.ToBoolean(dgClientes.Rows[e.RowIndex].Cells["activo"].Value);

                string mensaje = nCliente.ActualizarActivo(idCliente, activo, usuarioactual.idUsuario);
                MessageBox.Show(mensaje);
            }
        }

        private void dgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow == null) return;

            int idcliente = int.Parse(dgClientes.CurrentRow.Cells["idCliente"].Value.ToString());
            Cliente cliente = nCliente.EncontrarCliente(idcliente);

            if (cliente == null) return;

            tbApellido.Text = cliente.apellido;
            tbCorreo.Text = cliente.correo;
            tbNombre.Text = cliente.nombre;
            tbDNI.Text = cliente.dni;
            tbTelefono.Text = cliente.telefono;
            cbGenero.Text = cliente.genero;
            tbDireccion.Text = cliente.direccion;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (*.csv)|*.csv";
            save.FileName = "Clientes.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewColumn columna in dgClientes.Columns)
                {
                    if (columna.Visible)
                    {
                        sb.Append(columna.HeaderText + ";");
                    }
                }

                sb.AppendLine();

                foreach (DataGridViewRow fila in dgClientes.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            if (dgClientes.Columns[celda.ColumnIndex].Visible)
                            {
                                sb.Append((celda.Value != null ? celda.Value.ToString() : "") + ";");
                            }
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Clientes exportados correctamente");
            }
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

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            MostrarDataGrid(nCliente.ListarClientesPorTexto(txtBuscarCliente.Text));
        }
    }
}
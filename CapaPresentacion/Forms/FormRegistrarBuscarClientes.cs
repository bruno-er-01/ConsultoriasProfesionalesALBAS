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
using Excel = Microsoft.Office.Interop.Excel;

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
            if (lista.Count > 0) {
                dgClientes.DataSource = lista;
                dgClientes.Columns["idcliente"].Visible = false;

                if(dgClientes.Columns["caso"] != null)
                dgClientes.Columns["caso"].Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = tbDNI.Text;
            if(dni == null)
            {
                MessageBox.Show("Completar el campo dni");
                return;
            }
            
            Cliente cliente = nCliente.EncontrarClienteDNI(dni);
            List<Cliente> clienteencontrado = new List<Cliente>();
            clienteencontrado.Add(cliente);
            MostrarDataGrid(clienteencontrado);
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            int idcliente = int.Parse(dgClientes.CurrentRow.Cells[0].Value.ToString());

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
            int idcliente = int.Parse(dgClientes.CurrentRow.Cells[0].Value.ToString());
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

        //metodos para el datagrid
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

            int idcliente = int.Parse(dgClientes.CurrentRow.Cells[0].Value.ToString());
            Cliente cliente = nCliente.EncontrarCliente(idcliente);

            if (cliente == null) return;
            //Completamos los campos
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
        
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            guardar.FileName = "Clientes.xlsx";
        
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook libro = excel.Workbooks.Add();
                Excel.Worksheet hoja = libro.ActiveSheet;
        
                int columnaExcel = 1;
        
                // Encabezados
                for (int i = 0; i < dgClientes.Columns.Count; i++)
                {
                    if (dgClientes.Columns[i].Visible)
                    {
                        hoja.Cells[1, columnaExcel] = dgClientes.Columns[i].HeaderText;
                        columnaExcel++;
                    }
                }
       
                // Datos
                for (int i = 0; i < dgClientes.Rows.Count; i++)
                {
                    if (dgClientes.Rows[i].IsNewRow) continue;
        
                    columnaExcel = 1;
        
                    for (int j = 0; j < dgClientes.Columns.Count; j++)
                    {
                        if (dgClientes.Columns[j].Visible)
                        {
                            object valor = dgClientes.Rows[i].Cells[j].Value;
                            hoja.Cells[i + 2, columnaExcel] = valor == null ? "" : valor.ToString();
                            columnaExcel++;
                        }
                    }
                }
        
                hoja.Columns.AutoFit();
        
                libro.SaveAs(guardar.FileName);
                libro.Close();
                excel.Quit();
        
                MessageBox.Show("Excel de clientes exportado correctamente");
            }
        }
    }     
}

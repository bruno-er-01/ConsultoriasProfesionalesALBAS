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
    public partial class FormRegistrarAdministrador : Form
    {
        private Usuario usuarioActual;
        private NUsuario nusuario = new NUsuario();

        public FormRegistrarAdministrador(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            dgUsuarios.CurrentCellDirtyStateChanged += dgUsuarios_CurrentCellDirtyStateChanged;
            dgUsuarios.CellValueChanged += dgUsuarios_CellValueChanged;
        }

        void MostrarDatagrid(List<Usuario> lista)
        {
            dgUsuarios.DataSource = null;
            if(lista.Count > 0)
            {
                dgUsuarios.DataSource = lista;

                if (dgUsuarios.Columns["Administrador"] != null)
                    dgUsuarios.Columns["Administrador"].Visible = false;

                if (dgUsuarios.Columns["Especialista"] != null)
                    dgUsuarios.Columns["Especialista"].Visible = false;

                if (dgUsuarios.Columns["idUsuario"] != null)
                    dgUsuarios.Columns["idUsuario"].Visible = false;

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbCorreo.Text == "" || tbUsername.Text == "" || tbContrasena.Text == ""
                || tbNombre.Text == "" || tbApellido.Text == "" || tbDNI.Text == "" 
                || tbTelefono.Text == "" || tbDireccion.Text == "")

            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            Usuario usuario = new Usuario()
            {
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                dni = tbDNI.Text,
                telefono = tbTelefono.Text,
                correo = tbCorreo.Text,
                username = tbUsername.Text,
                password = tbContrasena.Text,
                direccion = tbDireccion.Text,
                createdBy = usuarioActual.idUsuario,
                createdAt = DateTime.Now
            };

            string mensaje = nusuario.RegistrarAdministrador(usuario);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarAdministradores());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string dni = tbDNI.Text;
            string correo = tbCorreo.Text;

            Usuario usuarioEncontrado = null;

            if (username != "")
            {
                usuarioEncontrado = nusuario.BuscarPorUsername(username);
            }
            else if (dni != "")
            {
                usuarioEncontrado = nusuario.BuscarPorDni(dni);
            }
            else if (correo != "")
            {
                usuarioEncontrado = nusuario.BuscarPorCorreo(correo);
            }
            else
            {
                MessageBox.Show("Ingrese username, DNI o correo para buscar.");
                return;
            }

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("No se encontró ningún usuario.");
                return;
            }

            tbNombre.Text = usuarioEncontrado.nombre;
            tbApellido.Text = usuarioEncontrado.apellido;
            tbDNI.Text = usuarioEncontrado.dni;
            tbTelefono.Text = usuarioEncontrado.telefono;
            tbCorreo.Text = usuarioEncontrado.correo;
            tbUsername.Text = usuarioEncontrado.username;
            tbContrasena.Text = usuarioEncontrado.password;
            tbDireccion.Text = usuarioEncontrado.direccion;

            List<Usuario> lista = new List<Usuario>();
            lista.Add(usuarioEncontrado);
            MostrarDatagrid(lista);

            MessageBox.Show("Usuario encontrado.");
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            if (tbCorreo.Text == "" || tbUsername.Text == "" || tbContrasena.Text == ""
                || tbNombre.Text == "" || tbApellido.Text == "" || tbDNI.Text == ""
                || tbTelefono.Text == "" || tbDireccion.Text == "")

            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            int idusuario = int.Parse(dgUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString());

            Usuario usuario = new Usuario()
            {
                idUsuario = idusuario,
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                dni = tbDNI.Text,
                telefono = tbTelefono.Text,
                correo = tbCorreo.Text,
                username = tbUsername.Text,
                password = tbContrasena.Text,
                direccion = tbDireccion.Text,
                modifiedBy = usuarioActual.idUsuario,
                modifiedAt = DateTime.Now
            };

            string mensaje = nusuario.Modificar(usuario);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarAdministradores());
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0) {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var fila = dgUsuarios.SelectedRows[0];
            var usuarioId = int.Parse(fila.Cells["idUsuario"].Value.ToString());

            string mensaje = nusuario.EliminarLogico(usuarioId, usuarioActual.idUsuario);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarAdministradores());
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarTodoadministradores());
        }

        private void btnListarActivos_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarAdministradores());
        }

        private void dgUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.IsCurrentCellDirty)
            {
                dgUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgUsuarios.Columns[e.ColumnIndex].Name == "activo")
            {
                int idUsuario = Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value);
                bool activo = Convert.ToBoolean(dgUsuarios.Rows[e.RowIndex].Cells["activo"].Value);

                string mensaje = nusuario.ActualizarActivo(idUsuario, activo, usuarioActual.idUsuario);
                MessageBox.Show(mensaje);
            }
        }
        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null) return;

            Usuario usuario = dgUsuarios.CurrentRow.DataBoundItem as Usuario;

            //Permite la lista vacíá
            if (usuario == null) return;

            tbNombre.Text = usuario.nombre;
            tbApellido.Text = usuario.apellido;
            tbDNI.Text = usuario.dni;
            tbTelefono.Text = usuario.telefono;
            tbCorreo.Text = usuario.correo;
            tbUsername.Text = usuario.username;
            tbContrasena.Text = usuario.password;
            tbDireccion.Text = usuario.direccion;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Administradores.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook libro = excel.Workbooks.Add();
                Excel.Worksheet hoja = libro.ActiveSheet;

                int columnaExcel = 1;

                // Encabezados
                for (int i = 0; i < dgUsuarios.Columns.Count; i++)
                {
                    if (dgUsuarios.Columns[i].Visible)
                    {
                        hoja.Cells[1, columnaExcel] = dgUsuarios.Columns[i].HeaderText;
                        columnaExcel++;
                    }
                }

                // Datos
                for (int i = 0; i < dgUsuarios.Rows.Count; i++)
                {
                    columnaExcel = 1;

                    for (int j = 0; j < dgUsuarios.Columns.Count; j++)
                    {
                        if (dgUsuarios.Columns[j].Visible)
                        {
                            object valor = dgUsuarios.Rows[i].Cells[j].Value;

                            hoja.Cells[i + 2, columnaExcel] = valor != null ? valor.ToString() : "";
                            columnaExcel++;
                        }
                    }
                }

                hoja.Columns.AutoFit();

                libro.SaveAs(saveFileDialog.FileName);
                libro.Close();
                excel.Quit();

                MessageBox.Show("Excel exportado correctamente");
            }
        }
    }
}

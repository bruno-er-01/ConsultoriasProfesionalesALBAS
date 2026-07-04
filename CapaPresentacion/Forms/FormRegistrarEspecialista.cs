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
    public partial class FormRegistrarEspecialista : Form
    {
        private Usuario usuarioActual;
        private NUsuario nusuario = new NUsuario();
        private NArea nArea = new NArea();

        public FormRegistrarEspecialista(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            MostrarComboAreaAtencion(nArea.ListarTodo());
        }

        void MostrarComboAreaAtencion(List<Area> lista)
        {
            cbAreaAtencion.DataSource = null;
            if(lista.Count > 0)
            {
                cbAreaAtencion.DataSource = lista;
                cbAreaAtencion.ValueMember = "idArea";
                cbAreaAtencion.DisplayMember = "nombre";
            }
        }

        void MostrarDatagrid(Object lista)
        {
            dgUsuarios.DataSource = null;
            if (lista != null)
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
            if (tbCorreo.Text == "" || tbUsername.Text == "" || tbContrasena.Text == ""
                || tbNombre.Text == "" || tbApellido.Text == "" || tbDNI.Text == ""
                || tbTelefono.Text == "" || tbDireccion.Text == "" || cbAreaAtencion.Text == "")

            {
                MessageBox.Show("Completar todos los campos");
                return;
            }
            
            int idArea = int.Parse(cbAreaAtencion.SelectedValue.ToString());
            bool disponible = false;

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

            string mensaje = nusuario.RegistrarEspecialista(usuario, idArea, disponible);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarEspecialistasConDatosActivos());
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
                MessageBox.Show("Seleccione un Especialista");
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
            MostrarDatagrid(nusuario.ListarEspecialistasConDatosActivos());
        }

        private void btnListarActivo_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarEspecialistasConDatosActivos());
        }

        private void btnListarTodoEspecialista_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarTodoEspecialistas());
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var fila = dgUsuarios.SelectedRows[0];
            var usuarioId = int.Parse(fila.Cells["idUsuario"].Value.ToString());

            string mensaje = nusuario.EliminarLogico(usuarioId, usuarioActual.idUsuario);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarEspecialistasConDatosActivos());
        }

        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
            if (dgUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            guardar.FileName = "Especialistas.xlsx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook libro = excel.Workbooks.Add();
                Excel.Worksheet hoja = libro.ActiveSheet;

                int columnaExcel = 1;

                //Encabezados
                for (int i = 0; i < dgUsuarios.Columns.Count; i++)
                {
                    if (dgUsuarios.Columns[i].Visible)
                    {
                        hoja.Cells[1, columnaExcel] = dgUsuarios.Columns[i].HeaderText;
                        columnaExcel++;
                    }
                }

                //Datos
                for (int i = 0; i < dgUsuarios.Rows.Count; i++)
                {
                    if (dgUsuarios.Rows[i].IsNewRow) continue;

                    columnaExcel = 1;

                    for (int j = 0; j < dgUsuarios.Columns.Count; j++)
                    {
                        if (dgUsuarios.Columns[j].Visible)
                        {
                            object valor = dgUsuarios.Rows[i].Cells[j].Value;
                            hoja.Cells[i + 2, columnaExcel] = valor == null ? "" : valor.ToString();
                            columnaExcel++;
                        }
                    }
                }

                hoja.Columns.AutoFit();

                libro.SaveAs(guardar.FileName);
                libro.Close();
                excel.Quit();

                MessageBox.Show("Excel exportado correctamente");
            }
        }
    }
}

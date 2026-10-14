using CapaDatos;
using CapaNegocios;
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
    public partial class FormRegistrarAdministrador : Form
    {
        private Usuario usuarioActual;
        private NUsuario nusuario = new NUsuario();

        public FormRegistrarAdministrador(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            dgUsuarios.CurrentCellDirtyStateChanged += dgUsuarios_CurrentCellDirtyStateChanged;

        }

        void MostrarDatagrid(List<Usuario> lista)
        {
            dgUsuarios.DataSource = null;
            if (lista.Count > 0)
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
            if (dgUsuarios.SelectedRows.Count == 0)
            {
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

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (*.csv)|*.csv";
            save.FileName = "Administradores.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewColumn columna in dgUsuarios.Columns)
                {
                    if (columna.Visible)
                    {
                        sb.Append(columna.HeaderText + ";");
                    }
                }

                sb.AppendLine();

                foreach (DataGridViewRow fila in dgUsuarios.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            if (dgUsuarios.Columns[celda.ColumnIndex].Visible)
                            {
                                sb.Append((celda.Value != null ? celda.Value.ToString() : "") + ";");
                            }
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Archivo exportado correctamente");
            }
        }

        private void txtBuscarAdmin_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarAdmin.Text.Trim().ToLower();

            List<Usuario> lista = nusuario.ListarAdministradores();

            if (texto != "")
            {
                lista = lista.Where(u =>
                    (u.nombre != null && u.nombre.ToLower().Contains(texto)) ||
                    (u.apellido != null && u.apellido.ToLower().Contains(texto)) ||
                    (u.dni != null && u.dni.ToLower().Contains(texto)) ||
                    (u.username != null && u.username.ToLower().Contains(texto)) ||
                    (u.correo != null && u.correo.ToLower().Contains(texto)) ||
                    (u.telefono != null && u.telefono.ToLower().Contains(texto))
                ).ToList();
            }

            MostrarDatagrid(lista);
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            tbCorreo.Text = "";
            tbApellido.Text = "";
            tbUsername.Text = "";
            tbContrasena.Text = "";
            tbNombre.Text = "";
            tbDNI.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            txtBuscarAdmin.Text = "";
        }
    }
}
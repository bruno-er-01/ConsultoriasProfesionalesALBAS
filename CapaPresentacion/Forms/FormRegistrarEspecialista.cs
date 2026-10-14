using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormRegistrarEspecialista : Form
    {
        private Usuario usuarioActual;
        private NUsuario nusuario = new NUsuario();
        private NEspecialista nespecialista = new NEspecialista();
        private NArea nArea = new NArea();

        public FormRegistrarEspecialista(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            MostrarComboAreaAtencion(nArea.ListarTodo());
            MostrarDatagrid(nusuario.ListarEspecialistasConDatosActivos());
        }

        void MostrarComboAreaAtencion(List<Area> lista)
        {
            cbAreaAtencion.DataSource = null;
            if (lista.Count > 0)
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

        private void btnListarDisponibles_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarEspecialistasDisponibles());
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

        private void btnCambiardisponibilidad_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var fila = dgUsuarios.SelectedRows[0];
            var usuarioId = int.Parse(fila.Cells["idUsuario"].Value.ToString());

            string mensaje = nespecialista.CambiarDisponibilidad(usuarioId);
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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "Administradores.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Encabezados
                for (int i = 0; i < dgUsuarios.Columns.Count; i++)
                {
                    if (dgUsuarios.Columns[i].Visible)
                    {
                        sb.Append(dgUsuarios.Columns[i].HeaderText);
                        sb.Append(";");
                    }
                }

                sb.AppendLine();

                // Datos
                foreach (DataGridViewRow fila in dgUsuarios.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int j = 0; j < dgUsuarios.Columns.Count; j++)
                        {
                            if (dgUsuarios.Columns[j].Visible)
                            {
                                object valor = fila.Cells[j].Value;
                                sb.Append(valor != null ? valor.ToString() : "");
                                sb.Append(";");
                            }
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Archivo exportado correctamente");
            }
        }

        private void txtBuscarEspecialista_TextChanged(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarEspecialistasPorTexto(txtBuscarEspecialista.Text));
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null) return;

            DataGridViewRow fila = dgUsuarios.CurrentRow;

            tbNombre.Text = fila.Cells["nombre"].Value?.ToString();
            tbApellido.Text = fila.Cells["apellido"].Value?.ToString();
            tbDNI.Text = fila.Cells["dni"].Value?.ToString();
            tbTelefono.Text = fila.Cells["telefono"].Value?.ToString();
            tbCorreo.Text = fila.Cells["correo"].Value?.ToString();
            tbUsername.Text = fila.Cells["username"].Value?.ToString();
            tbContrasena.Text = fila.Cells["password"].Value?.ToString();
            tbDireccion.Text = fila.Cells["direccion"].Value?.ToString();
            cbAreaAtencion.Text = fila.Cells["areaAtencion"].Value?.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbCorreo.Text = "";
            tbUsername.Text = "";
            tbContrasena.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbDNI.Text = "";
            tbDireccion.Text = "";
            tbTelefono.Text = "";
            txtBuscarEspecialista.Text = "";
            cbAreaAtencion.SelectedIndex = -1;
            dgUsuarios.ClearSelection(); 
        }
    }
}
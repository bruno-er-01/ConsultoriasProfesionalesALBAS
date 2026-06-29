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

                if (dgUsuarios.Columns["activo"] != null)
                    dgUsuarios.Columns["activo"].Visible = false;

                if (dgUsuarios.Columns["Administrador"] != null)
                    dgUsuarios.Columns["Administrador"].Visible = false;

                if (dgUsuarios.Columns["Especialista"] != null)
                    dgUsuarios.Columns["Especialista"].Visible = false;
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
                createdBy = usuarioActual.idUsuario
            };

            string mensaje = nusuario.RegistrarEspecialista(usuario, idArea, disponible);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarEspecialistas());
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
                modifiedBy = usuarioActual.idUsuario
            };

            string mensaje = nusuario.Modificar(usuario);
            MessageBox.Show(mensaje);
            MostrarDatagrid(nusuario.ListarEspecialistasConDatos());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDatagrid(nusuario.ListarEspecialistasConDatos());
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
            MostrarDatagrid(nusuario.ListarEspecialistasConDatos());
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null) { return;}

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


            if (dgUsuarios.Columns["idArea"] != null)
            {
                cbAreaAtencion.SelectedValue = Convert.ToInt32(
                    dgUsuarios.CurrentRow.Cells["idArea"].Value
                );
                //cambios

            }
        }
    }
}

using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        private DAdministrador dAdministrador = new DAdministrador();
        private DEspecialista dEspecialista = new DEspecialista();

        public string RegistrarAdministrador(Usuario usuario)
        {
            if (dUsuario.ExisteDni(usuario.dni))
            {
                return "El DNI ya está registrado.";
            }

            if (dUsuario.ExisteUsername(usuario.username))
            {
                return "El nombre de usuario ya está registrado.";
            }

            usuario.rol = "Administrador";

            int idUsuario = dUsuario.Registrar(usuario);

            if (idUsuario == 0)
            {
                return "No se pudo registrar el usuario administrador.";
            }

            return dAdministrador.Registrar(idUsuario);
        }

        public string RegistrarEspecialista(Usuario usuario, int idArea, bool disponible)
        {
            if (dUsuario.ExisteDni(usuario.dni))
            {
                return "El DNI ya está registrado.";
            }

            if (dUsuario.ExisteUsername(usuario.username))
            {
                return "El nombre de usuario ya está registrado.";
            }

            usuario.rol = "Especialista";

            int idUsuario = dUsuario.Registrar(usuario);

            if (idUsuario == 0)
            {
                return "No se pudo registrar el usuario especialista.";
            }

            return dEspecialista.Registrar(idUsuario, idArea, disponible);
        }

        public Usuario BuscarPorCorreo(string correo)
        {
            return dUsuario.BuscarPorCorreo(correo);
        }

        public string ActualizarPasswordPorCorreo(string correo, string nuevaPassword)
        {
            return dUsuario.ActualizarPasswordPorCorreo(correo, nuevaPassword);
        }

        public List<Usuario> ListarAdministradores()
        {
            return dUsuario.ListarAdministradores();
        }

        public List<Usuario> ListarEspecialistas()
        {
            return dUsuario.ListarEspecialistas();
        }

        public Usuario BuscarPorDni(string dni)
        {
            return dUsuario.BuscarPorDni(dni);
        }

        public Usuario BuscarPorUsername(string username)
        {
            return dUsuario.BuscarPorUsername(username);
        }

        public Usuario IniciarSesion(string username, string password)
        {
            return dUsuario.IniciarSesion(username, password);
        }

        public string Modificar(Usuario usuario)
        {
            if (dUsuario.ExisteDniEnOtroUsuario(usuario.dni, usuario.idUsuario))
            {
                return "El DNI ya está registrado en otro usuario.";
            }

            if (dUsuario.ExisteUsernameEnOtroUsuario(usuario.username, usuario.idUsuario))
            {
                return "El nombre de usuario ya está registrado en otro usuario.";
            }

            return dUsuario.Modificar(usuario);
        }

        public string EliminarLogico(int idUsuario, int idUsuarioModificador)
        {
            return dUsuario.EliminarLogico(idUsuario, idUsuarioModificador);
        }
    }
}

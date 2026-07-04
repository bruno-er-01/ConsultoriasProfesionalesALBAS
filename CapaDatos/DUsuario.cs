using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class DUsuario
    {
        public int Registrar(Usuario usuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    usuario.activo = true;
                    usuario.createdAt = DateTime.Now;
                    usuario.modifiedAt = null;

                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                    return usuario.idUsuario;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public Usuario BuscarPorCorreo(string correo)
        {
            Usuario usuario = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    usuario = context.Usuario
                        .Where(u => u.correo == correo && u.activo == true)
                        .FirstOrDefault();
                }

                return usuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return usuario;
            }
        }

        public string ActualizarPasswordPorCorreo(string correo, string nuevaPassword)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Usuario
                        .Where(u => u.correo == correo && u.activo == true)
                        .FirstOrDefault();

                    if (modificado == null)
                    {
                        return "Usuario no encontrado";
                    }

                    modificado.password = nuevaPassword;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Contraseña actualizada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ActualizarPassword(int idUsuario, string nuevaPassword)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Usuario.Find(idUsuario);

                    if (modificado == null)
                    {
                        return "Usuario no encontrado.";
                    }

                    modificado.password = nuevaPassword;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Contraseña actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar contraseña: " + ex.Message;
            }
        }

        public List<Usuario> ListarAdministradores()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .Where(u => u.rol == "Administrador" && u.activo == true)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Usuario>();
            }
        }

        public List<Usuario> ListarTodoAdministrador()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .Where(u => u.rol == "Administrador")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Usuario>();
            }
        }

        public List<Usuario> ListarEspecialistas()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .Where(u => u.rol == "Especialista" && u.activo == true)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Usuario>();
            }
        }

        public Usuario BuscarPorDni(string dni)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .FirstOrDefault(u => u.dni == dni && u.activo == true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Usuario BuscarPorUsername(string username)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .FirstOrDefault(u => u.username == username && u.activo == true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Usuario IniciarSesion(string username, string password)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario.FirstOrDefault(u =>
                        u.username == username &&
                        u.password == password &&
                        u.activo == true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool ExisteDni(string dni)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario.Any(u => u.dni == dni);
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ExisteUsername(string username)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario.Any(u => u.username == username);
                }
            }
            catch
            {
                return false;
            }
        }

        public string Modificar(Usuario usuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Usuario.Find(usuario.idUsuario);

                    if (modificado == null)
                    {
                        return "Usuario no encontrado.";
                    }

                    modificado.nombre = usuario.nombre;
                    modificado.apellido = usuario.apellido;
                    modificado.dni = usuario.dni;
                    modificado.telefono = usuario.telefono;
                    modificado.correo = usuario.correo;
                    modificado.username = usuario.username;
                    modificado.password = usuario.password;
                    modificado.direccion = usuario.direccion;
                    modificado.modifiedBy = usuario.modifiedBy;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Usuario modificado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al modificar usuario: " + ex.Message;
            }
        }

        public bool ExisteDniEnOtroUsuario(string dni, int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario.Any(u =>
                        u.dni == dni &&
                        u.idUsuario != idUsuario);
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ExisteUsernameEnOtroUsuario(string username, int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario.Any(u =>
                        u.username == username &&
                        u.idUsuario != idUsuario);
                }
            }
            catch
            {
                return false;
            }
        }

        public string ActualizarActivo(int idUsuario, bool activo, int idUsuarioModificador)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var usuario = context.Usuario.Find(idUsuario);

                    if (usuario == null)
                    {
                        return "Usuario no encontrado.";
                    }

                    usuario.activo = activo;
                    usuario.modifiedBy = idUsuarioModificador;
                    usuario.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Estado actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar estado: " + ex.Message;
            }
        }

        public string EliminarLogico(int idUsuario, int idUsuarioModificador)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var eliminado = context.Usuario.Find(idUsuario);

                    if (eliminado == null)
                    {
                        return "Usuario no encontrado.";
                    }

                    eliminado.activo = false;
                    eliminado.modifiedBy = idUsuarioModificador;
                    eliminado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Usuario eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar usuario: " + ex.Message;
            }
        }
        public int ContarUsuariosActivos()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Usuario
                        .Where(u => u.activo == true)
                        .Count();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
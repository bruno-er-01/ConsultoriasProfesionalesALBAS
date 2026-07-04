using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEspecialista
    {
        public string Registrar(int idUsuario, int idArea, bool disponible)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Especialista especialista = new Especialista
                    {
                        idEspecialista = idUsuario,
                        idArea = idArea,
                        disponible = disponible
                    };

                    context.Especialista.Add(especialista);
                    context.SaveChanges();
                }

                return "Especialista registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar especialista: " + ex.Message;
            }
        }
        public object ListarTodoActivos()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var lista = context.Especialista
                        .Where(e => e.Usuario.rol == "Especialista" && e.Usuario.activo == true)
                        .Select(e => new
                        {
                            idUsuario = e.Usuario.idUsuario,
                            nombre = e.Usuario.nombre,
                            apellido = e.Usuario.apellido,
                            dni = e.Usuario.dni,
                            telefono = e.Usuario.telefono,
                            correo = e.Usuario.correo,
                            username = e.Usuario.username,
                            password = e.Usuario.password,
                            direccion = e.Usuario.direccion,
                            idArea = e.idArea,
                            areaAtencion = e.Area.nombre,
                            disponible = e.disponible,
                            activo = e.Usuario.activo,
                            createdBy = e.Usuario.createdBy,
                            modifiedBy = e.Usuario.modifiedBy
                        })
                        .ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ListarTodo()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var lista = context.Especialista
                        .Where(e => e.Usuario.rol == "Especialista")
                        .Select(e => new
                        {
                            idUsuario = e.Usuario.idUsuario,
                            nombre = e.Usuario.nombre,
                            apellido = e.Usuario.apellido,
                            dni = e.Usuario.dni,
                            telefono = e.Usuario.telefono,
                            correo = e.Usuario.correo,
                            username = e.Usuario.username,
                            password = e.Usuario.password,
                            direccion = e.Usuario.direccion,
                            idArea = e.idArea,
                            areaAtencion = e.Area.nombre,
                            disponible = e.disponible,
                            activo = e.Usuario.activo,
                            createdBy = e.Usuario.createdBy,
                            modifiedBy = e.Usuario.modifiedBy
                        })
                        .ToList();

                    return lista;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string ActualizarDisponible(int idEspecialista, bool disponible)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var especialista = context.Especialista.Find(idEspecialista);

                    if (especialista == null)
                    {
                        return "Especialista no encontrado.";
                    }

                    especialista.disponible = disponible;
                    context.SaveChanges();
                }

                return "Disponibilidad actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar disponibilidad: " + ex.Message;
            }
        }
    }
}

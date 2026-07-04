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
        public string BuscarAreaEspecialista(int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var area = (from e in context.Especialista
                                join a in context.Area
                                    on e.idArea equals a.idArea
                                where e.idEspecialista == idUsuario
                                select a.nombre)
                                .FirstOrDefault();

                    if (area == null)
                    {
                        return "Sin área asignada";
                    }

                    return area;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error al cargar área";
            }
        }

        public bool BuscarDisponibilidadEspecialista(int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    bool disponible = context.Especialista
                        .Where(e => e.idEspecialista == idUsuario)
                        .Select(e => e.disponible)
                        .FirstOrDefault();

                    return disponible;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Usuario BuscarPorId(int idEspecialista)
        {
            Usuario usuario = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    usuario = context.Usuario
                        .Where(u => u.idUsuario == idEspecialista)
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

        public int ContarClientesAsignados(int idEspecialista)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso
                        .Where(c => c.idEspecialista == idEspecialista && c.activo == true)
                        .Select(c => c.idCliente)
                        .Distinct()
                        .Count();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int ContarEspecialistasDisponibles()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Especialista
                        .Where(e => e.disponible == true && e.Usuario.activo == true)
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

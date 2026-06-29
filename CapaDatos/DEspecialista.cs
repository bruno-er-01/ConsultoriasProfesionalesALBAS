using System;
using System.Collections.Generic;
using System.Linq;
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

        public Object ListarTodo()
        {
            List<DEspecialista> especialistas = new List<DEspecialista>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    //Filtrado de los datos de Especialistas
                    //Agarramos los datos que queremos mostrar en el datagrid y listo
                    var lista = context.Especialista
                        .Where(e => e.Usuario.activo == true && e.Usuario.rol == "Especialista")
                        .Select(e => new {
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
                            createdBy = e.Usuario.createdBy,
                            modifiedBy = e.Usuario.modifiedBy,
                        }).ToList();
                    return lista;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
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
    }
}

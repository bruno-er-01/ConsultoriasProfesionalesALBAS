using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class DCaso
    {
        public String Registrar(Caso caso)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    caso.estado = "Abierto";

                    caso.createdAt = DateTime.Now;
                    caso.createdBy = caso.idAdministrador;

                    context.Caso.Add(caso);
                    context.SaveChanges();

                    return "Caso registrado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Caso> ListarTodo()
        {
            List<Caso> casos = new List<Caso>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    context.Configuration.ProxyCreationEnabled = false;

                    return context.Caso.OrderBy(c => c.nroCaso).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return casos;
            }
        }

        public string Modificar(Caso caso)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Caso.Find(caso.nroCaso);

                    if (modificado == null)
                    {
                        return "Caso no encontrado en la base de datos.";
                    }

                    modificado.idCliente = caso.idCliente;
                    modificado.idEspecialista = caso.idEspecialista;
                    modificado.idAdministrador = caso.idAdministrador;
                    modificado.titulo = caso.titulo;
                    modificado.descripcion = caso.descripcion;
                    modificado.estado = caso.estado;
                    modificado.fechaHoraInicio = caso.fechaHoraInicio;
                    modificado.fechaHoraFin = caso.fechaHoraFin;
                    modificado.documento = caso.documento;

                    modificado.modifiedAt = DateTime.Now;
                    modificado.modifiedBy = caso.idAdministrador;

                    context.SaveChanges();
                }

                return "Caso modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Caso BuscarPorId(int nroCaso)
        {
            Caso caso = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    caso = context.Caso
                        .Include("Cliente")
                        .Include("Especialista")
                        .Where(c => c.nroCaso == nroCaso)
                        .FirstOrDefault();
                }

                return caso;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return caso;
            }
        }

        public List<ReporteAntiguedadCaso> ListarReporteAntiguedad()
        {
            List<ReporteAntiguedadCaso> reporte = new List<ReporteAntiguedadCaso>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var casos = context.Caso.Where(c => c.estado == "Abierto" ||
                        c.estado == "En proceso").ToList();

                    foreach (Caso caso in casos)
                    {
                        int diasAntiguedad = (DateTime.Now.Date - caso.fechaHoraInicio.Date).Days;
                        string clasificacion;

                        if (diasAntiguedad <= 15)
                        {
                            clasificacion = "Reciente";
                        }
                        else if (diasAntiguedad <= 30)
                        {
                            clasificacion = "En seguimiento";
                        }
                        else
                        {
                            clasificacion = "Crítico";
                        }

                        ReporteAntiguedadCaso fila = new ReporteAntiguedadCaso();

                        fila.NroCaso = caso.nroCaso;
                        fila.Titulo = caso.titulo;
                        fila.Cliente = caso.Cliente.nombre + " " + caso.Cliente.apellido;
                        fila.Area = caso.Especialista.Area.nombre;
                        fila.Especialista = caso.Especialista.Usuario.nombre + " " + caso.Especialista.Usuario.apellido;
                        fila.FechaInicio = caso.fechaHoraInicio;
                        fila.Estado = caso.estado;
                        fila.DiasAntiguedad = diasAntiguedad;
                        fila.Clasificacion = clasificacion;

                        reporte.Add(fila);
                    }
                }

                return reporte;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return reporte;
            }
        }
        public int ContarCasosActivos(int idEspecialista)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso
                        .Count(c =>
                            c.idEspecialista == idEspecialista &&
                            (c.estado == "Abierto" || c.estado == "En proceso"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int ContarCasosCerrados(int idEspecialista)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso
                        .Count(c =>
                            c.idEspecialista == idEspecialista &&
                            c.estado == "Cerrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public List<object> ListarCasosPorEspecialista(int idEspecialista, string estado, string texto)
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var consulta = context.Caso
                        .Where(c => c.idEspecialista == idEspecialista);

                    if (estado != "Todos" && estado != "")
                    {
                        consulta = consulta.Where(c => c.estado == estado);
                    }

                    if (texto != "")
                    {
                        consulta = consulta.Where(c =>
                            c.Cliente.nombre.Contains(texto) ||
                            c.Cliente.apellido.Contains(texto) ||
                            c.Cliente.dni.Contains(texto) ||
                            c.titulo.Contains(texto));
                    }

                    lista = consulta
                        .OrderByDescending(c => c.nroCaso)
                        .Select(c => new
                        {
                            NroCaso = c.nroCaso,
                            IdCliente = c.idCliente,
                            Cliente = c.Cliente.nombre + " " + c.Cliente.apellido,
                            DNI = c.Cliente.dni,
                            Titulo = c.titulo,
                            Estado = c.estado,
                            FechaInicio = c.fechaHoraInicio
                        })
                        .ToList<object>();
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }
        public Caso BuscarPorNroCaso(int nroCaso)
        {
            Caso caso = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    caso = context.Caso
                        .Include("Cliente")
                        .Include("Especialista")
                        .Where(c => c.nroCaso == nroCaso && c.activo == true)
                        .FirstOrDefault();
                }
                return caso;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return caso;
            }
        }
        public string ActualizarEstadoEspecialista(int nroCaso, string estadoNuevo, int idUsuarioModificador)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Caso caso = context.Caso.Find(nroCaso);

                    if (caso == null)
                    {
                        return "Caso no encontrado.";
                    }

                    if (caso.estado == "Cerrado")
                    {
                        return "El caso ya se encuentra cerrado.";
                    }

                    if (caso.estado == "Archivado" || caso.estado == "Anulado")
                    {
                        return "No se puede modificar un caso archivado o anulado.";
                    }

                    caso.estado = estadoNuevo;
                    caso.modifiedBy = idUsuarioModificador;
                    caso.modifiedAt = DateTime.Now;

                    if (estadoNuevo == "Cerrado")
                    {
                        caso.fechaHoraFin = DateTime.Now;
                    }

                    context.SaveChanges();
                }

                return "Estado del caso actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar estado: " + ex.Message;
            }
        }
        public int ContarCasosActivos()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso
                        .Where(c => c.activo == true &&
                                   (c.estado == "Abierto" || c.estado == "En proceso"))
                        .Count();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public List<object> ListarCasosPorEstado()
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    lista = context.Caso
                        .Where(c => c.activo == true)
                        .GroupBy(c => c.estado)
                        .Select(g => new
                        {
                            Estado = g.Key,
                            Cantidad = g.Count()
                        })
                        .ToList<object>();
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        public string EliminarLogico(int nroCaso, int idUsuarioModificador)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var caso = context.Caso.Find(nroCaso);
                    if (caso == null) return "Caso no encontrado";

                    caso.estado = "Cerrado";

                    caso.modifiedAt = DateTime.Now;
                    caso.modifiedBy = idUsuarioModificador;

                    context.SaveChanges();
                }
                return "Caso eliminado (cerrado) lógicamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

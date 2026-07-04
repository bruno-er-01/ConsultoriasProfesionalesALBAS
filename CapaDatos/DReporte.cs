using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReporteNoShowEstructura
    {
        public string Mes { get; set; }
        public double TotalPerdido { get; set; }
    }

    public class DReporte
    {
        public List<string> ListarEstadosCaso()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso
                        .Select(c => c.estado)
                        .Distinct()
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
        }

        public List<ReporteDemandaArea> ReporteDemandaPorArea(DateTime fechaInicio, DateTime fechaFin, string estado, string orden)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime desde = fechaInicio.Date;
                    DateTime hasta = fechaFin.Date.AddDays(1);

                    var consulta = from a in context.Area
                                   join e in context.Especialista
                                        on a.idArea equals e.idArea
                                   join c in context.Caso
                                        on e.idEspecialista equals c.idEspecialista
                                   where a.activo == true &&
                                         c.fechaHoraInicio >= desde &&
                                         c.fechaHoraInicio < hasta
                                   select new
                                   {
                                       IdArea = a.idArea,
                                       Area = a.nombre,
                                       Estado = c.estado,
                                       IdEspecialista = e.idEspecialista,
                                       Disponible = e.disponible
                                   };

                    if (estado != "Todos")
                    {
                        consulta = consulta.Where(x => x.Estado == estado);
                    }

                    var datosBase = consulta.ToList();

                    int totalGeneral = datosBase.Count;

                    var reporte = datosBase
                        .GroupBy(x => new { x.IdArea, x.Area })
                        .Select(g => new ReporteDemandaArea
                        {
                            Area = g.Key.Area,
                            TotalCasos = g.Count(),

                            CasosActivos = g.Count(x =>
                                x.Estado == "Abierto" ||
                                x.Estado == "En proceso"),

                            CasosCerrados = g.Count(x =>
                                x.Estado == "Cerrado"),

                            PorcentajeDemanda = totalGeneral == 0
                                ? 0
                                : Math.Round((g.Count() * 100.0) / totalGeneral, 2),

                            EspecialistasDisponibles = context.Especialista
                                .Join(context.Usuario,
                                    esp => esp.idEspecialista,
                                    usu => usu.idUsuario,
                                    (esp, usu) => new { esp, usu })
                                .Count(x =>
                                    x.esp.idArea == g.Key.IdArea &&
                                    x.esp.disponible == true &&
                                    x.usu.activo == true),

                            Recomendacion = ""
                        })
                        .ToList();

                    foreach (var item in reporte)
                    {
                        if (item.PorcentajeDemanda >= 50)
                        {
                            item.Recomendacion = "Reforzar área";
                        }
                        else if (item.PorcentajeDemanda >= 20)
                        {
                            item.Recomendacion = "Mantener atención";
                        }
                        else
                        {
                            item.Recomendacion = "Bajo flujo";
                        }
                    }

                    if (orden == "Ascendente")
                    {
                        reporte = reporte.OrderBy(r => r.TotalCasos).ToList();
                    }
                    else
                    {
                        reporte = reporte.OrderByDescending(r => r.TotalCasos).ToList();
                    }

                    return reporte;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ReporteDemandaArea>();
            }
        }

        public class ReporteNoShowEstructura
        {
            public string Mes { get; set; }
            public double TotalPerdido { get; set; }
        }

        public List<CapaDatos.ReporteNoShowEstructura> ObtenerPerdidaNoShow()
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var query = from c in context.Cita
                                join ca in context.Caso on c.nroCaso equals ca.nroCaso
                                join e in context.Especialista on ca.idEspecialista equals e.idEspecialista
                                join a in context.Area on e.idArea equals a.idArea
                                where c.estado == "Cancelado" || c.confirmacionAsistencia == false
                                select new { c.fecha, a.costo };

                    List<CapaDatos.ReporteNoShowEstructura> resultado = query.ToList()
                        .GroupBy(x => x.fecha.ToString("MMMM"))
                        .Select(g => new CapaDatos.ReporteNoShowEstructura
                        {
                            Mes = g.Key,
                            TotalPerdido = g.Sum(x => Convert.ToDouble(x.costo))
                        }).ToList();

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<CapaDatos.ReporteNoShowEstructura>();
            }
        }

        // Otenemos los montos de area
        public List<object> ReporteMontosPorArea(DateTime fechaInicio, DateTime fechaFin, int idArea, string modalidad, string orden)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var query = from c in context.Cita
                                join ca in context.Caso on c.nroCaso equals ca.nroCaso
                                join e in context.Especialista on ca.idEspecialista equals e.idEspecialista
                                join a in context.Area on e.idArea equals a.idArea
                                where c.fecha >= fechaInicio
                                   && c.fecha <= fechaFin
                                   && c.estado != "Cancelado"
                                   && c.confirmacionAsistencia == true
                                select new
                                {
                                    Fecha = c.fecha,
                                    Modalidad = c.modalidad,
                                    IdArea = a.idArea,
                                    Area = a.nombre,
                                    Costo = a.costo
                                };

                    if (idArea != 0)
                    {
                        query = query.Where(x => x.IdArea == idArea);
                    }

                    if (modalidad != "Todos")
                    {
                        query = query.Where(x => x.Modalidad == modalidad);
                    }

                    var reporte = query
                        .GroupBy(x => new
                        {
                            Anio = x.Fecha.Year,
                            Mes = x.Fecha.Month
                        })
                        .Select(g => new
                        {
                            Anio = g.Key.Anio,
                            Mes = g.Key.Mes,
                            MontoTotal = g.Sum(x => x.Costo),
                            CantidadCitas = g.Count()
                        });

                    if (orden == "Descendente")
                    {
                        reporte = reporte.OrderByDescending(x => x.MontoTotal);
                    }
                    else
                    {
                        reporte = reporte.OrderBy(x => x.Anio).ThenBy(x => x.Mes);
                    }

                    return reporte.ToList<object>();
                }
            }
            catch
            {
                return new List<object>();
            }
        }

        //Montos para el grafico pastel
        public List<object> ReporteMontosPorModalidad(DateTime fechaInicio, DateTime fechaFin, int idArea)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var query = from c in context.Cita
                                join ca in context.Caso on c.nroCaso equals ca.nroCaso
                                join e in context.Especialista on ca.idEspecialista equals e.idEspecialista
                                join a in context.Area on e.idArea equals a.idArea
                                where c.fecha >= fechaInicio
                                   && c.fecha <= fechaFin
                                   && c.estado != "Cancelado"
                                   && c.confirmacionAsistencia == true
                                select new
                                {
                                    Modalidad = c.modalidad,
                                    IdArea = a.idArea,
                                    Costo = a.costo
                                };

                    if (idArea != 0)
                    {
                        query = query.Where(x => x.IdArea == idArea);
                    }

                    var reporte = query
                        .GroupBy(x => x.Modalidad)
                        .Select(g => new
                        {
                            Modalidad = g.Key,
                            MontoTotal = g.Sum(x => x.Costo),
                            CantidadCitas = g.Count()
                        })
                        .ToList<object>();

                    return reporte;
                }
            }
            catch
            {
                return new List<object>();
            }
        }

    }
}



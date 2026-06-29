using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public  class DReporte
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
    }
}


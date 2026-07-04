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

        public List<ReporteCargaEspecialista> ReporteCargaLaboralPorEspecialista(DateTime fechaInicio, DateTime fechaFin, string orden)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime desde = fechaInicio.Date;
                    DateTime hasta = fechaFin.Date.AddDays(1);

                    var consulta = from e in context.Especialista
                                   join u in context.Usuario on e.idEspecialista equals u.idUsuario
                                   join a in context.Area on e.idArea equals a.idArea
                                   join c in context.Caso on e.idEspecialista equals c.idEspecialista
                                   where u.activo == true
                                         && a.activo == true
                                         && c.activo == true
                                         && c.fechaHoraInicio >= desde
                                         && c.fechaHoraInicio < hasta
                                   select new
                                   {
                                       IdEspecialista = e.idEspecialista,
                                       NombreCompleto = u.nombre + " " + u.apellido,
                                       Area = a.nombre,
                                       IdCaso = c.nroCaso,
                                       EstadoCaso = c.estado
                                   };

                    var datosBase = consulta.ToList();
                    var todasLasCitas = context.Cita.ToList();

                    List<ReporteCargaEspecialista> listaReporte = new List<ReporteCargaEspecialista>();
                    var grupos = datosBase.GroupBy(x => new { x.IdEspecialista, x.NombreCompleto, x.Area });
                    int totalCasosGeneral = datosBase.Select(x => x.IdCaso).Distinct().Count();

                    foreach (var g in grupos)
                    {
                        ReporteCargaEspecialista fila = new ReporteCargaEspecialista();
                        fila.IdEspecialista = g.Key.IdEspecialista;
                        fila.NombreEspecialista = g.Key.NombreCompleto;
                        fila.Area = g.Key.Area;

                        fila.TotalCasos = g.Select(x => x.IdCaso).Distinct().Count();
                        fila.CasosActivos = g.Where(x => x.EstadoCaso == "Abierto" || x.EstadoCaso == "En proceso").Select(x => x.IdCaso).Distinct().Count();
                        fila.CasosCerrados = g.Where(x => x.EstadoCaso == "Cerrado").Select(x => x.IdCaso).Distinct().Count();

                        int contadorCitas = 0;
                        foreach (var caso in g)
                        {
                            foreach (var cita in todasLasCitas)
                            {
                                if (cita.nroCaso == caso.IdCaso)
                                {
                                    contadorCitas = contadorCitas + 1;
                                }
                            }
                        }
                        fila.TotalCitas = contadorCitas;

                        if (totalCasosGeneral == 0)
                        {
                            fila.PorcentajeDemanda = 0;
                        }
                        else
                        {
                            double calculo = (fila.TotalCasos * 100.0) / totalCasosGeneral;
                            fila.PorcentajeDemanda = Math.Round(calculo, 2);
                        }

                        if (fila.TotalCasos >= 8)
                        {
                            fila.Recomendacion = "Sobrecarga detectada. Evaluar redistribución.";
                        }
                        else if (fila.TotalCasos >= 4)
                        {
                            fila.Recomendacion = "Carga moderada. Flujo de trabajo óptimo.";
                        }
                        else
                        {
                            fila.Recomendacion = "Carga baja. Disponible para asignación.";
                        }

                        listaReporte.Add(fila);
                    }

                    if (orden == "Ascendente")
                    {
                        listaReporte = listaReporte.OrderBy(r => r.TotalCasos).ToList();
                    }
                    else
                    {
                        listaReporte = listaReporte.OrderByDescending(r => r.TotalCasos).ToList();
                    }

                    return listaReporte;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ReporteCargaEspecialista>();
            }
        }
    }
}



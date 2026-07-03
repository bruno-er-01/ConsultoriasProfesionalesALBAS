using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClassAuxiliares
    {
    }
    // REPORTE 01
    public class ReporteDemandaArea
    {
        public string Area { get; set; }
        public int TotalCasos { get; set; }
        public int CasosActivos { get; set; }
        public int CasosCerrados { get; set; }
        public double PorcentajeDemanda { get; set; }
        public int EspecialistasDisponibles { get; set; }
        public string Recomendacion { get; set; }
    }

    //REPORTE 02
    public class ReporteAntiguedadCaso
    {
        public int NroCaso { get; set; }
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public string Area { get; set; }
        public string Especialista { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; }
        public int DiasAntiguedad { get; set; }
        public string Clasificacion { get; set; }
    }
}

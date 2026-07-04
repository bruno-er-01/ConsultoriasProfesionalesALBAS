using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NReporte
    {
        private DReporte dReporte = new DReporte();

        public List<string> ListarEstadosCaso()
        {
            List<string> estados = dReporte.ListarEstadosCaso();

            estados.Insert(0, "Todos");

            return estados;
        }

        public List<ReporteDemandaArea> ReporteDemandaPorArea(DateTime fechaInicio, DateTime fechaFin, string estado, string orden)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<ReporteDemandaArea>();
            }

            return dReporte.ReporteDemandaPorArea(fechaInicio, fechaFin, estado, orden);
        }

        public List<ReporteNoShowEstructura> ObtenerPerdidaNoShow()
        {
            return dReporte.ObtenerPerdidaNoShow();
        }

        //Reporte montos 1
        public List<object> ReporteMontosPorArea(DateTime fechaInicio, DateTime fechaFin, int idArea, string modalidad, string orden)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<object>();
            }

            return dReporte.ReporteMontosPorArea(fechaInicio, fechaFin, idArea, modalidad, orden);
        }

        public List<object> ReporteMontosPorModalidad(DateTime fechaInicio, DateTime fechaFin, int idArea)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<object>();
            }

            return dReporte.ReporteMontosPorModalidad(fechaInicio, fechaFin, idArea);
        }

        //---
    }
}

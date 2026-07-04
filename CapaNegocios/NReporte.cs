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

        public List<ReporteCargaEspecialista> ReporteCargaLaboralPorEspecialista(DateTime fechaInicio, DateTime fechaFin, string orden)
        {
            if (fechaInicio > fechaFin)
            {
                return new List<ReporteCargaEspecialista>();
            }

            return dReporte.ReporteCargaLaboralPorEspecialista(fechaInicio, fechaFin, orden);
        }
    }
}

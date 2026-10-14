using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NCita
    {
        private DCita dCita = new DCita();

        public string Registrar(Cita cita)
        {
            return dCita.Registrar(cita);
        }

        public List<Cita> ListarPorCaso(int nroCaso)
        {
            return dCita.ListarPorCaso(nroCaso);
        }

        public string AgregarRecordatorio(int idCita, int tiempoAnticipacion)
        {
            return dCita.AgregarRecordatorio(idCita, tiempoAnticipacion);
        }

        public string Modificar(Cita cita)
        {
            return dCita.Modificar(cita);
        }

        public string EliminarLogico(int idCita)
        {
            return dCita.EliminarLogico(idCita);
        }

        public string ModificarAtencionEspecialista(Cita cita)
        {
            return dCita.ModificarAtencionEspecialista(cita);
        }
        public string ModificarRecordatorio(int idCita, int tiempoAnticipacion)
        {
            return dCita.ModificarRecordatorio(idCita, tiempoAnticipacion);
        }

        public string CancelarRecordatorio(int idCita)
        {
            return dCita.CancelarRecordatorio(idCita);
        }
        public List<object> BuscarCitasParaRecordatorio(string dniCliente, string dniEspecialista)
        {
            return dCita.BuscarCitasParaRecordatorio(dniCliente, dniEspecialista);
        }

        public List<object> ListarCitasParaRecordatorio()
        {
            return dCita.ListarCitasParaRecordatorio();
        }
        public List<Cita> ListarCitasConRecordatorio()
        {
            return dCita.ListarCitasConRecordatorio();
        }
        public int ContarCitasHoy(int idEspecialista)
        {
            return dCita.ContarCitasHoy(idEspecialista);
        }

        public List<object> ListarCitasPendientesPorEspecialista(int idEspecialista)
        {
            return dCita.ListarCitasPendientesPorEspecialista(idEspecialista);
        }

        public List<ReporteCitasAusentes> ObtenerMetricasAusencias(DateTime fechaInicio, DateTime fechaFin)
        {
            return dCita.ObtenerMetricasAusencias(fechaInicio, fechaFin);
        }
        public void ObtenerRangoFechasCanceladas(out DateTime fechaMin, out DateTime fechaMax)
        {
            dCita.ObtenerRangoFechasCanceladas(out fechaMin, out fechaMax);
        }
    }
}

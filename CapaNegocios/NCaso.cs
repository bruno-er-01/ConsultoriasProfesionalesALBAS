using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NCaso
    {
        private DCaso dCaso = new DCaso();

        public string Registrar(Caso caso)
        {
            return dCaso.Registrar(caso);
        }

        public List<Caso> ListarTodo()
        {
            return dCaso.ListarTodo();
        }

        public string Modificar(Caso caso)
        {
            return dCaso.Modificar(caso);
        }

        public Caso BuscarPorId(int nroCaso, int idCliente)
        {
            return dCaso.BuscarPorId(nroCaso, idCliente);
        }

        public List<ReporteAntiguedadCaso> ListarReporteAntiguedad()
        {
            return dCaso.ListarReporteAntiguedad();
        }
        public int ContarCasosActivos(int idEspecialista)
        {
            return dCaso.ContarCasosActivos(idEspecialista);
        }
        public int ContarCasosCerrados(int idEspecialista)
        {
            return dCaso.ContarCasosCerrados(idEspecialista);
        }
        public List<object> ListarCasosPorEspecialista(int idEspecialista, string estado, string texto)
        {
            return dCaso.ListarCasosPorEspecialista(idEspecialista, estado, texto);
        }
        public Caso BuscarPorNroCaso(int nroCaso)
        {
            return dCaso.BuscarPorNroCaso(nroCaso);
        }
    }
}

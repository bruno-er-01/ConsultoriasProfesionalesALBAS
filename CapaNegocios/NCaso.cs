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
            caso.estado = "Abierto";
            caso.activo = true;
            caso.createdAt = DateTime.Now;
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

        public Caso BuscarPorId(int nroCaso)
        {
            return dCaso.BuscarPorId(nroCaso);
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
        public string ActualizarEstadoEspecialista(int nroCaso, string estadoNuevo, int idUsuarioModificador)
        {
            if (estadoNuevo == "")
            {
                return "Seleccione un estado.";
            }

            if (estadoNuevo != "En proceso" && estadoNuevo != "Cerrado")
            {
                return "El especialista solo puede cambiar el estado a En proceso o Cerrado.";
            }

            return dCaso.ActualizarEstadoEspecialista(nroCaso, estadoNuevo, idUsuarioModificador);
        }
        public int ContarCasosActivos()
        {
            return dCaso.ContarCasosActivos();
        }
        public List<object> ListarCasosPorEstado()
        {
            return dCaso.ListarCasosPorEstado();
        }
        public string EliminarLogico(int nroCaso, int idUsuarioModificador)
        {
            return dCaso.EliminarLogico(nroCaso, idUsuarioModificador);
        }
    }
}

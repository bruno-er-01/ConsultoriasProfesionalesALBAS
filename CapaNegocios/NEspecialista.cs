using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NEspecialista
    {
        private DEspecialista dEspecialista = new DEspecialista();

        public string BuscarAreaEspecialista(int idUsuario)
        {
            return dEspecialista.BuscarAreaEspecialista(idUsuario);
        }

        public bool BuscarDisponibilidadEspecialista(int idUsuario)
        {
            return dEspecialista.BuscarDisponibilidadEspecialista(idUsuario);
        }

        public Usuario BuscarPorId(int idEspecialista)
        {
            return dEspecialista.BuscarPorId(idEspecialista);   
        }

        public int ContarClientesAsignados(int idEspecialista)
        {
            return dEspecialista.ContarClientesAsignados(idEspecialista);
        }

    }
}

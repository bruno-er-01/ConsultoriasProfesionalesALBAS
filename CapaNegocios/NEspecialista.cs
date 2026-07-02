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
        private DEspecialista dEspecialista =
            new DEspecialista();

        public Usuario BuscarPorId(int idEspecialista)
        {
            return dEspecialista.BuscarPorId(idEspecialista);
        }
    }
}

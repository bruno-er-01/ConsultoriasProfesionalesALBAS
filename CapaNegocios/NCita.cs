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

        public List<Cita> ListarPorCasoCliente(int nroCaso, int idCliente)
        {
            return dCita.ListarPorCasoCliente(nroCaso, idCliente);
        }

        public string Modificar(Cita cita)
        {
            return dCita.Modificar(cita);
        }
    }
}

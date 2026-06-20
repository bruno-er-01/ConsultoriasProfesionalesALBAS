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

        public List<Cita> ListarTodo()
        {
            return dCita.ListarTodo();
        }

        public string Modificar(Cita cita)
        {
            return dCita.Modificar(cita);
        }
    }
}

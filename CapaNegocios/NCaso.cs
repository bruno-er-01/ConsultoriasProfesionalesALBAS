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
    }
}

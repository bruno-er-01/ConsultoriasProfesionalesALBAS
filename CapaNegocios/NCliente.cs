using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();

        public string Registrar(Cliente cliente)
        {
            return dCliente.Registrar(cliente);
        }

        public List<Cliente> ListarTodo()
        {
            return dCliente.ListarTodo();
        }

        public string Modificar(Cliente cliente)
        {
            return dCliente.Modificar(cliente);
        }

        public string EliminarLogico(int idCliente)
        {
            return dCliente.EliminarLogico(idCliente);
        }

        public Cliente BuscarPorId(int idCliente)
        {
            return dCliente.BuscarPorId(idCliente);
        }
    }
}

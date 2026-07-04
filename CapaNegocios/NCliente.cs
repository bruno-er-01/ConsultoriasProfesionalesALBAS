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

        public List<Cliente> ListarTodoActivos()
        {
            return dCliente.ListarTodoActivos();
        }
        public string ActualizarActivo(int idCliente, bool activo, int idUsuario)
        {
            return dCliente.ActualizarActivo(idCliente, activo, idUsuario);
        }
        public Cliente EncontrarClienteDNI(string dni)
        {
           return dCliente.EncontrarClienteDNI(dni);
        }

        public Cliente EncontrarCliente(int id)
        {
            return dCliente.EncontrarCliente(id);
        }

        public string Modificar(Cliente cliente)
        {
            return dCliente.Modificar(cliente);
        }

        public string EliminarLogico(int idCliente)
        {
            return dCliente.EliminarLogico(idCliente);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCliente
    {
        public String Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    cliente.activo = true;
                    cliente.createdAt = DateTime.Now;
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Cliente> ListarTodo()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    clientes = context.Cliente
                        .Where(c => c.activo == true)
                        .ToList();
                }

                return clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return clientes;
            }
        }

        public string Modificar(Cliente cliente)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Cliente.Find(cliente.idCliente);

                    if (modificado == null)
                    {
                        return "Cliente no encontrado";
                    }

                    modificado.nombre = cliente.nombre;
                    modificado.apellido = cliente.apellido;
                    modificado.correo = cliente.correo;
                    modificado.telefono = cliente.telefono;
                    modificado.direccion = cliente.direccion;
                    modificado.genero = cliente.genero;
                    modificado.modifiedBy = cliente.modifiedBy;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Cliente modificado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarLogico(int idCliente)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var eliminado = context.Cliente.Find(idCliente);

                    if (eliminado == null)
                    {
                        return "Cliente no encontrado";
                    }

                    eliminado.activo = false;
                    eliminado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Cliente eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Cliente BuscarPorId(int idCliente)
        {
            Cliente cliente = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    cliente = context.Cliente
                        .Where(c => c.idCliente == idCliente)
                        .FirstOrDefault();
                }

                return cliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return cliente;
            }
        }
    }
}

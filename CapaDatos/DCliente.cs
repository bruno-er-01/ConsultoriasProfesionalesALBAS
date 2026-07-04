using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                    clientes = context.Cliente.ToList();
                }

                return clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return clientes;
            }
        }

        public List<Cliente> ListarTodoActivos()
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

        public Cliente EncontrarClienteDNI(string dni)
        {
            Cliente cliente = new Cliente();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    cliente = context.Cliente.Where(c => c.dni == dni && c.activo == true).FirstOrDefault();
                }
                return cliente;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return cliente;
            }
        }

        public Cliente EncontrarCliente(int id)
        {
            Cliente cliente = new Cliente();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    cliente = context.Cliente.Find(id);
                }
                return cliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return cliente;
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
        public string ActualizarActivo(int idCliente, bool activo, int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var cliente = context.Cliente.Find(idCliente);

                    if (cliente == null)
                    {
                        return "Cliente no encontrado";
                    }

                    cliente.activo = activo;
                    cliente.modifiedBy = idUsuario;
                    cliente.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Estado actualizado";
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
        public List<object> ListarClientesPorMes()
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    int anioActual = DateTime.Now.Year;
                    int mesActual = DateTime.Now.Month;

                    var consulta = context.Cliente
                        .Where(c => c.activo == true &&
                                    c.createdAt != null &&
                                    c.createdAt.Year == anioActual)
                        .GroupBy(c => c.createdAt.Month)
                        .Select(g => new
                        {
                            MesNumero = g.Key,
                            Cantidad = g.Count()
                        })
                        .ToList();

                    for (int mes = 1; mes <= mesActual; mes++)
                    {
                        int cantidad = 0;

                        var encontrado = consulta
                            .Where(c => c.MesNumero == mes)
                            .FirstOrDefault();

                        if (encontrado != null)
                        {
                            cantidad = encontrado.Cantidad;
                        }

                        lista.Add(new
                        {
                            Mes = ObtenerNombreMes(mes),
                            Cantidad = cantidad
                        });
                    }

                    return lista;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        private string ObtenerNombreMes(int mes)
        {
            switch (mes)
            {
                case 1: return "Ene";
                case 2: return "Feb";
                case 3: return "Mar";
                case 4: return "Abr";
                case 5: return "May";
                case 6: return "Jun";
                case 7: return "Jul";
                case 8: return "Ago";
                case 9: return "Sep";
                case 10: return "Oct";
                case 11: return "Nov";
                case 12: return "Dic";
                default: return "";
            }
        }
    }
}

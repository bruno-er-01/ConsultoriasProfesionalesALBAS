using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCaso
    {
        public String Registrar(Caso caso)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    int ultimoNro = context.Caso
                        .Where(c => c.idCliente == caso.idCliente)
                        .Select(c => (int?)c.nroCaso)
                        .DefaultIfEmpty(0)
                        .Max() ?? 0;

                    caso.nroCaso = ultimoNro + 1;

                    caso.estado = "Abierto";
                    caso.createdAt = DateTime.Now;

                    context.Caso.Add(caso);
                    context.SaveChanges();

                    return "Caso Nro " + caso.nroCaso + " registrado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Caso> ListarTodo()
        {
            List<Caso> casos = new List<Caso>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Caso.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return casos;
            }
        }

        public string Modificar(Caso caso)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Caso.Find(caso.nroCaso);

                    if (modificado == null)
                    {
                        return "Caso no encontrado";
                    }

                    modificado.idEspecialista = caso.idEspecialista;
                    modificado.idAdministrador = caso.idAdministrador;
                    modificado.titulo = caso.titulo;
                    modificado.descripcion = caso.descripcion;
                    modificado.fechaHoraInicio = caso.fechaHoraInicio;
                    modificado.fechaHoraFin = caso.fechaHoraFin;
                    modificado.estado = caso.estado;
                    modificado.documento = caso.documento;
                    modificado.modifiedBy = caso.modifiedBy;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Caso modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

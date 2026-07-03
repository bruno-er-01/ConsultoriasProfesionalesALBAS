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

        public Caso BuscarPorId(int nroCaso, int idCliente)
        {
            Caso caso = null;

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    caso = context.Caso
                        .Where(c => c.nroCaso == nroCaso
                                 && c.idCliente == idCliente)
                        .FirstOrDefault();
                }

                return caso;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return caso;
            }
        }

        public List<ReporteAntiguedadCaso> ListarReporteAntiguedad()
        {
            List<ReporteAntiguedadCaso> reporte = new List<ReporteAntiguedadCaso>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var casos = context.Caso.ToList();

                    foreach (Caso caso in casos)
                    {
                        int diasAntiguedad = (DateTime.Now.Date - caso.fechaHoraInicio.Date).Days;
                        string clasificacion;

                        if (diasAntiguedad <= 15)
                        {
                            clasificacion = "Reciente";
                        }
                        else if (diasAntiguedad <= 30)
                        {
                            clasificacion = "En seguimiento";
                        }
                        else
                        {
                            clasificacion = "Crítico";
                        }

                        ReporteAntiguedadCaso fila = new ReporteAntiguedadCaso();

                        fila.NroCaso = caso.nroCaso;
                        fila.Titulo = caso.titulo;
                        fila.Cliente = caso.Cliente.nombre + " " + caso.Cliente.apellido;
                        fila.Area = caso.Especialista.Area.nombre;
                        fila.Especialista = caso.Especialista.Usuario.nombre + " " + caso.Especialista.Usuario.apellido;
                        fila.FechaInicio = caso.fechaHoraInicio;
                        fila.Estado = caso.estado;
                        fila.DiasAntiguedad = diasAntiguedad;
                        fila.Clasificacion = clasificacion;

                        reporte.Add(fila);
                    }
                }

                return reporte;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return reporte;
            }
        }
    }
}

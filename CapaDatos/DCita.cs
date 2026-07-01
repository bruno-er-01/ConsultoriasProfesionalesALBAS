using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCita
    {
        public String Registrar(Cita cita)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    cita.estado = "Pendiente";
                    cita.createdAt = DateTime.Now;
                    context.Cita.Add(cita);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public List<Cita> ListarPorCasoCliente(int nroCaso, int idCliente)
        {
            List<Cita> citas = new List<Cita>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Cita.Where(c => c.nroCaso == nroCaso 
                        && c.idCliente == idCliente)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return citas;
            }
        }

        public string Modificar(Cita cita)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    var modificado = context.Cita.Find(cita.idCita);

                    if (modificado == null)
                    {
                        return "Cita no encontrada";
                    }

                    modificado.fecha = cita.fecha;
                    modificado.horaInicio = cita.horaInicio;
                    modificado.horaFin = cita.horaFin;
                    modificado.estado = cita.estado;
                    modificado.observacion = cita.observacion;
                    modificado.modalidad = cita.modalidad;
                    modificado.confirmacionAsistencia = cita.confirmacionAsistencia;
                    modificado.modifiedBy = cita.modifiedBy;
                    modificado.modifiedAt = DateTime.Now;

                    context.SaveChanges();
                }

                return "Cita modificada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

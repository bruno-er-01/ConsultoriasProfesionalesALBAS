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
                        && c.id == idCliente)
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

        public string AgregarRecordatorio(int idCita, int tiempoAnticipacion)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Cita cita = context.Cita.Find(idCita);

                    if (cita == null)
                    {
                        return "Cita no encontrada";
                    }

                    if (cita.tiempoAnticipacion != null)
                    {
                        return "La cita ya tiene un recordatorio";
                    }

                    cita.tiempoAnticipacion = tiempoAnticipacion;
                    cita.modifiedAt = DateTime.Now;

                    context.SaveChanges();

                    return "Recordatorio añadido correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ModificarRecordatorio(int idCita, int tiempoAnticipacion)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Cita cita = context.Cita.Find(idCita);

                    if (cita == null)
                    {
                        return "Cita no encontrada";
                    }

                    if (cita.tiempoAnticipacion == null)
                    {
                        return "La cita no tiene un recordatorio";
                    }

                    cita.tiempoAnticipacion = tiempoAnticipacion;
                    cita.modifiedAt = DateTime.Now;

                    context.SaveChanges();

                    return "Recordatorio modificado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CancelarRecordatorio(int idCita)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Cita cita = context.Cita.Find(idCita);

                    if (cita == null)
                    {
                        return "Cita no encontrada";
                    }

                    if (cita.tiempoAnticipacion == null)
                    {
                        return "La cita no tiene un recordatorio";
                    }

                    cita.tiempoAnticipacion = null;
                    cita.modifiedAt = DateTime.Now;

                    context.SaveChanges();

                    return "Recordatorio cancelado correctamente";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<object> ListarCitasParaRecordatorio()
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime fechaActual = DateTime.Now.Date;
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;

                    lista = context.Cita.Where(c =>
                            (c.estado == "Pendiente" || c.estado == "Reprogramado") 
                            && (c.fecha > fechaActual || (c.fecha == fechaActual && c.horaInicio > horaActual)))
                            .Select(c => new
                            {
                                IdCita = c.idCita,
                                DNICliente = c.Caso.Cliente.dni,
                                NombreCliente = c.Caso.Cliente.nombre + " " + c.Caso.Cliente.apellido,
                                DNIEspecialista = c.Caso.Especialista.Usuario.dni,
                                NombreEspecialista = c.Caso.Especialista.Usuario.nombre + " " + c.Caso.Especialista.Usuario.apellido,
                                HoraInicio = c.horaInicio,
                                Fecha = c.fecha,
                                Modalidad = c.modalidad,
                                TiempoAnticipacion = c.tiempoAnticipacion
                            }).ToList<object>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        public List<object> BuscarCitasParaRecordatorio(string dniCliente, string dniEspecialista)
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime fechaActual = DateTime.Now.Date;
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;

                    lista = context.Cita
                        .Where(c =>
                        (c.estado == "Pendiente" || c.estado == "Reprogramado")
                        && (c.fecha > fechaActual || (c.fecha == fechaActual && c.horaInicio > horaActual))
                        && (dniCliente == "" || c.Caso.Cliente.dni == dniCliente)
                        && (dniEspecialista == "" || c.Caso.Especialista.Usuario.dni == dniEspecialista)).
                        OrderBy(c => c.fecha)
                        .ThenBy(c => c.horaInicio)
                        .Select(c => new
                        {
                            IdCita = c.idCita,
                            DNICliente = c.Caso.Cliente.dni,
                            NombreCliente = c.Caso.Cliente.nombre + " " + c.Caso.Cliente.apellido,
                            DNIEspecialista = c.Caso.Especialista.Usuario.dni,
                            NombreEspecialista = c.Caso.Especialista.Usuario.nombre + " " + c.Caso.Especialista.Usuario.apellido,
                            HoraInicio = c.horaInicio,
                            Fecha = c.fecha,
                            Modalidad = c.modalidad,
                            TiempoAnticipacion = c.tiempoAnticipacion
                        }).ToList<object>();
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }

        public List<Cita> ListarCitasConRecordatorio()
        {
            List<Cita> citas = new List<Cita>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    citas = context.Cita
                        .Where(c => c.tiempoAnticipacion != null
                                 && (c.estado == "Pendiente" || c.estado == "Reprogramado")).ToList();
                }
                return citas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return citas;
            }
        }
        public int ContarCitasHoy(int idEspecialista)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime hoy = DateTime.Today;

                    int cantidad = (from ci in context.Cita
                                    join ca in context.Caso
                                        on new { ci.nroCaso, ci.idCliente }
                                        equals new { ca.nroCaso, ca.idCliente }
                                    where ca.idEspecialista == idEspecialista &&
                                          ci.fecha == hoy
                                    select ci)
                                    .Count();

                    return cantidad;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public List<object> ListarCitasPendientesPorEspecialista(int idEspecialista)
        {
            List<object> lista = new List<object>();

            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    DateTime fechaActual = DateTime.Now.Date;
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;

                    lista = context.Cita
                        .Where(c =>
                            c.Caso.idEspecialista == idEspecialista &&
                            (c.estado == "Pendiente" || c.estado == "Reprogramado") &&
                            (
                                c.fecha > fechaActual ||
                                (c.fecha == fechaActual && c.horaInicio >= horaActual)
                            ))
                        .OrderBy(c => c.fecha)
                        .ThenBy(c => c.horaInicio)
                        .Select(c => new
                        {
                            IdCita = c.idCita,
                            NroCaso = c.nroCaso,
                            DNICliente = c.Caso.Cliente.dni,
                            Cliente = c.Caso.Cliente.nombre + " " + c.Caso.Cliente.apellido,
                            Fecha = c.fecha,
                            HoraInicio = c.horaInicio,
                            HoraFin = c.horaFin,
                            Estado = c.estado,
                            Modalidad = c.modalidad,
                            ConfirmacionAsistencia = c.confirmacionAsistencia
                        })
                        .ToList<object>();
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return lista;
            }
        }
    }
}

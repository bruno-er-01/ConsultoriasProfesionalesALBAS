using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEspecialista
    {
        public string Registrar(int idUsuario, int idArea, bool disponible)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Especialista especialista = new Especialista
                    {
                        idEspecialista = idUsuario,
                        idArea = idArea,
                        disponible = disponible
                    };

                    context.Especialista.Add(especialista);
                    context.SaveChanges();
                }

                return "Especialista registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar especialista: " + ex.Message;
            }
        }
    }
}

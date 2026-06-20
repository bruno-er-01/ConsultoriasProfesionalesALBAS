using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAdministrador
    {
        public String Registrar(int idUsuario)
        {
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    Administrador administrador = new Administrador
                    {
                        idAdministrador = idUsuario
                    };
                    context.Administrador.Add(administrador);
                    context.SaveChanges();
                }
                return "Administrador registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar administrador: " +  ex.Message;
            }
        }
    }
}

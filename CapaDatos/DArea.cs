using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DArea
    {
        public List<Area> ListarTodo()
        {
            List<Area> areas = new List<Area>();
            try
            {
                using (var context = new BD_ALBASEntities1())
                {
                    return context.Area.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return areas;
            }
        }
    }
}

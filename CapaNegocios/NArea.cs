using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NArea
    {
        private DArea dArea = new DArea();

        public List<Area> ListarTodo()
        {
            return dArea.ListarTodo();
        }
    }
}

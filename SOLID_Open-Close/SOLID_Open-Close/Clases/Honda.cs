using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Close.Clases
{
    internal class Honda : Vehiculo
    {
        public override string obtenerNombre()
        {
            return "Honda";
        }
        public override int obtenerValor()
        {
            return 30000;
        }
    }
}

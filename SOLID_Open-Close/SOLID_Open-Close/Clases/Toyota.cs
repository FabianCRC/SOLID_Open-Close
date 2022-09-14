using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Open_Close.Clases
{
    internal class Toyota : Vehiculo
    {
        public override string obtenerNombre()
        {
            return "Toyota";
        }

        public override int obtenerValor()
        {
            return 40000;
        }
    }
}

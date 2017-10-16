using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    class Napolitana : Pizza
    {
        public override string Nombre
        {
            get
            {
                return "Napolitana";
            }
        }

        public override double Costo()
        {
            return 2000;
        }
    }
}

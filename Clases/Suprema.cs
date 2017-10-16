using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    class Suprema : Pizza
    {
        public override string Nombre
        {
            get
            {
                return "Suprema";
            }
        }

        public override double Costo()
        {
            return 2500;
        }
    }
}

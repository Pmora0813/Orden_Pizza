using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    class Vaquera : Pizza
    {
        public override string Nombre
        {
            get
            {
                return "Vaquera";
            }
        }

        public override double Costo()
        {
            return 3000;
        }
    }
}

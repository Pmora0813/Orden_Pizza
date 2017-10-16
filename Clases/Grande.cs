using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    class Grande : Itamanno
    {
        public string Nombre
        {
            get
            {
                return "Grande";
            }
        }

        public double Costo
        {
            get
            {
                return 4;
            }
        }
    }
}

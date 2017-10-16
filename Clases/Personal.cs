using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza

{
    class Personal : Itamanno
    {
        public string Nombre
        {
            get
            {
                return "Personal";
            }
        }
            
        public double Costo
        {
            get
            {
                return 1;
            }
        }
    }
}

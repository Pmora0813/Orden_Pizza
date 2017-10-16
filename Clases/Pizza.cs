using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    abstract class Pizza
    {
        abstract public string Nombre { get; }

        abstract public double Costo();
    }
}

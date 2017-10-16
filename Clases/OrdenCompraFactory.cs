using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza

{
    class OrdenCompraFactory 
    {
        public static OrdenCompra CrearOrden(int cant, Pizza pizza, Pasta pasta, Itamanno tamanno)
        {
            OrdenCompra orden = null;

            orden = new OrdenCompra(cant, pizza, pasta, tamanno);

            return orden;
        }
    }
}

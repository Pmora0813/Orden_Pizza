using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenPizza
{
    class OrdenCompra
    {
        private int cantidad { get; set; }
        private Pizza Pizza { get; set; }
        private Pasta Pasta { get; set; }

        private Itamanno Tamanno { get; set; }
        private List<Extras> Lista_Extras { get; set; }

        public OrdenCompra(int cant, Pizza pizza, Pasta pasta, Itamanno tamanno)
        {
            this.cantidad = cant;
            this.Pizza = pizza;
            this.Tamanno = tamanno;
            this.Pasta = pasta;
            Lista_Extras = new List<Extras>();

        }


        public double CalcularTotal()
        {
            double precio;

            precio =( Pizza.Costo()+ (int)Pasta ) * Tamanno.Costo + calculaCostoExtras();

            return precio;

        }

        public void Add_Extras(Extras ext)
        {
            this.Lista_Extras.Add(ext);
        }

        public double calculaCostoExtras()
        {
            double costo = 0;
            foreach (Extras xt in Lista_Extras)
            {
                costo += (int)xt;
            }

            return costo;
        }
    }
}

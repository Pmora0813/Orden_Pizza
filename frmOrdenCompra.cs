using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenPizza
{
    public partial class Form1 : Form
    {
        OrdenCompra orden;
        public Form1()
        {
            InitializeComponent();
            llenarComboPasta();
            llenarComboTipo();
        }

        public void llenarComboTipo()
        {
            cmbTipo.Items.Add("Suprema");
            cmbTipo.Items.Add("Napolitana");
            cmbTipo.Items.Add("Vaquera");
        }

        public void llenarComboPasta()
        {
            cmbPasta.Items.Add(Pasta.Delgada);
            cmbPasta.Items.Add(Pasta.Gruesa);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = (int) npdCantidad.Value;

            Itamanno tamanno = null;

            Pasta pasta = (Pasta)this.cmbPasta.SelectedItem;

            Pizza pizza = null;
            

            if(cmbTipo.SelectedIndex== 0)
            {
                pizza = new Suprema();
            }
            else
            {
                if(cmbTipo.SelectedIndex == 1)
                {
                    pizza = new Napolitana();
                }
                else
                {
                    pizza = new Vaquera();
                }
            }

            if (rbtnPersonal.Checked)
            {
               
             tamanno = new Personal(); 
            }
            else
            {
                if (rbtnMediana.Checked)
                {
                    tamanno = new Mediana();
                }
                else
                {
                    if (rbtnGrande.Checked)
                    {
                        tamanno = new Grande();
                    }
                }
            }


           orden = OrdenCompraFactory.CrearOrden(cantidad, pizza, pasta, tamanno);
            
            if (chkChile.Checked)
            {
                orden.Add_Extras(Extras.Chile);
            }
            if (chkEnsalada.Checked)
            {
                orden.Add_Extras(Extras.Ensalada);
            }

            if (chkQueso.Checked)
            {
                orden.Add_Extras(Extras.Queso);
            }


            txtCalcularTotal.Text = orden.CalcularTotal().ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.xml";
            if (orden != null)
            {
                orden.guardar(ruta);
                orden.trasformarXMLaHTMl();
            }
            else
            {
                MessageBox.Show("No se a guardado la Orden");
                return;
            }
        }
    }
    
}

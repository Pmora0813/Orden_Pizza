using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

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

        public void guardar(String ruta)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<ORDEN></ORDEN>");

            XmlElement nPIZZA = xmlDoc.CreateElement("PIZZA");
            

            XmlElement nCANTIDAD = xmlDoc.CreateElement("CANTIDAD");
            nCANTIDAD.InnerText = this.cantidad.ToString();

            XmlElement nTIPO = xmlDoc.CreateElement("TIPO");
            nTIPO.InnerText = this.Pizza.Nombre.ToString();

            XmlElement nPASTA = xmlDoc.CreateElement("PASTA");
            nPASTA.InnerText = this.Pasta.ToString();

            XmlElement nTAMANNO = xmlDoc.CreateElement("TAMANNO");
            nTAMANNO.InnerText = this.Tamanno.Nombre.ToString();

            XmlElement nAdicionales = xmlDoc.CreateElement("ADICIONALES");

            foreach (Extras ad in this.Lista_Extras)
            {
                int costo = (int)ad;
                XmlElement nEXTRA = xmlDoc.CreateElement("EXTRAS");
                nEXTRA.SetAttribute("NOMBRE", ad.ToString());

                XmlElement nCosto = xmlDoc.CreateElement("COSTO");
                nCosto.InnerText = costo.ToString();

               

                nAdicionales.AppendChild(nEXTRA);
                nEXTRA.AppendChild(nCosto);
            }
            XmlElement ntotal = xmlDoc.CreateElement("TOTAL");
            ntotal.InnerText = CalcularTotal().ToString("#,##0.00");

            xmlDoc.DocumentElement.AppendChild(nPIZZA);
            nPIZZA.AppendChild(nCANTIDAD);
            nPIZZA.AppendChild(nTIPO);
            nPIZZA.AppendChild(nPASTA);
            nPIZZA.AppendChild(nTAMANNO);
            xmlDoc.DocumentElement.AppendChild(nAdicionales);
            xmlDoc.DocumentElement.AppendChild(ntotal);

            xmlDoc.Save(ruta);
        }


        public void trasformarXMLaHTMl()
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("C:\\Users\\pmora_000\\Source\\Repos\\Orden_Pizza\\Xslt\\Orden_Pizza.xslt");
            // Transforma el archivo xml aun archivo HTML
            string rutaXML = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.xml";

            string rutaHTML = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.html";

            myXslTrans.Transform(rutaXML, rutaHTML);

            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.Arguments = rutaHTML;
            info.FileName = "chrome.exe";
            proceso.StartInfo = info;
            proceso.Start();




        }
    }
}

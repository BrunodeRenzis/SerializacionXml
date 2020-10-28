using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializarHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<Animal> animales = new List<Animal>();
                animales.Add(new PatoDelCampo("Lucas", 2));
                animales.Add(new PalomaDeCiudad("Eze", 2, "Blanca"));

                using (XmlTextWriter textW = new XmlTextWriter("animal.xml",Encoding.UTF8))
                {
                    XmlSerializer escritorArchivo = new XmlSerializer(typeof(List<Animal>));
                    escritorArchivo.Serialize(textW, animales); //textW crea el archivo y grab en el la lista de animales mediante el escritor de archivo.

                }

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}

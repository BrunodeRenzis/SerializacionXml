using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace SerXml
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "unPerro.xml";
                List<Perro> listaPerros = new List<Perro>();
                listaPerros.Add(new Perro("Pepe peposo", "ruf ruf"));
                listaPerros.Add(new Perro("Carola Peposa", "raf raf"));
                listaPerros.Add(new Perro("Jazmin Rufosa", "ruf ruf"));
                listaPerros.Add(new Perro("Ayudante de santa", "ruf ruf"));

                //Escribir daatos
                using(XmlTextWriter auxArchivo = new XmlTextWriter(rutaArchivo,Encoding.UTF8))//El segundo parámetro es la codificación
                {
                    XmlSerializer auxEscritor = new XmlSerializer(typeof(List<Perro>));
                    auxEscritor.Serialize(auxArchivo,listaPerros);
                }

                //Leer datos
                List<Perro> listaVacia = new List<Perro>();

                using(XmlTextReader auxArchivoALeer = new XmlTextReader(rutaArchivo)) //Va a localizar el archivo y lo va a abrir para leerlo.
                {
                    XmlSerializer auxLector = new XmlSerializer(typeof(List<Perro>));
                    listaVacia = (List<Perro>)auxLector.Deserialize(auxArchivoALeer);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

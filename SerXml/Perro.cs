using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerXml
{
    [Serializable]
    public class Perro
    {
        string raza;
        string nombre;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }

        public Perro()
        {

        }

        public Perro(string nombre, string raza)
        {

        }

        public override string ToString()
        {
            return "Nombre " +  nombre + "Raza " +raza;
        }
    }
}

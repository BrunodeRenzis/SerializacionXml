using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarHerencia
{
    [Serializable]
    public class PalomaDeCiudad: Animal
    {
        public string color;
        public PalomaDeCiudad(string nombre, float pesoEnKg, string color):base(nombre,pesoEnKg)
        {
            this.color = color;
        }
        public PalomaDeCiudad()
        {
          
        }
    }
}

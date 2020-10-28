using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializarHerencia
{
    [Serializable] //Esto no lo heredan las clases q hereden de animal.
    [XmlInclude(typeof(PatoDelCampo))] //Señalo cuales son los tipos a ser serializados
    [XmlInclude(typeof(PalomaDeCiudad))] //Si alguna clase hereda de animal y no tiene esta etiqueta en la clase padre, no puede serializarse ()no serializa los atributos del padre.
    public abstract class Animal
    {
        public string nombre;
        public float pesoEnKg;

        public Animal(string nombre,float pesoEnKg)
        {
            this.nombre = nombre;
            this.pesoEnKg = pesoEnKg;
        }
        public Animal()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre es {this.nombre}");
            sb.AppendLine($"El peso es {this.pesoEnKg}");
            return sb.ToString(); 
        }


    }
}

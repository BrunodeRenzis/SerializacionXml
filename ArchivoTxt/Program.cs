using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivoTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFile;

            try
            {
                rutaFile = AppDomain.CurrentDomain.BaseDirectory + "ArchivoEjemplo.txt";

                using (StreamWriter auxSw= new StreamWriter(rutaFile,true)) //auxSw no vive fuera de este scope
                {
                    auxSw.WriteLine("Hola mundo");
                    //auxSw.Close(); no es necesario ya que está dentro del using 
                }
                Console.WriteLine("Archivo escrito");
                Console.ReadKey();

                string infoLeida = "";

                rutaFile = AppDomain.CurrentDomain.BaseDirectory + "ArchivoTexto2.txt";

                if (File.Exists(rutaFile))
                {
                    using (StreamReader auxSr = new StreamReader(rutaFile))
                    {
                        string lineaLeida = string.Empty;

                        while ((lineaLeida = auxSr.ReadLine()) != null)
                        {
                            Console.WriteLine(lineaLeida);
                            infoLeida += lineaLeida + "\n";
                        }
                    }

                    Console.WriteLine("Archivo leido en su totalidad");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

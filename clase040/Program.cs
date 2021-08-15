using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase040
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
           
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿ Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i=0;i<numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;

            }

            return datos;
        }
    }
}

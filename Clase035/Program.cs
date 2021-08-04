using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase035
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            double raiz = Sqrt(9);

            double potencia = Pow(3, 4);

            Console.WriteLine(raiz);

            Console.WriteLine(potencia);

            // uso de Clases Anonimas

            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.Nombre  + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miOtraVariable;

        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");

        }
    }
}

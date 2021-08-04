using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase033
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase051
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTraficos av1 = new AvisosTraficos();

            av1.mostrarAviso();

            AvisosTraficos av2 = new AvisosTraficos("Jefatura Provincial Madrid", "Sanción de velocidad: 300$", "18/08/2021");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();


        }
    }
}

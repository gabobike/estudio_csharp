using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase032
{
    class Punto
    {
        public Punto(int x, int y)
        {

            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");

        }

        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto");
        }
    }
}

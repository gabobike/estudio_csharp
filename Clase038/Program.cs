using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase038
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array implicito

            // var datos = new[] { "Juan", "Diaz", "España" };

            var valores = new[] { 15, 28, 35, 75.5, 30.3 }; // pasa todo a double 

            // Array de objetos

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            arrayEmpleados[1] = Ana;

            // array de tipos o clases anónimas

            var persona = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="maria", Edad=19},

                new{Nombre ="Diana", Edad= 35}
            };

            for(int i=0; i<=4; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }

    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;

            this.edad = edad;

        }

        String nombre;

        int edad;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase039
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array implicito

            // var datos = new[] { "Juan", "Diaz", "España" };

            var valores = new[] { 15, 28, 35, 75.5, 30.3 , 100 , 35.4}; // pasa todo a double 

            // Array de objetos

            Empleados Ana = new Empleados("Ana ", 27);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara ", 37);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel ", 51);

            // array de tipos o clases anónimas

            var persona = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="maria", Edad=19},

                new{Nombre ="Diana", Edad= 35}
            };

            /*for (int i = 0; i <arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }*/

            foreach(double variable in valores)
            {
                Console.WriteLine(variable);
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

        public String getInfo()
        {
            return "Nombre del empleado: " + nombre + "Edad: " + edad;
        }

        private String nombre;

        private int edad;
    }
}


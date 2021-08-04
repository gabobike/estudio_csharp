using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase037
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array implicito

            // var datos = new[] { "Juan", "Diaz", "España" };

            var valores = new[] { 15, 28, 35, 75.5, 30.3 }; // pasa todo a double 

            // Array de objetos

            Empleados[] arrayEmpleados = new Empleados[2];
            


        }
    }

    class Empleados
    {
        public Empleados(string nombre , int edad)
        {
            this.nombre = nombre;

            this.edad = edad;

        }

        String nombre;

        int edad;
    }
}

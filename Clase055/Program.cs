using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase055
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            Juan.SALARIO = 1200;

            Juan.SALARIO += 500;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);

        }
    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        /* public void setSalario(double salario)
        {
            if (salario < 0)
            {

                Console.WriteLine("El salario no puede ser negativo. Se asignara 0 como salario");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }

        }*/                               

        /*public double getSalario()
        {
            return salario;
        }*/

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        }

        // Creación de PROPIEDAD

        public double SALARIO
        {
            get { return this.salario; }

            set { this.salario = evaluaSalario(value); }
        }

        private double salario;

        private string nombre;
    }
}

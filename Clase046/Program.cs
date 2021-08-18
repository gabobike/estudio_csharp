using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase046
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano(" Juan");

            Gorila Copito = new Gorila("Copito");

            // aplicando metodo de sustitucion

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;

            almacenAnimales[1] = Juan;

            almacenAnimales[2] = Copito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamiferos miMamifero = new Mamiferos("");

            

            /*Mamiferos animal = new Mamiferos("Bucéfalo");

            Caballo Bucefalo = new Caballo("Bucéfalo");

            animal = Bucefalo;*/

            /*Juan.getNombre();

            Babieca.getNombre();

            Copito.getNombre();*/


        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        protected void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {

            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");

        }

        public void getNombre()
        {
            Console.WriteLine("El nombre  del ser vivo es:" + nombreSerVivo);
        }

        private String nombreSerVivo;

    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

            respirar();
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}

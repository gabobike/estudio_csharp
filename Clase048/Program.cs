using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase048
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

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("Numero de patas de Babieca: " + Babieca.numeroPatas());


        }
    }

interface IMamiferosTerrestre //por conveccion el nombre de las interfaces comienzan con I mayuscula
    {
        int numeroPatas(); // los metodos no llevan modificar de acceso 
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

    class Ballena: Mamiferos
    {
        public Ballena(String nombreBallena): base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }


    }

    class Caballo : Mamiferos, IMamiferosTerrestre // primero va la clase y despues la interfaces
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

            // respirar();
        }

        public int numeroPatas()
        {
            return 4;
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

    class Gorila : Mamiferos, IMamiferosTerrestre
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

        public int numeroPatas()
        {
            return 2;
        }
    }
}

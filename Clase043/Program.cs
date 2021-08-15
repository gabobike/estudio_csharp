﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase043
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano(" Juan");

            Gorila Copito = new Gorila("Copito");

            Juan.getNombre();

            Babieca.getNombre();

            Copito.getNombre();


        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
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
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano): base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila): base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}

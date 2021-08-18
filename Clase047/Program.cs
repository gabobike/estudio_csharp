using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase047
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avion");

            Avion miAvion = new Avion();

            miAvion.ArrancaMotor("dale papa arranca ese avion");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("ploooof");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancaMotor("greeeemm greeeemmmm dale viejaaaaa");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("bluuuufffffff");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en acción!");

            Vehiculo miVehiculo = miCoche; // principio de sustitución

            miVehiculo.Conducir(); // aca vemos el polimorfismo

            miVehiculo = miAvion;

            miVehiculo.Conducir();// aca vemos el polimorfismo

        }
    }

}

# Curso C#. Arrays V. Clase 40

En esta clase veremos

- Arrays como párametros de métodos
- Arrays como devolución de métodos(return)

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase040
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);


        }

        static void ProcesaDatos(int [] datos)
        {
            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }

        }
    }
}

```

Otro metodo

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase040
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }


        }

        static void ProcesaDatos(int [] datos)
        {
            for (int i=0; i<4 ; i++)
            {
                datos[i] += 10;
            }

        }
    }
}
```

metodo que devuelve un array

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase040
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos) Console.WriteLine(i);
           
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿ Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i=0;i<numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;

            }

            return datos;
        }
    }
}
```




# ¿Qué es .NET?

Cuando una persona usa el término *.NET*, lo que quiere decir  depende en gran medida del contexto. En esta unidad, obtendrá  información sobre .NET, abordándolo como un ecosistema.  En otras  palabras, descubrirá que .NET es una colección de muchos elementos y  personas que, de forma conjunta, crean un entorno eficaz para la  compilación de aplicaciones.

Sugerencia 

A veces, las personas piensan equivocadamente que el lenguaje de programación C# *es* .NET. Sin embargo, C# y .NET son distintos. C# es una sintaxis de  lenguaje de programación. Como parte de la sintaxis, puede hacer  referencia y llamar a métodos definidos en bibliotecas de código .NET, o ensamblados. Además, para crear un ensamblado a partir del código de  C#, se usa el compilador de C# que se instala con el SDK de .NET. El  entorno de ejecución de .NET ejecuta ensamblados de .NET. Entender estas distinciones le ayudará a asimilar conceptos importantes conforme vaya  aprendiendo más sobre .NET y C#.











Clase 01

## Identificadores

Los identificadores son los nombres que se usan para identificar los elementos de tus programas:

- Namespaces
- Clases
- Metodos
- Variables
- Constantes

### Convenciones para nombrar identificadores:

Solo se pueden usar letras(mayusculas y minusculas), numeros y guiones bajos.

Deben comenzar por una letra o guion bajo

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}			
```

clase 04 Sistaxis basica II

Tipos de datos

Variables: declaracion e iniciacion

Convenciones y buenas practicas con variables

Tipos de Datos

![](/home/y3rb1t4/Pictures/Screenshot_2021-07-29_02_00_30.png)


## Clase 06


Operador asignacion "=" 



```c#
using System;

namespace PrimerAplicacion
{
    class Program
    {
        static void Main(strigs[] args)
        {
            /* int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;
            
            edadPersona1 = edadPersona2 = edadPersona 3 = edad Persona =27;
            
            Console.WriteLine(edadPersona4);*/
                int edadPersona1, edadPersona2, edadPersona3; edadPersona4 =27;

			edadPersona2=35;
            
        }
    }
}


```



### conversion explicita e implicita


Declaracion implicita de variables 

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
			double temperatura = 34.5;
            
            int temperaturaMadrid;
            
            //conversion explicita
            // casting
            
            temperaturaMadrid = (int) temperatura;
            
            // conversion implicita
            
			int habitantesCiudad = 100000000;
			
            long habitantesCiudad2018 = habitantesCiudad;
            
            float pesoMaterial = 5.78F;
            
            double pesoMaterialPrec = pesoMaterial;
            
            Console.WriteLine(pesoMaterialPrec)

            Console.WriteLine(temperaturaMadrid);
 			           
        }
    }
}
```

https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/numeric-conversions

### Convertir valor de texto a valor de numero

los textos (strings) son objetos

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {	
    	static void Main(string[] args)
        {
            Console.WriteLine.("Introduce el primer numero");
            
            Console.ReadLine(); // se queda a la espera para que el usuario introduzca un numero
            
        }
    }
}
```

realizo una suma de dos valores numerico que los introduzco por consola.

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {	
    	static void Main(string[] args)
        {
            Console.WriteLine.("Introduce el primer numero");
            
            int num1=int.Parse(Console.ReadLine());
            
            Console.WriteLine(" Introduce el segundo numero ");
            
            int num2 = int.Parse(Console.ReadLine())
                
            Console.WriteLine("El resultado es " + (num1 + num2));
            
        }
    }
}
```



Definicion y uso de constantes

Variables vs Constantes

Variables 

Espacion en la memoria del ordenador donde se almacenara un valor que podria cambiar durante la ejecucion del programa 

Constantes 

Espacio en la memoria del ordenador doden se almacenara un valor que no podra cambiar durante la ejecucion del programa.

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR = 5;
            
            const int VALOR2 = 7;
            
            Console.WriteLine("El valor de la constante{0}" , VALOR );
            
        }
    }
}
```

### Uso de Constantes (Video 8)

```c#
using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
        	const double PI = 3.1416
            
            Console.WriteLine("Introduce la medida del radio");
            
            double radio = double.Parse(Console.ReadLine());
            
            // double area = radio * radio * PI;

			double area = Math.Pow(radio,2)*PI
            
            Console.WriteLine($"El area del circulo es: {area}");
            
            
        }
    }
}
```

### Metodos

- que son los metodos ? 
- para que sirver ? 
- cual es su sintaxis ?

-Los metodos son un grupo de sentencias(instruccciones) a las que se da un nombre identificativo, que realizan una tarea en concreto.

-Sirven para realizar una tarea en concreto en un momento determinado. Un metodo no realiza su tarea hasta que no es llamado.

-Su sintaxis Tipodevuelto nombreMetodo(parametros) {

​	cuerpo del metodo

}

**un metodo void nunca llevara return**

<p>Los metodos en C# 
	<ul>
    <li>Declaracion y llamada a metodo void</li>
    <li>Paso de parametros</li>
    </ul>
</p>

en esta parte vamos a ver de generar dos metodos dentro de una clase

```c#
using System;
namespace Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPatalla();
            
            Console.WriteLine("Mensaje desde el main");
            
            mensajeEnPantalla();
            
        }
        
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        }
    }
}
```

Otra forma

```c#
using System;

namespace Practica_Modulos
```

Metedos "return"

```c#
using System;

namespace Practica_metodoreturn
{
    class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(7,9)
        }
        
        static int sumaNumeros(int num1, int num2)
        {
            //Cosole.WriteLine($"La suma de los numeros es : {num1 + num2}");
            return num1 + num2;
          
        }
    }
}
```



Si queremos que el resultado salga por consola 

```c#
using System;

namespace Practica_metodoreturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(7,9));
        }
        
        static int sumaNumeros(int num1, int num2)
        {

            return num1 + num2;
          
        }
    }
}
```

Recomendacion ver modularizacion

un metodo tiene q ser sencillo y se tiene q ver en una pantalla sin hacer scroll



#Metodo de Ambito o alcance de metodos y variables 





Sobrecarga de metodos





## Constructores (Video 30)

Creamos un proyecto nuevo que se llame uso coches

```c#
using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto/ instancia de tipo coche
            // dat un estado inicial a nuestro coche 
            
            Coche coche2 = new Coche();
            
            
        }
    }
}

class Coche 
{
	public Coche() // esto es un constructor 
    {
        ruedas = 4;
        
        largo = 2300.5
        
        ancho = 0.800;
    }
    
    private int ruedas;
    
    private double largo;
    
    private double ancho;
    
    private bool climatizador;
    
    private String tapiceria;
    
}
```

## POO Getters y Setters (Video31)



this , cuando me refiero a un cambio de clase o un parametro

this.climatizador = climatizador;

hace referencia al campo de clase , a la propia clase

Utilidad del lenguaje c# y visual studio , es dividir una clase en trozos.

usar la palabra reservada partial

partial class coche {

}

## POO VI. Visual Studio y POO. Vídeo 32

Concepto de Modularizacion



##  POO VII. Llamadas y clase Math. Vídeo 33


















# Interfaz en c#



## Introduccion

Las interfaces en la programación POO son un tema misterioso. Cada programador experimentado al que preguntes te dará una explicación un poco diferente, que depende de su campo de experiencia y de su uso de este tema. El patrón más común en estas respuestas es que la interfaz es un concepto de abstracción y encapsulación. Veamos este tema a través del concepto de un longboard eléctrico y su controlador. 

## The Controller and the Longboard

Este dispositivo tiene un pequeño controlador con dos botones y un interruptor giratorio. Un botón sirve para encender y apagar, el otro pone el motor en marcha atrás (cambiando realmente el flujo de la corriente). El interruptor giratorio acelera la tabla si se empuja hacia arriba y frena las ruedas si se empuja hacia abajo. La aceleración y la desaceleración son proporcionales a la longitud de la rotación alrededor de la circunferencia del interruptor, ya que puede afinar la velocidad del vehículo.

## The Controller Box

La caja actual que tenemos, es decir, el controlador, define entradas específicas que puede procesar y tienen un resultado como la salida que se produce para una entrada determinada. Al igual que el encendido, apagado, aceleración, desaceleración, etc. Algunos casos raros también especifican los tipos de retorno. En nuestro ejemplo, el tipo de retorno no es relevante ya que sólo queremos controlar el estado de la placa.

> Estas interfaces no tienen ninguna restricción sobre la semántica de estas operaciones. Es una buena práctica aceptada documentarlas en proximidad y elegir buenas convenciones de nomenclatura.

Para ser más específicos, sólo podemos acelerar o desacelerar una tabla si está encendida. Esto se basa en la suposición de que nuestra tabla sólo será impulsada por el motor eléctrico, y no en una bajada. Las ruedas pueden girar incluso cuando está apagada, pero los frenos sólo funcionan si el motor está encendido.

## Criteria for the Demo

Estas son algunas de las reglas en las que se basa la demostración:

1. No se puede encender el dispositivo dos veces.
2.  No se puede apagar el dispositivo dos veces.
3. Sólo puedes apagar el dispositivo si está quieto.
4. Sólo puedes acelerar un dispositivo encendido, y sólo hasta que alcance la velocidad máxima especificada en la inicialización.
5. Sólo puede desacelerar un dispositivo hasta que se detenga.

## IControllable

Existe la convención de anteponer a las interfaces el carácter I, que marca claramente la intención y ayuda al programador a entender mejor el código.

Este es el aspecto de nuestra definición de interfaz:

```c#
namespace InterfaceTutorial
{
    interface IControllable
    {
        string State { get; set; }
        void Accelerate();
        void Decelerate();
    }
}
```

Tenemos una propiedad estatal expuesta y el contrato de las funciones Acelerar y Desacelerar.

En esta demostración, estamos reuniendo todo bajo el espacio de nombres InterfaceTutorial para que sea más fácil de referenciar.

## Vehicle

Esta clase implementa las interacciones con nuestro dispositivo. La definición de la clase muestra la interfaz que permite la interacción.

```c#
class Vehicle : IControllable
```

Tenemos un constructor que inicializa el tablero con parámetros por defecto, en caso de que sean lo suficientemente buenos.

```c#
public Vehicle(string name = "No Name", int maxspeed = 0, int speed = 0, string state = "off")
	{
    	BoardName = name;
		MaxSpeed = maxspeed;
		Speed = speed;
		State = state;
	}
```

Tenemos cuatro propiedades expuestas.

```c#
    public string BoardName { get; set; }

    public int MaxSpeed { get; set; }

	public int Speed { get; set; }    

	public string State { get; set; }
```

Veamos nuestro método PowerOn. Como los criterios están establecidos, sólo permitimos el encendido una vez.

```c#
public void PowerOn()
    {
		if(State == "on")
        	{ Console.WriteLine($"The board: {BoardName} is already ON!"); }
		else
			{
				State = "on";
				Console.WriteLine($"Powering ON the Board: {BoardName}, currently at {Speed} MPH!");
			}            
	}
```

El apagado también cumple con las expectativas. El criterio de no apagar el tablero dos veces y no se nos permite apagar el vehículo en movimiento.

```c#
public void PowerOff()
	{
		if(State == "off")
			{ Console.WriteLine($"The board: {BoardName} is already OFF!"); }
		else { 
			if(Speed > 0)
				{ Console.WriteLine($"You are not allowed to Power OFF a moving board: {BoardName}"); }
			else {
				State = "off";
				Console.WriteLine($"Powering OFF the board: {BoardName}, currently at {Speed} MPH!");
				}
			}
	}
```

Las funciones de aceleración y desaceleración son muy similares en este sentido. Ambas restringen las acciones a un dispositivo encendido, y el cambio de velocidad se mantiene entre 0 y la velocidad máxima especificada en el momento de la instanciación.

```c#
 public void Accelerate()
	{
		if(State == "off")
			{ Console.WriteLine($"The board needs to be turned on to pick up speed!"); }
		else
			{
			if (Speed < MaxSpeed)
				{
					Speed += 10;
					Console.WriteLine($"The {BoardName} accelerates towards {Speed} MPH!");
				}
			else
				{ Console.WriteLine($"The {BoardName} reached it's speed limit, continue journey at {MaxSpeed} MPH!");  }
			}            
	}

 public void Decelerate()
	{
		if (State == "off")
			{ Console.WriteLine($"The {BoardName} is currently {State}, please dont use it this way as the breaks are not functional!"); }
		else
			{
			if(Speed <= 0)
				{
					Console.WriteLine($"The {BoardName} has lost all it's speed, came to a halt!");
				}
			else
				{
					Speed -= 10;
					Console.WriteLine($"The {BoardName} decelerates towards {Speed} MPH!");
				}
			}
	}
```

Este código de las secciones necesita ser envuelto dentro del siguiente bloque de código. De lo contrario, habrá que ajustar nuestras llamadas para que funcionen correctamente.

```c#
using System;

namespace InterfaceTutorial
{
}
```

## Prueba de manejo

Ahora que hemos completado nuestra demostración acerca de cómo se puede utilizar su interfaz para controlar el tablero. Primero, creamos la instancia del Vehículo. Esta toma dos argumentos; el primero es el nombre que queremos usar y el segundo es la velocidad máxima. Tenga en cuenta que, durante la inicialización, este valor es 0. Por lo tanto, si usted no especifica el límite, no puede montar la tabla.

```c#
using System;

namespace InterfaceTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle meepo = new Vehicle("Meepo V2", 40);

            if (meepo is IControllable)
            {
                meepo.Decelerate();
                meepo.PowerOn();
                meepo.PowerOn();
                meepo.Accelerate();
                meepo.Accelerate();
                meepo.PowerOff();
                meepo.Accelerate();
                meepo.Accelerate();
                meepo.Accelerate();
                meepo.Decelerate();
                meepo.Decelerate();
                meepo.Decelerate();
                meepo.Decelerate();
                meepo.Decelerate();
                meepo.PowerOff();
                meepo.PowerOff();
            }
            else
            {
                Console.WriteLine($"The {meepo.BoardName} can't be driven");
            }
            Console.ReadLine();
        }
    }
}
```

A continuación, comprobaremos si el dispositivo implementa los contratos necesarios y lo sacaremos a pasear.

La ejecución de la solución producirá este resultado:

```c#
The Meepo V2 is currently off, please don’t use it this way as the breaks are not functional!

Powering ON the Board: Meepo V2, currently at 0 MPH!

The board: Meepo V2 is already ON!

The Meepo V2 accelerates towards 10 MPH!

The Meepo V2 accelerates towards 20 MPH!

You are not allowed to Power OFF a moving board: Meepo V2

The Meepo V2 accelerates towards 30 MPH!

The Meepo V2 accelerates towards 40 MPH!

The Meepo V2 reached its speed limit, continue journey at 40 MPH!

The Meepo V2 decelerates towards 30 MPH!

The Meepo V2 decelerates towards 20 MPH!

The Meepo V2 decelerates towards 10 MPH!

The Meepo V2 decelerates towards 0 MPH!

The Meepo V2 has lost all its speed, came to a halt!

Powering OFF the board: Meepo V2, currently at 0 MPH!

The board: Meepo V2 is already OFF!
```

Observe, como antes, que al llamar por primera vez a la función **PowerOn()** tenemos una advertencia diciendo que los descansos no funcionarán.

Después de que se produzca el encendido, somos capaces de acelerar, entonces se impide una llamada a **PowerOff()** porque el dispositivo no está quieto. Entonces aceleramos un poco más y, finalmente, alcanzamos el límite y desaceleramos hasta detenernos. La llamada a **PowerOff()** dos veces también es manejada por nuestra interfaz.

## Conclusiones:

Esta demostración le mostró el ejemplo de implementación de una interfaz que le permitía controlar un tablero. Naturalmente, esto podría ser utilizado por cualquier clase que implemente los detalles necesarios del contrato. La demostración también puso de manifiesto cómo funcionan en tándem y te dio algunas ideas en cuanto a la extensión de esta funcionalidad. Te he mostrado algunos manejos de errores semánticos que te serán útiles para tus futuros proyectos.

En definitiva, al igual que un coche una interfaz te ayuda a interactuar con tu entorno reduciendo o controlando los tipos de entrada que un sistema puede tomar y te da las salidas esperadas. Cuando giras el volante a la izquierda, el coche va a la izquierda, cuando lo giras a la derecha, va a la derecha. No tienes que preocuparte por el funcionamiento interno de las cajas de cambio y otras partes de tu coche que permiten este movimiento.

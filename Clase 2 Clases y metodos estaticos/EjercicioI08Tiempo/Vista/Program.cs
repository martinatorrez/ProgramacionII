using System;
using LogicaNegocio;
/* Crear un método estático que reciba una fecha y calcule el número de días 
 que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) 
y calcule el número de días vividos por esa persona hasta la fecha actual 
utilizando el método desarrollado anteriormente.*/
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            string cadenaFecha;
            int cantidadDeDias;
            Console.WriteLine("Ingrese su fecha de nacimiento(dd/mm/aaaa) : ");
            cadenaFecha = Console.ReadLine();
            DateTime.TryParse(cadenaFecha, out fecha);
            cantidadDeDias = Fechas.CalculadorDeDias(fecha);
            Console.WriteLine($"La cantidad de dias vividos hasta hoy es: {cantidadDeDias}");
        }
    }
}

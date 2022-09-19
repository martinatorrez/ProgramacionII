using System;
using LogicaNegocio;
/*Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.*/
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroCadena;
            int numero;
            Console.Write("Ingrese un numero: ");
            numeroCadena = Console.ReadLine();
            int.TryParse(numeroCadena, out numero);

            Console.WriteLine(Tablas.Multiplicador(numero));
            Console.ReadKey();
        }
    }
}

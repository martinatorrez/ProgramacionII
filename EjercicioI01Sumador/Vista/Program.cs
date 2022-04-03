using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);

            Console.WriteLine($"La suma de dos long: {sumador.Sumar(45,2)}");
            Console.WriteLine($"La suma de dos strring: {sumador.Sumar("Hola", "mundo")}");

            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumador + sumadorB);
            Console.WriteLine(sumador | sumadorB);
            Console.WriteLine(sumador | sumadorC);
        }
    }
}

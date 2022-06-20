using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Eestaciones.Otonio.ObtenerPlacaCronicaTV());
            Console.WriteLine(Eestaciones.Invierno.ObtenerPlacaCronicaTV());
            Console.WriteLine(Eestaciones.Primavera.ObtenerPlacaCronicaTV());
            Console.WriteLine(Eestaciones.Verano.ObtenerPlacaCronicaTV());
            Console.ReadKey();
        }
    }
}

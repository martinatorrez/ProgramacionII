using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Martina","27/09/2002",854697);
            Persona personaDos = new Persona("Juan", "23/03/1997", 632145);
            Persona personaTres = new Persona("Marcos", "25/02/2017", 369746);

            Console.WriteLine(Persona.Mostrar(personaUno));
            Console.WriteLine(Persona.EsMayorDeEdad(personaUno));

            Console.WriteLine(Persona.Mostrar(personaDos));
            Console.WriteLine(Persona.EsMayorDeEdad(personaDos));

            Console.WriteLine(Persona.Mostrar(personaTres));
            Console.WriteLine(Persona.EsMayorDeEdad(personaTres));
        }
    }
}

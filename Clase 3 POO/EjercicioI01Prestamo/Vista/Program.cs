using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta = new Cuenta("Pepito", 7600);
            Cuenta otraCuenta = new Cuenta("Coso", 2000);

            Console.WriteLine(nuevaCuenta.Mostrar());
            nuevaCuenta.Ingresar(5000);
            Console.WriteLine(nuevaCuenta.Mostrar());
            nuevaCuenta.Retirar(2000);
            Console.WriteLine(nuevaCuenta.Mostrar());
            Console.WriteLine("");

            Console.WriteLine(otraCuenta.Mostrar());
            otraCuenta.Ingresar(1000);
            Console.WriteLine(otraCuenta.Mostrar());
            otraCuenta.Retirar(4000);
            Console.WriteLine(otraCuenta.Mostrar());
        }
    }
}

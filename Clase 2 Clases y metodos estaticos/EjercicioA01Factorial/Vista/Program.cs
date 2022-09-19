using System;
using System.Text;
using LogicaNegocio;
//En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int numeroFactorizado = Factorizador.Factorizar(numero);
            
            Console.WriteLine($"El numero {numero} factorizado es {numeroFactorizado}");
        }
    }
}

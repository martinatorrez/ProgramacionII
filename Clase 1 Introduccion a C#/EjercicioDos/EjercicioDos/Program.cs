using System;
//Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que
//cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
namespace EjercicioDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroCadena;
            int numero;
            int numeroCuadrado;
            int numeroCubo;
            Console.Write("Ingrese un numero: ");
            numeroCadena = Console.ReadLine();
            int.TryParse(numeroCadena, out numero);
            while (numero < 0) 
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numeroCadena = Console.ReadLine();
                int.TryParse(numeroCadena, out numero);
            }
            numeroCuadrado =(int) Math.Pow(numero, 2);
            numeroCubo = (int)Math.Pow(numero, 3);
            Console.WriteLine("{0} al cuadrado es: {1} y al cubo es {2}", numero, numeroCuadrado, numeroCubo);
            Console.ReadKey();
        }
    }
}

using System;
using LogicaNegocios;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaPrimerOperando;
            string cadenaSegundoOperando;
            float primerOperando;
            float segundoOperando;
            string cadenaOperador;
            char operador;
            char continuar='s';
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Calculadora");

                Console.Write("Ingrese un numero: ");
                cadenaPrimerOperando = Console.ReadLine();
                float.TryParse(cadenaPrimerOperando, out primerOperando);

                Console.Write("Ingrese otro numero: ");
                cadenaSegundoOperando = Console.ReadLine();
                float.TryParse(cadenaSegundoOperando, out segundoOperando);

                Console.Write("Ingrese la operacion que desea realizar (+, -, * o /): ");
                cadenaOperador = Console.ReadLine();
                char.TryParse(cadenaOperador, out operador);

                Console.WriteLine($"El resultado de la operacion es : {Calculadora.Calcular(primerOperando,segundoOperando,operador)}");

                Console.Write("Si desea continuar operando presione 's': ");
                continuar = Console.ReadKey().KeyChar;
            } while (continuar == 's');
        }
    }
}
// faltan validaciones
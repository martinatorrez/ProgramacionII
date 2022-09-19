using System;
using LogicaValidar;
/*Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
 anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

*/
namespace EjercicioUnoValidador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeNumeros = 10;
            string cadenaNumero;
            int numero;
            int maximo = Int32.MinValue;
            int minimo = Int32.MaxValue;
            float promedio = 0;
            for (int i = 0; i < cantidadDeNumeros; i++) 
            {
                Console.WriteLine("Ingrese un numero: ");
                cadenaNumero = Console.ReadLine();
                if(int.TryParse(cadenaNumero, out numero)&& Validador.Validar(numero, -100, 100)) 
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    promedio = (promedio + numero);
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido");
                    i--;
                }
               
            }
            promedio = promedio / cantidadDeNumeros;
            Console.WriteLine("El maximo es: {0} El mínimo es: {1} y el promedio es: {2}", maximo, minimo, promedio);
            Console.ReadKey();

        }
    }
}

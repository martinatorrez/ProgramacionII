using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 5;
            string numeroConsola;
            int numero;
            int maximo=0;
            int minimo=900;
            float promedio=0;
            
            for(int i = 0; i < cantidadNumeros; i++) 
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroConsola = Console.ReadLine();
               
                if (int.TryParse(numeroConsola, out numero)) 
                {
                    
                    if (numero > maximo) 
                    {
                        maximo = numero;
                    }
                    if (numero < minimo ) 
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
            promedio = promedio / cantidadNumeros;
            Console.WriteLine("El maximo es: {0} El mínimo es: {1} y el promedio es: {2}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}

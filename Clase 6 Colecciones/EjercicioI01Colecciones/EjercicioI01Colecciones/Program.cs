using System;

namespace EjercicioI01Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(-1000, 1000);
            }
            Console.Write("Numeros sin ordenar: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("Positivos ordenados en forma decreciente");
            Array.Sort(numeros, CompararDescendente);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0) 
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            Console.WriteLine("Negativos ordenados en forma creciente");
            Array.Sort(numeros, CompararAscendente);
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

        }

       
        //Si A menor a B devuelve un negativo
        //Si A mayor a B devuelve un positivo
        //Si son iguales 0
        public static int CompararDescendente(int a, int b)
        {
            return b - a;
        }
       
        //Si A mayor a B devuelve un negativo
        //Si A menor a B devuelve un positivo
        //Si son iguales 0
        public static int CompararAscendente(int a, int b)
        {
            return a - b;
        }
    }
}

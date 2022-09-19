using System;

namespace Ejercicio6Bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anioInicio;
            string anioFin;
            int anioUno;
            int anioDos;
            Console.Write("Ingrese un año de inicio: ");
            anioInicio = Console.ReadLine();
            int.TryParse(anioInicio, out anioUno);
            Console.Write("Ingrese un año para finalizar: ");
            anioFin = Console.ReadLine();
            int.TryParse(anioFin, out anioDos);
            for (int i = anioUno; i <= anioDos; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto {0}\n", i);
                }
            }
            Console.ReadKey();
        }
    }
}

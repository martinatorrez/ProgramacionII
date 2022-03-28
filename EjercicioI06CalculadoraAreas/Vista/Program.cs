using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaCuadrado = CalculadorDeArea.CalcularAreaCuadrado(4);
            double areaTriangulo = CalculadorDeArea.CalcularAreaTriangulo(3, 5);
            double areaCirculo = CalculadorDeArea.CalcularAreaCirculo(6);
            Console.WriteLine($"El area de un cuadrado de lado 4 es: {areaCuadrado}");

            Console.WriteLine($"El area de un triangulo de base 3 y altura 5 es: {areaTriangulo}");

            Console.WriteLine($"El area de un circulo de radio 6 es: {areaCirculo}");
        }
    }
}

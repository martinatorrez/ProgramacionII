using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaBase;
            double baseTriangulo;
            string cadenaAltura;
            double altura;
            double hipotenusaAlCuadrado;
            double hipotenusa;

            Console.Write("Ingrese la base del triangulo en cm: ");
            cadenaBase=Console.ReadLine();
            double.TryParse(cadenaBase,out baseTriangulo);

            Console.Write("Ingrese la altura del triangulo en cm: ");
            cadenaAltura = Console.ReadLine();
            double.TryParse(cadenaAltura, out altura);

            hipotenusaAlCuadrado = Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2);
            hipotenusa = Math.Sqrt(hipotenusaAlCuadrado);

            Console.WriteLine($"La longitud de la hipotenusa es: {hipotenusa} cm");
            Console.ReadKey();
        }
    }
}

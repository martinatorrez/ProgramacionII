using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(6));
            figuras.Add(new Rectangulo(4, 2));
            figuras.Add(new Cuadrado(5));
            StringBuilder sb = new StringBuilder();

            foreach (Figura figura in figuras) 
            {
                
                sb.AppendLine($"=====================Figura: {figuras.IndexOf(figura) + 1}=====================");
                sb.AppendLine($"Tipo: {figura.GetType()}");
                sb.AppendLine(figura.Dibujar());
                sb.AppendLine($"Area: {figura.CalcularSuperficie()}");
                sb.AppendLine($"Perimetro: {figura.CalcularPerimetro()}");
                sb.AppendLine("============================================");
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}

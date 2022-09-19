using System;
using System.Text;
namespace LogicaNegocio
{
    public class Tablas
    {
        public static string Multiplicador(int numero) 
        {
            int contador = 1;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Tabla de multiplicar del número {numero}:");
            stringBuilder.AppendLine("");
            for (int i = 0; i < 9; i++) 
            {
                stringBuilder.AppendFormat($"{numero} x {contador} = {numero * contador}");
                stringBuilder.AppendLine("");
                contador++;
            }
            
            return stringBuilder.ToString();
        }
    }

}

using System;

namespace LogicaNegocio
{
    public class Fechas
    {
        public static int CalculadorDeDias(DateTime fecha) 
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan fechasDiferentes = fechaActual - fecha;
            int dias = fechasDiferentes.Days;
            return dias;
        }
    }
}

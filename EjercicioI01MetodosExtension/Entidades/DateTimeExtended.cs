using System;

namespace Entidades
{
    public enum Eestaciones 
    {
        Primavera, Otonio, Verano, Invierno
    }
    public static class DateTimeExtended
    {
        public static string ObtenerPlacaCronicaTV(this Eestaciones estacion) 
        {
            string retorno = "Ninguna estacion";
            DateTime inicioPrimavera =new DateTime(2022,09,21);
            DateTime inicioOtonio = new DateTime(2023, 03, 20);
            DateTime inicioInvierno = new DateTime(2022, 07,21);
            DateTime inicioVerano = new DateTime(2022, 12, 21);
            DateTime fechaActual = DateTime.Now;
            TimeSpan fechas;
            switch (estacion) 
            {
                case Eestaciones.Invierno:
                    fechas = inicioInvierno - fechaActual;
                    retorno = $"Faltan {fechas.Days} dias para el invierno";
                    break;
                case Eestaciones.Primavera:
                    fechas = inicioPrimavera - fechaActual;
                    retorno = $"Faltan {fechas.Days} dias para la primavera";
                    break;
                case Eestaciones.Verano:
                    fechas = inicioVerano - fechaActual;
                    retorno = $"Faltan {fechas.Days} dias para el verano";
                    break;
                case Eestaciones.Otonio:
                    fechas =  inicioOtonio-fechaActual;
                    retorno = $"Faltan {fechas.Days} dias para el Otoño";
                    break;
            }
            return retorno;
        }
    }
}

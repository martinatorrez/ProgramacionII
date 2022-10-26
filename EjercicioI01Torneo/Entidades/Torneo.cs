using System;
using System.Collections.Generic;
namespace Entidades
{
    public class Torneo<T>where T: Equipo
    {
        private string nombre;
        private List<T> equipos = new List<T>();
        public static bool operator ==(Torneo<T> torneo, T item) 
        {
            bool retorno = false;
            if(torneo is not null && item is not null) 
            {
                if (torneo.equipos.Contains(item)) 
                {
                    retorno = true; 
                }
            }
            return retorno;
        }
        public static bool operator !=(Torneo<T> torneo, T item) 
        {
            return !(torneo == item);
        }
        public static bool operator +(Torneo<T> torneo, T item) 
        {
            bool retorno=false;
            if (!(torneo == item)) 
            {
                torneo.equipos.Add(item);
                retorno = true;
            }
            return retorno;
        }
    }
}

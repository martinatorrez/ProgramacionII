using System;
using System.Text;

namespace Entidades
{
    public class AutoF1 :VehiculoDeCarrera
    {
        private short caballosDeFuerza;
       
        public AutoF1(short numero, string escuderia) :this(numero,escuderia,0)
        {
            
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) :base(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosDeFuerza 
        {
            get 
            {
                return this.caballosDeFuerza;
            }
            set 
            {
                this.caballosDeFuerza = value;
            }
        }
        
        public static bool operator ==(AutoF1 a1, AutoF1 a2) 
        {
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia&& a1.caballosDeFuerza==a2.caballosDeFuerza) 
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2) 
        {
            return !(a1 == a2);
        }
        
    }
}

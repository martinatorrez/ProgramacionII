using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross :VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada { get { return cilindrada; } set { cilindrada = value; } }

        public MotoCross(short numero, string escuderia, short cilindrada) :base(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public MotoCross(short numero, string escuderia) :this(numero, escuderia, 0)
        {
            
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.cilindrada == a2.cilindrada)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}

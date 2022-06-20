using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MiMetodoDeInstancia() 
        {
            try
            {
                new MiClase(11);
            }
            catch (UnaExcepcion ex) 
            {
                throw new MiExcepcion("Lanzo MiExcepcion", ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    { 
        public MiClase() 
        {
            try 
            {
                MiClase.MiMetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException("vengo del método",ex);
            }
        
        }
        public MiClase(int i) 
        {
            try 
            {
               new MiClase();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExcepcion("Lanzo UnaExcepcion", ex);
            }
        }
        public static void MiMetodoEstatico() 
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
    }
}

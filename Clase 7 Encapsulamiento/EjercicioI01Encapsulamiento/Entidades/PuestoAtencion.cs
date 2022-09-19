using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private Puesto puesto;
        
        public static int NumeroActual 
        {
            get { return numeroActual+1; }
        }

        static PuestoAtencion() 
        {
            numeroActual = 0; 
        }
        public PuestoAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli) 
        {
            bool retorno = false;
            if (Object.Equals(cli, null))
            {
                Thread.Sleep(1000);
                retorno = true;
            }
            return retorno;
        }
    }
}

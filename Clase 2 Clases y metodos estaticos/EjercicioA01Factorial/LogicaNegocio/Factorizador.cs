using System;

namespace LogicaNegocio
{
    public class Factorizador
    {
        public static int Factorizar(int numero) 
        {
            int factorial=1;
            for(int i = 1; 1 <= numero; i++) 
            {
                factorial *= i;
            }
            return factorial;
        }
        
    }
}

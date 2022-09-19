using System;

namespace LogicaValidar
{
    public class Validador
    {
       public static bool Validar(int valor, int min, int max) 
        {
            bool retornar=true;
            if(valor>max || valor < min) 
            {
                retornar = false;
            }
            return retornar;
        }
    }
}

using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            try
            {
                otraClase = new OtraClase();
                otraClase.MiMetodoDeInstancia();
              
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}

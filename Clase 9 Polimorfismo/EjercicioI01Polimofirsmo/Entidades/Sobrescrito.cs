using System;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito() 
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad 
        {
            get;
            
        }
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public abstract string MiMetodo();
        public override bool Equals(object obj)
        {
            if(obj.GetType() == typeof(Sobrescrito))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}

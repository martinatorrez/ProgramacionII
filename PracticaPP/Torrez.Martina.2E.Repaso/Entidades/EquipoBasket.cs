using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Eliga 
    {
        NBA, EuroLeague, ACB
    }
    public class EquipoBasket :Equipo
    {
        private Eliga liga;

        public EquipoBasket(string nombre, Eliga liga) :base(nombre)
        {
            this.liga = liga;
        }
        public EquipoBasket(string nombre) :this(nombre,Eliga.NBA)
        {
        }
        public override int GetDificultad()
        {
            int numeroRandom = 0;
            if (liga==Eliga.NBA) 
            {
                 numeroRandom = new Random().Next(8, 10);
            }
            if (liga == Eliga.EuroLeague) 
            {
                numeroRandom = new Random().Next(5, 10);
            }
            if (liga == Eliga.ACB) 
            {
                numeroRandom = new Random().Next(1, 7);
            }
            return numeroRandom;
        }
        protected override string MostrarDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Basket - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}

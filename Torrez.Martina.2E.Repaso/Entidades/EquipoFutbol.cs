using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol :Equipo
    {
        private bool JugadoresEstrellas;

        public EquipoFutbol(string nombre):this(nombre,false) 
        {
            
        }
        public EquipoFutbol(string nombre, bool jugadoresEstrellas) :base(nombre)
        {
            this.JugadoresEstrellas = jugadoresEstrellas;
        }
        public override int GetDificultad() 
        {
            int numeroRandom = 0;
            numeroRandom = new Random().Next(7, 10);
            if (this.JugadoresEstrellas) 
            {
               return numeroRandom *2;
            }
            return numeroRandom;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Futbol - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}

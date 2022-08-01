using System;
using System.Text;
namespace Entidades
{
    public abstract class Equipo //clase base
    {
        //mostrar dato es protegido, se hereda
        //si tiene cursiva es abstracto
        //agregar virtual al mostrar datos
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre) 
        {
            this.nombre = nombre;
        }
        public string Nombre 
        {
            get 
            {
                return nombre; 
            }
        }
        public int PE 
        {
            get 
            {
                return partidosEmpatados;
            }
            set 
            {
                this.partidosEmpatados = value;
            }
        }
        public int PG
        {
            get
            {
                return partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }
        public int PJ
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int PP
        {
            get
            {
                return partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }
        public int Puntuacion
        {
            get
            {
                return puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is not null && this.GetType() == obj.GetType();
        }
        public static bool operator ==(Equipo equipoA, Equipo equipoB) 
        {
            if (equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB))
            {
                return true;
            }
            return false;
           // return (equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB));
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB) 
        {
            return !(equipoA == equipoB);
        }
        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(this.Nombre);
            return sb.ToString();
        }
        public static bool JugarPartido (Equipo equipoA, Equipo equipoB)
        {
            bool retorno = false;
            if (equipoA.Equals(equipoB)) 
            {
                retorno = true;
                equipoA.PJ++;
                equipoB.PJ++;
                if (equipoA.GetDificultad() > equipoB.GetDificultad()) 
                {
                    equipoA.PG++;
                    equipoA.Puntuacion += 3;
                    equipoB.PP++;
                }
                else if (equipoA.GetDificultad()<equipoB.GetDificultad()) 
                {
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PP++;
                }
                else 
                {
                    equipoA.PE++;
                    equipoA.Puntuacion += 1;
                    equipoB.PE++;
                    equipoB.Puntuacion += 1;
                }
            }
            return retorno;
        }
        public abstract int GetDificultad();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadDeCompetidores;
        private List<Equipo> equipos = new List<Equipo>();
        private string nombre;

        public int CantidadDeCompetidores 
        {
            get 
            {
                return this.cantidadDeCompetidores;
            }
            set 
            {
                this.cantidadDeCompetidores = value;
            }
        }
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }
        public List<Equipo> Equipos 
        {
            get 
            {
                return this.equipos;
            }
        }
        public Competencia(string nombre, int cantidadDeCompetidores) 
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadDeCompetidores = cantidadDeCompetidores;
        }
        private Competencia(string nombre) :this(nombre,5)
        {
        
        }
        public static implicit operator Competencia(string nombre) 
        {
            return new Competencia(nombre);
        }
        public static bool operator ==(Competencia torneo, Equipo equipo) 
        {
            foreach (Equipo item in torneo.Equipos)
            {
                if (item == equipo)
                    return true;
            }
            return false;
            
        }
        public static bool operator !=(Competencia torneo, Equipo equipo) 
        {
            return !(torneo == equipo);
        }
        public static Competencia operator +(Competencia torneo, Equipo equipo) 
        {
            if(torneo !=equipo && torneo.cantidadDeCompetidores >  torneo.equipos.Count) 
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        public static string MostrarTorneo(Competencia torneo) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia: {torneo.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.Equipos.Count}/{torneo.CantidadDeCompetidores}");
            foreach(Equipo item in torneo.equipos) 
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
            /*StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de competencia: {torneo.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.CantidadDeCompetidores}");
            sb.AppendLine($"Equipos: ");
            foreach (Equipo e in torneo.Equipos)
            {
                if (e is EquipoBasket)
                    sb.AppendLine(e.ToString());
                else
                    sb.AppendLine();
            }
            return sb.ToString();*/
        }
    }
}

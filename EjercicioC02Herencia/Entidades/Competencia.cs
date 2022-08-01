using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private Competencia() 
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidaVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadVueltas = cantidaVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA");
            sb.AppendLine("COMPETIDORES: " + this.cantidadCompetidores);
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine("----------------------");

            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a) 
        {
            if (c.competidores.Count < c.cantidadCompetidores && c!=a) 
            {
                Random rdn = new Random();
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)rdn.Next(15, 100);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a) 
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a) 
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return false;
                }
            }
            return true;
        }


    }
}

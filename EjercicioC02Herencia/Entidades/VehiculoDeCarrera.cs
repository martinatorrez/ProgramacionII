using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia) 
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public short CantidadCombustible
        {
              get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
             get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto: " + this.numero);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Vueltas restantes: " + this.vueltasRestantes);
            return sb.ToString();

        }
    }
}

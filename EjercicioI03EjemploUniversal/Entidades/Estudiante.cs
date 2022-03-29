using System;
using System.Text;
namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;

        static Estudiante() 
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int value) 
        {
            this.notaPrimerParcial = value;
        }

        public void SetNotaSegundoParcial(int value)
        {
            this.notaSegundoParcial = value;
        }

        private float CalcularPromedio() 
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal() 
        {
            if(notaPrimerParcial>3 && notaSegundoParcial > 3) 
            {
               return random.Next(6, 10);
            }
            else 
            {
                return -1;
            }
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre y apellido: {nombre} {apellido}. Legajo: {legajo}");
            sb.AppendLine("");
            sb.AppendFormat($"Nota primer parcial: {notaPrimerParcial} Nota segundo parcial:{notaSegundoParcial}");
            sb.AppendLine("");
            sb.AppendFormat($"Promedio: {CalcularPromedio()}");
            sb.AppendLine("");
            if (CalcularNotaFinal() != -1) 
            {
                sb.AppendFormat($"Nota final: {CalcularNotaFinal()}");
                sb.AppendLine("");
            }
            else 
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}

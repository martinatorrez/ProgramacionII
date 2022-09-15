using System;
using System.Text;
namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, string fechaDeNacimiento, int dni) 
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string GetNombre() 
        {
            return this.nombre;
        }
        public string GetFechaDeNacimiento() 
        {
            return this.fechaDeNacimiento;
        }
        public int GetDni() 
        {
            return this.dni;
        }
        public void SetNombre(string value) 
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.nombre = value;
            }
        }
        public void SetDni(int value) 
        {
            if (value > 1) 
            {
                this.dni = value;
            }
        }
        public void SetFechaDeNacimiento(string value) 
        {
            this.fechaDeNacimiento = value;
        }

        private static int CalcularEdad(Persona personaUno) 
        {
            DateTime fecha = DateTime.Parse(personaUno.GetFechaDeNacimiento());
            DateTime fechaActual=DateTime.Now;
            int edad = fechaActual.Year - fecha.Year;
            if (fecha.Month > fechaActual.Month)
            {
                edad = edad - 1;
            }
            return edad;
        }
        public static string Mostrar(Persona personaUno) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {personaUno.nombre}"); 
            sb.AppendLine("");
            sb.AppendFormat($"Fecha de nacimiento: {personaUno.fechaDeNacimiento}. Dni: {personaUno.dni}. Edad: {CalcularEdad(personaUno)}");
            return sb.ToString();
        }
        public static string EsMayorDeEdad(Persona personaUno) 
        {
            string retorno = "Es menor";
            if (CalcularEdad(personaUno) > 17) 
            {
                retorno = "Es mayor de edad";
            }
            return retorno;
        }
    }
}

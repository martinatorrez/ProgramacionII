using System;
using System.Text;
namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;


        
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre} ");
            sb.AppendLine($"Direccion: {direccion}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Genero: {genero}");
            sb.AppendLine($"Pais: {pais}");
            sb.AppendLine($"Curso/s: {cursos}");
            return sb.ToString();
        }
    }
}

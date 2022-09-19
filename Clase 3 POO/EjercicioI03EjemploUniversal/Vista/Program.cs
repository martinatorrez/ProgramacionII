using System;
using Entidades;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerAlumno = new Estudiante("Juan", "Perez", "1234");
            Estudiante segundoAlumno = new Estudiante("Pepito", "Rodriguez", "1235");
            Estudiante tercerAlumno = new Estudiante("Maria", "Ramirez", "1236");

            primerAlumno.SetNotaPrimerParcial(4);
            primerAlumno.SetNotaSegundoParcial(6);
            
            segundoAlumno.SetNotaPrimerParcial(4);
            segundoAlumno.SetNotaSegundoParcial(2);

            tercerAlumno.SetNotaPrimerParcial(8);
            tercerAlumno.SetNotaSegundoParcial(6);

            Console.WriteLine(primerAlumno.Mostrar());
            Console.WriteLine(segundoAlumno.Mostrar());
            Console.WriteLine(tercerAlumno.Mostrar());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentroDeAtencion
    {
        private int cantRacsPorSuper;
        private List<Empleado> empleados;
        private string nombre;

        public List<Empleado> Empleados 
        {
            get { return this.empleados; }
        }
        public string Nombre 
        {
            get { return this.nombre; }
        }

        public CentroDeAtencion(string nombre, int cantRacsPorSuper) 
        {
            this.nombre = nombre;
            this.cantRacsPorSuper = cantRacsPorSuper;
            empleados = new List<Empleado>();
        }
        public static bool operator ==(CentroDeAtencion c, Empleado e) 
        {
            foreach (Empleado item in c.Empleados)
            {
                if(item == e) 
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(CentroDeAtencion c, Empleado e) 
        {
            return !(c == e);
        }
        private bool ValidaCantidadDeRacs() 
        {
            int cantidadRacs = 0;
            int cantidadSupervisor = 0;
            foreach (Empleado item in Empleados) 
            {
                if(item is Rac) 
                {
                    cantidadRacs++;
                }
                if(item is Supervisor) 
                {
                    cantidadSupervisor++;
                }
            }
            return cantidadRacs > (cantidadSupervisor * this.cantRacsPorSuper);
        }
        public static bool operator +(CentroDeAtencion c, Empleado e) 
        {
            if (c != e) 
            {
                if (e is Rac || e is Supervisor && c.ValidaCantidadDeRacs()) 
                {
                    c.empleados.Add(e);
                    return true;
                }
            }
            return false;
        }
        public static string operator -(CentroDeAtencion c, Empleado e) 
        {
            string retorno = "Empleado no encontrado";
            if (c == e) 
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                retorno = $"{e.EmitirFactura()}";
                c.empleados.Remove(e);
            }
            return retorno;

        }
        public string ImprimirNomina() 
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado item in empleados)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}

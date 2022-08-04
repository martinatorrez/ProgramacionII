using System;

namespace Entidades
{
    public abstract class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;

        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public string Nombre { get { return this.nombre; } }
        public string Legajo { get { return this.legajo; } }
        public TimeSpan HoraIngreso { get { return this.horaIngreso; } }
        public TimeSpan HoraEgreso { get { return this.horaEgreso; } set { this.horaEgreso = this.ValidarHoraEgreso(value); } }

        private TimeSpan ValidarHoraEgreso(TimeSpan horaEgreso) 
        {
            if (horaEgreso > this.HoraIngreso) 
            {
                return horaEgreso;
            }
            else 
            {
                return DateTime.Now.TimeOfDay;
            }
        }

        protected virtual double Facturar() 
        {
            return horaEgreso.TotalHours - HoraIngreso.TotalHours;
        }
        public abstract string EmitirFactura();

        public static bool operator ==(Empleado emp1, Empleado emp2) 
        {
            return emp1.legajo == emp2.legajo;
        }
        public static bool operator !=(Empleado emp1, Empleado emp2) 
        {
            return !(emp1 == emp2);
        }

    }
}

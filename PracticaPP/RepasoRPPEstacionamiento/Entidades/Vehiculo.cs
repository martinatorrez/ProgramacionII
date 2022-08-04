using System;
using System.Text;
namespace Entidades
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        public enum EVehiculos { Automovil, Moto }
        public Vehiculo(string patente, DateTime horaIngreso) 
        {
            this.patente = patente;
            this.horaEgreso = horaIngreso; 
        }
        public string Patente 
        {
            get { return patente; }
            set
            {
                if (this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            } 
        }
        public  DateTime HoraEgreso 
        {
            get 
            {
                return horaEgreso;
            }
            set 
            {
                if (horaEgreso > horaIngreso) 
                {
                    this.horaEgreso = value;
                }
            }
        }
        public DateTime HoraIngreso 
        {
            get 
            {
                return horaIngreso;
            }
        }
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }
        private bool ValidarPatente(string patente) 
        {
            bool retornar = false;
            if (patente.Length >= 6 && patente.Length < 8) 
            {
                retornar = true;
            }
            return retornar;
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2) 
        {
            return v1.patente == v2.patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2) 
        {
            return !(v1 == v2);
        }
        protected virtual double CargoDeEstacionamiento() 
        {
            double totalHoras=0;
            if (this.HoraEgreso > this.HoraIngreso) 
            {
                totalHoras = (HoraEgreso - HoraIngreso).TotalHours;
            }
            return totalHoras;
        }
        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Hora Ingreso: {this.HoraIngreso}");
            return sb.ToString();
        }
    }
}

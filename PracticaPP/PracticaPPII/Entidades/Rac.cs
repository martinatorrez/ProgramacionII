using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rac : Empleado
    {
        public enum EGrupo 
        {
            CALL_IN, 
            CALL_OUT,
            RRSS
        }
        private EGrupo grupo;
        private static double valorHora;

        public EGrupo Grupo { get { return this.grupo; } }
        public static double ValorHora { get { return valorHora; } set { if (valorHora > 0) { Rac.valorHora = value; } } }
        static Rac() 
        {
            valorHora = 875.90F;
        }
        public Rac(string legajo, string nombre, TimeSpan horaIngreso):this(legajo, nombre, horaIngreso, EGrupo.CALL_IN) 
        {

        }
        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo): base(legajo,nombre, horaIngreso) 
        {
            this.grupo = grupo;
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {base.ToString()}\nImporte a facturar: {this.Facturar()}";
        }
        protected override double Facturar()
        {
            return base.Facturar() * (Rac.valorHora + (Rac.valorHora * this.CalcularBonoDeGrupo()));
        }
        private double CalcularBonoDeGrupo() 
        {
            return (int)this.grupo / (float)10;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.grupo} - {this.legajo} - {this.nombre}";
        }
    }
}

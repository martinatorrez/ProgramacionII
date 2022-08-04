using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor :Empleado
    {
        private static float valorHora;
         static Supervisor() 
        {
            valorHora = 1025.50F;
        }
        private Supervisor(string legajo) :this(legajo,"n/a",new TimeSpan(09,00,00))
        {
        
        }
        public Supervisor(string legajo, string nombre, TimeSpan horaIngreso) :base(legajo,nombre,horaIngreso)
        {
            
        }
        public static float ValorHora { get { return valorHora; } set { if (valorHora > 0) { valorHora = value; } } }

        protected override double Facturar()
        {
            return base.Facturar() * Supervisor.ValorHora;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} - {legajo} - {nombre}";
        }
        public override string EmitirFactura()
        {
            return $"Factura de: {base.ToString()}\nImporte a facturar: {base.Facturar()}";
        }
        public static implicit operator Supervisor(string legajo) 
        {
            return new Supervisor(legajo);
        }

    }
}

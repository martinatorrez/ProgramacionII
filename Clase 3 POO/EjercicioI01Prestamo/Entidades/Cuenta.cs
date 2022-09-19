using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"La razon social del titular es: {this.titular} y el monto actual de dinero en la cuenta es: {this.cantidad}";
        }
        public void Ingresar (decimal montoAIngresar) 
        {
            if (montoAIngresar > 0) 
            {
                cantidad += montoAIngresar;
            }
        }
        public void Retirar(decimal montoARetirar) 
        {
            if(montoARetirar > 0) 
            {
                this.cantidad -= montoARetirar;
            }
        }
    }
}

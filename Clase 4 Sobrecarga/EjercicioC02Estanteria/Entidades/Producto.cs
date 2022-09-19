using System;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio) 
        {
            this.codigoDeBarra= codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca() 
        {
            return this.marca;
        }
        public float GetPrecio() 
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return "Marca: " + p.marca + " Precio: " + p.precio + " Codigo de barras: " + p.codigoDeBarra;
        }
        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra; 
        }
        public static bool operator ==(Producto p1, Producto p2) 
        {
            bool retornar = false;
            if (!(p1 is null || p2 is null))
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                {
                    retornar = true;
                }
            }
            return retornar;
        }
        public static bool operator !=(Producto p1, Producto p2) 
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca) 
        {
            bool retornar = false;
            if (p1.marca == marca) 
            {
                retornar = true;
            }
            return retornar;
        }
        public static bool operator !=(Producto p1, string marca) 
        {
            return !(p1 == marca);
        }
    }
}

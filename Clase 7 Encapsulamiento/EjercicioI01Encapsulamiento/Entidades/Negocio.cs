﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente 
        {
            get 
            {
                return clientes.Dequeue();
            }
            set 
            {
                bool resultado = this + value;//el this hace referencia a la clase, en este caso al negocio
            }
            
        }
        private Negocio() 
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion( PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) 
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                
                    if (cliente == c)
                    {
                        return true;
                    }
                
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c) 
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c) 
        {
            
                if (n != c)
                {
                    n.clientes.Enqueue(c);
                    return true;
                }
            
            return false;
        }
        public static bool operator ~(Negocio n) 
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
            /*if(n.caja.Atender(n.Cliente)) 
            {
                return true;
            }
            return false;*/
        }
        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }
    }
}

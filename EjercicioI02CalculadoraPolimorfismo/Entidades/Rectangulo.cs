﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo :Figura
    {
        private double longitudBase;
        private double longitudAltura;

        public Rectangulo(double longitudBase, double longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }
        public override double CalcularSuperficie()
        {
            return this.longitudBase * this.longitudAltura;
        }
        public override double CalcularPerimetro()
        {
            return (this.longitudBase + this.longitudAltura) * 2;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }
        
    }
}

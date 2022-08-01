﻿using System;

namespace Entidades
{
    public abstract class Figura
    {
        public virtual string Dibujar() 
        {
            return "Dibujando figura...";
        }
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();
    }
}

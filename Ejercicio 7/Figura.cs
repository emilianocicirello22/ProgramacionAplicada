using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7
{
    public abstract class Figura
    {
        private double ladoBase;
        private double ladoAltura;

        public double LadoBase { get => ladoBase; set => ladoBase = value; }

        public double LadoAltura { get => ladoAltura; set => ladoAltura = value; }

        public abstract double Superficie();

        public abstract double Perimetro();

        public override string ToString()
        {
            return $"Base: {this.LadoBase}, Altura: {this.LadoAltura}, La superficie es: {Superficie()}, y su Perimetro es: {Perimetro()}";
        }
    }
}
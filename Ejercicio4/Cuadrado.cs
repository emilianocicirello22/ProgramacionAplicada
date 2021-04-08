using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Cuadrado
    {
        //Atributos
        private double longitudLado1;

        //Constructores
        public Cuadrado()
        {

        }

        public Cuadrado(double valor)
        {
            this.longitudLado1 = valor;
        }

        //Geter Seter
        public void getLongitud(double valor)
        {
            this.longitudLado1 = valor;
        }

        public double setLongitud()
        {
            return this.longitudLado1;
        }

        public double Perimetro()
        {
            return (this.longitudLado1 * 4);
        }

        public double Superficie()
        {
            return this.longitudLado1 * this.longitudLado1;
        }

        public override string ToString()
        {
            return $"El perimetro del cuadrado es: {Perimetro()}.\nLa superficie del cuadrado es: {Superficie()}";
        }
    }
}

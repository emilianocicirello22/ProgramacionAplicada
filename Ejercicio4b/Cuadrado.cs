using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4b
{
    class Cuadrado
    {
        //Atributos
        private double longitudLado1;

        //Constructores
        public Cuadrado()
        {
            Console.WriteLine("Ingrese longitud de un lado del cuadrado");
            this.longitudLado1 = double.Parse(Console.ReadLine());
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
            return $"Cuadrado con longitud {this.longitudLado1}\nEl perimetro del cuadrado es: {Perimetro()}.\nLa superficie del cuadrado es: {Superficie()}";
        }
    }
}

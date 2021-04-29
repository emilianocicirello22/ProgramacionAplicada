using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7
{
    class Circulo:Figura
    {
        private double radio;

        public Circulo()
        {
            Console.WriteLine("Ingrese radio del circulo");
            this.radio = double.Parse(Console.ReadLine());
        }

        double pi = Math.PI;
        public override double Perimetro()
        {            
            return 2 * pi * radio;
        }

        public override double Superficie()
        {
            return pi*(Math.Pow(radio,2));
        }

        public override string ToString()
        {
            return $"Radio: {this.radio}, La superficie es: {Superficie()}, y su Perimetro es: {Perimetro()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7
{
    class Triangulo:Figura
    {
        private double lado1;
        private double lado2;
        public Triangulo()
        {
            Console.WriteLine("Ingrese base del triangulo");
            LadoBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura del triangulo");
            LadoAltura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingres un valor para el lado A del triangulo");
            this.lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingres un valor para el lado B del triangulo");
            this.lado2 = double.Parse(Console.ReadLine());
        }

        public override double Perimetro()
        {
            return (LadoBase + lado1 + lado2);
        }

        public override double Superficie()
        {
            return LadoBase * (LadoAltura/2);
        }

        public override string ToString()
        {
            return $"Lado A: {this.lado1}, Lado B: {this.lado2}, {base.ToString()}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7
{
    class Rectangulo:Figura
    {
        public Rectangulo()
        {
            Console.WriteLine("Ingrese base del rectangulo");
            LadoBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura del rectangulo");
            LadoAltura = double.Parse(Console.ReadLine());
        }

        public override double Perimetro()
        {
            return ((LadoBase * 2) + (LadoAltura * 2));
        }

        public override double Superficie()
        {
            return (LadoBase * LadoAltura);
        }

        public override string ToString()
        {
            return $"Rectangulo: {base.ToString()}";
        }
    }
}
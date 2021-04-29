using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7
{
    class Cuadrado : Figura
    {
        public Cuadrado()
        {
            Console.WriteLine("Ingrese el tamaño de la base del cuadrado");
            LadoBase = double.Parse(Console.ReadLine());
            LadoAltura = LadoBase;
        }

        public override double Perimetro()
        {
            return (LadoBase * 4);
        }

        public override double Superficie()
        {
            return (LadoBase * 2);
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}

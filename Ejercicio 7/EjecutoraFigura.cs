using System;

namespace Ejercicio_7
{
    class EjecutoraFigura
    {
        static void Main(string[] args)
        {
            Cuadrado objcuadrado = new Cuadrado();

            Console.WriteLine(objcuadrado.ToString());

            Rectangulo objrectangulo = new Rectangulo();

            Console.WriteLine(objrectangulo.ToString());

            Triangulo objtriangulo = new Triangulo();

            Console.WriteLine(objtriangulo.ToString());
        }
    }
}

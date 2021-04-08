using System;

namespace Ejercicio1
{
    class EjecutoraTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            Console.WriteLine("Ingrese el valor del lado A");
            t.setLongitud1(int.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el valor del lado B");
            t.setLongitud2(int.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el valor de la base");
            t.setLongitud3(int.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese el valor de la altura");
            t.setAltura(int.Parse(Console.ReadLine()));


            Console.WriteLine(t.ToString());
        }
    }
}

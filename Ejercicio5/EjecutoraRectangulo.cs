using System;

namespace Ejercicio5
{
    class EjecutoraRectangulo
    {
        static void Main(string[] args)
        {
            //Creamos un objeto Rectangulo
            Rectangulo r = new Rectangulo();

            //Cargamos los datos correspondientes
            Console.WriteLine("Ingresar Base del Rectangulo");
            r.setBase(double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingresar Altura del Rectangulo");
            r.setAltura(double.Parse(Console.ReadLine()));

            //Llamamos a los metodos correspondientes para mostrar el resultado
            r.Perimetro();
            r.Superficie();
        }
    }
}

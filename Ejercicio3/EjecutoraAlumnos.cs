using System;

namespace Ejercicio3
{
    class EjecutoraAlumnos
    {
        static void Main(string[] args)
        {
            Alumnos a = new Alumnos("Pedro Marmol", 3, 6, 7, 8, 3, 4, 6, 7, 8, 10);

            Console.WriteLine(a.ToString());
        }
    }
}

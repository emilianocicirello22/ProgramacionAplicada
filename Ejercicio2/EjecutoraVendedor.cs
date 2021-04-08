using System;

namespace Ejercicio2
{
    class EjecutoraVendedor
    {
        static void Main(string[] args)
        {
            Vendedor v = new Vendedor("Roberto", 30, 40);

            Console.WriteLine(v.ToString());
        }
    }
}

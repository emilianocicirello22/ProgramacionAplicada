using System;
using System.Collections.Generic;
namespace Ejercicio9
{
    class EjecutoraCurso
    {
        static void Main(string[] args)
        {
            int opc = 0;
            List<Alumnos> objalum = new List<Alumnos>();

            Curso curso1 = new Curso();

            Console.WriteLine("Ingrese lista de alumnos");

            do
            {

                objalum.Add(new Alumnos());

                Console.WriteLine("Ingrese 1 para continuar cargando /0 para finalizar");
                opc = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (opc != 0);

            curso1.Promedio(objalum);
            curso1.Aprobado(objalum);
            curso1.Desaprobado(objalum);
            Console.WriteLine(curso1.ToString());
            Console.WriteLine(curso1.MejorProm(objalum));

        }
    }
}

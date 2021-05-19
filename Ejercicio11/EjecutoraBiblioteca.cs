using System;

namespace Ejercicio11
{
    class EjecutoraBiblioteca
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Biblioteca objbiblioteca = new Biblioteca();

            do
            {
                Console.WriteLine("1-Agregar/Modificar libros\n2-Consultar existencias\n3-Prestamos\n4-Devoluciones\n0-Salida");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        objbiblioteca.AgregarLibro();
                        break;
                    case 2:
                        objbiblioteca.Existencias();
                        break;
                    case 3:
                        objbiblioteca.PrestamoLibro();
                        break;
                    case 4:
                        objbiblioteca.Devoluciones();
                        break;
                    default:
                        Console.WriteLine("Hasta la proxima");
                        break;
                }

            }while (opcion!=0);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{
    class Biblioteca
    {
               
        List<Libro> objlibro = new List<Libro>();
        
        
        

        public void AgregarLibro()
        {
            Console.WriteLine("1-Ingresar libro al sistema\n2-Agregar ejemplar de un libro");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    objlibro.Add(new Libro());
                    break;
                case 2:

                    if (objlibro.Count > 0)
                    {


                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                        }
                        Console.WriteLine("Ingrese el libro");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de ejemplares que desea agregar");
                        objlibro[opc].Ejemplares = objlibro[opc].Ejemplares + (int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine("Aun no se han agregado libros");
                    }
                    break;
            }
            

        }

        public void PrestamoLibro()
        {
            if (objlibro.Count > 0)
            {

                Console.WriteLine("Busque su libro por:\n1-Lista Completa\n2-Titulo\n3-Autor");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:

                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                        }
                        Console.WriteLine("Seleccione el libro que desea");
                        opc = int.Parse(Console.ReadLine());

                        if (objlibro[opc].Ejemplares > 0)
                        {
                            Console.WriteLine("Disfrute de su libro y recuerde que tiene 15 dias para devolverlo");
                            objlibro[opc].EjemPrestamo++;
                            objlibro[opc].Ejemplares--;

                        }
                        else
                        {
                            Console.WriteLine("No hay stock del libro que desea");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese titulo del libro");
                        string tit = tit = Console.ReadLine();

                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            if (objlibro[i].Titulo.Equals(tit, StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                            }
                        }
                        Console.WriteLine("Seleccione el libro que desea");
                        opc = int.Parse(Console.ReadLine());

                        if (objlibro[opc].Ejemplares > 0)
                        {
                            Console.WriteLine("Disfrute de su libro y recuerde que tiene 15 dias para devolverlo");
                            objlibro[opc].EjemPrestamo++;
                            objlibro[opc].Ejemplares--;
                        }
                        else
                        {
                            Console.WriteLine("No hay stock del libro que desea");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese nombre del autor");
                        string aut = Console.ReadLine();

                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            if (objlibro[i].Autor.Equals(aut, StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                            }
                        }
                        Console.WriteLine("Seleccione el libro que desea");
                        opc = int.Parse(Console.ReadLine());

                        if (objlibro[opc].Ejemplares > 0)
                        {
                            Console.WriteLine("Disfrute de su libro y recuerde que tiene 15 dias para devolverlo");
                            objlibro[opc].EjemPrestamo++;
                            objlibro[opc].Ejemplares--;
                        }
                        else
                        {
                            Console.WriteLine("No hay stock del libro que desea");
                        }
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Aun no se han agregado libros");
            }   
        }

        public void Existencias()
        {
            if (objlibro.Count > 0)
            {

                Console.WriteLine("Consulte Existencias del libro por:\n1-Lista Completa\n2-Titulo\n3-Autor");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        foreach (Libro ejemplar in objlibro)
                        {
                            Console.WriteLine($"{ejemplar.ToString()}\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese titulo del libro");
                        string tit = tit = Console.ReadLine();

                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            if (objlibro[i].Titulo.Equals(tit, StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese nombre del autor");
                        string aut = Console.ReadLine();

                        for (int i = 0; i < objlibro.Count; i++)
                        {
                            if (objlibro[i].Autor.Equals(aut, StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine($"{i}-{objlibro[i].ToString()}\n");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Aun no se han agregado libros");
            }
        }

        public void Devoluciones()
        {
            if (objlibro.Count > 0)
            {
                bool hayLibro = false;
                

                for (int i = 0; i < objlibro.Count; i++)
                {
                    if(objlibro[i].EjemPrestamo != 0)
                    {
                        Console.WriteLine($"{i}- {objlibro[i].Titulo}\nHay {objlibro[i].EjemPrestamo} ejemplares prestados\n");
                        hayLibro = true;
                    }
                                
                }
                if (hayLibro)
                {
                    Console.WriteLine("Ingrese el libro que desea devolver");
                    int opc = int.Parse(Console.ReadLine());
                    objlibro[opc].EjemPrestamo--;
                    objlibro[opc].Ejemplares++;

                    Console.WriteLine("El libro fue devuelto con exito");
                    Console.WriteLine($"{objlibro[opc].Titulo}\nHay {objlibro[opc].EjemPrestamo} ejemplares prestados\n");

                }
                

            }
            else
            {
                Console.WriteLine("Aun no se han agregado libros");
            }
        }
    }
}

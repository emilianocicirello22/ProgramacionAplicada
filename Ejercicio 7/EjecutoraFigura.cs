using System;
using System.Collections;
using System.Collections.Generic;
namespace Ejercicio_7
{
    class EjecutoraFigura
    {
        static void Main(string[] args)
        {
            int opc = 0;

            List<Figura> fig = new List<Figura>();
            Console.WriteLine("Bienvenidos al programa calculá la tu figura");

            do
            {
                Console.WriteLine("1-Crear figura\n2-Mostrar Datos de las figuras\n3-Superficie total de todas las figuras\n4-Perimetro total de todas las figuras\n0-Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    //menu para crear figura
                    case 1:
                        do
                        {
                            Console.WriteLine("1-Cuadrado\n2-Rectangulo\n3-Circulo\n4-Triangulo\n0-Salir");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {

                                case 1:
                                    fig.Add(new Cuadrado());
                                    break;
                                case 2:
                                    fig.Add(new Rectangulo());
                                    break;
                                case 3:
                                    fig.Add(new Circulo());
                                    break;
                                case 4:
                                    fig.Add(new Triangulo());
                                    break;
                                default:
                                    if (opc == 0)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion Incorrecta");
                                    }
                                    break;
                            }
                        } while (opc != 0);
                        opc = 1;
                        break;
                        //fin crear figura
                        
                    case 2:
                        foreach(Figura li in fig)
                        {
                            Console.WriteLine(li);
                        }
                        break;

                    case 3:
                        double totalSup = 0;
                        if (fig.Count > 0)
                        {
                            for(int i = 0; i < fig.Count; i++)
                            {
                                totalSup += fig[i].Superficie();
                            }
                        }
                        else
                        {
                            Console.WriteLine("no hay datos");
                        }
                        Console.WriteLine($"La superficie total de todas las figuras es {totalSup}");
                        break;

                    case 4:
                        double totalPer = 0;
                        if (fig.Count > 0)
                        {
                            for (int i = 0; i < fig.Count; i++)
                            {
                                totalPer += fig[i].Perimetro();
                            }
                        }
                        else
                        {
                            Console.WriteLine("no hay datos");
                        }
                        Console.WriteLine($"El perimetro total de todas las figuras es {totalPer}");
                        break;
                    default:
                        if (opc == 0)
                        {
                            Console.WriteLine("Gracias por utilizar la APP");
                        }
                        else
                        {
                            Console.WriteLine("Opcion Incorrecta");
                        }
                        break;
                        
                }
            } while (opc != 0);
        }
    }
}

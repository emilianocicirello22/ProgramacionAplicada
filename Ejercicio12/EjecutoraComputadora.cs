using System;
using System.Collections.Generic;
namespace Ejercicio12
{
    class EjecutoraComputadora
    {
        
        static void Main(string[] args)
        {
            List<Computadora> com = new List<Computadora>();

            int opc = 0;
            int c = 1;

           
            Console.WriteLine("Bienvenidos al programa");

            do
            {
                Console.WriteLine("1-Crear Computadora\n2-Mostrar todas las Computadoras\n3-Mostrar cuantas computadoras hay individuales\n4-Cuantas computadoras hay en total\n0-Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    
                    case 1:
                        do
                        {
                            Console.WriteLine("1-PC Escritorio\n2-All In One\n3-Notebook\n4-Smartphone\n0-Salir");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {

                                case 1:
                                    Console.WriteLine($"Pc escritorio: {PcEscritorio.ContPc}");
                                    break;
                                case 2:
                                    Console.WriteLine($"All in one: {PcAllInOne.ContAll}");
                                    break;
                                case 3:
                                    Console.WriteLine($"Notebook: {Notebook.ContNotebook}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Smartphone: {Smartphone.ContSmart}");
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
                    

                    case 2:
                        foreach (Computadora objcomputadora in com)
                        {
                            Console.WriteLine(objcomputadora);
                        }
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("1-PC Escritorio\n2-All In One\n3-Notebook\n4-Smartphone\n0-Salir");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {

                                case 1:
                                    com.Add(new PcEscritorio(c));
                                    break;
                                case 2:
                                    com.Add(new PcAllInOne());

                                    break;
                                case 3:
                                    com.Add(new Notebook());
                                    break;
                                case 4:
                                    com.Add(new Smartphone());
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

                    case 4:
                        if (Computadora.Contador > 0)
                        {
                            Console.WriteLine($"Hay creadas {Computadora.Contador} Unidades");
                        }
                        else
                        {
                            Console.WriteLine("No se han creado ninguna unidad");
                        }
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

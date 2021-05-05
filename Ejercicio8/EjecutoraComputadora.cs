using System;
using System.Collections.Generic;
namespace Ejercicio8
{
    class EjecutoraComputadora
    {
        static void Main(string[] args)
        {
            List<Computadora> com = new List<Computadora>();

            int opc = 0;

           
            Console.WriteLine("Bienvenidos al programa");

            do
            {
                Console.WriteLine("1-Crear Computadora\n2-Mostrar todas las Computadoras\n3-Eliminar una computadora\n4-Cuantas computadoras hay en total\n0-Salir");
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
                                    com.Add(new PcEscritorio());
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
                    

                    case 2:
                        foreach (Computadora objcomputadora in com)
                        {
                            Console.WriteLine(objcomputadora);
                        }
                        break;

                    case 3:
                        int eliminar = 0;
                        if (com.Count > 0)
                        {
                            for (int i = 0; i < com.Count; i++)
                            {
                                Console.WriteLine($"//////////////{i}//////////////");
                                Console.WriteLine(com[i].ToString() + "\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("no hay datos");
                        }
                        Console.WriteLine($"Ingrese el numero de Articulo a eliminar");
                        eliminar = int.Parse(Console.ReadLine());
                        com.RemoveAt(eliminar);
                        Computadora.Contador--;

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

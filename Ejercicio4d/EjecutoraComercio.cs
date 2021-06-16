using System;
using System.Collections.Generic;
using System.Collections;
namespace Ejercicio4d
{
    class EjecutoraComercio
    {
        
        static void Main(string[] args)
        {
            Dictionary<int,Vendedor> ven = new Dictionary<int, Vendedor>(); 

            int opc = 0;
            double ventaAnual = 0;

            Console.WriteLine("Bienvenidos al programa");  
            

            do
            {
                Console.WriteLine("1-Ingresar Vendedor\n2-Eliminar Vendedor\n3-Ventas Anuales\n4-Venta Semestral\n0-Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        Console.WriteLine("Ingrese DNI del Vendedor");
                        int dni = int.Parse(Console.ReadLine());
                        if (!ven.ContainsKey(dni))
                        {
                            ven.Add(dni ,new Vendedor());
                            ventaAnual = ventaAnual + ven[dni].VentaPrimerSem + ven[dni].VentaSegundoSem;
                        }
                        else
                        {
                            Console.WriteLine("Vendedor ya ingresado");
                        }
                        
                        break;


                    case 2:


                        Console.WriteLine($"Ingrese Dni del vendedor que desea eliminar");
                        ven.Remove(int.Parse(Console.ReadLine()));

                        break;

                    case 3:
                        Console.WriteLine($"La venta anual fue de {ventaAnual}");
                        
                        break;

                    case 4:
                        Console.WriteLine($"Ingrese Dni del vendedor");
                        ven[int.Parse(Console.ReadLine())].VentaMejorSemestre();
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

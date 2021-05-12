using System;
using System.Collections.Generic;
namespace Ejercicio10
{
    class EjecutoraComercio
    {
        static void Main(string[] args)
        {
            List<Vendedor> ven = new List<Vendedor>(); 

            int opc = 0;


            Console.WriteLine("Bienvenidos al programa");

            //creamos un comercio
            Comercio com = new Comercio();

            do
            {
                Console.WriteLine("1-Ingresar Vendedor\n2-Eliminar Vendedor\n3-Ventas Anuales\n4-Venta Semestral\n0-Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        ven.Add(new Vendedor());
                        break;


                    case 2:
                        com.EliminarVendedor(ven);

                        break;

                    case 3:
                        com.VentaAnual(ven);
                        break;

                    case 4:
                        Console.WriteLine(com.MejorVentaSem(ven));                       
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

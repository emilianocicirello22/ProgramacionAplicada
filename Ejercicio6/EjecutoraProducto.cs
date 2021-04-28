using System;

namespace Ejercicio6
{
    class EjecutoraProducto
    {
        static void Main(string[] args)
        {
            Producto p = new Producto();

            string mensaje = "1-Crear producto\n2-Comprar producto\n3-Vender producto\n4-Consultar saldo\n5-Cambiar punto de pedido\n6-Cambiar maximo permitido\n7-Cambiar precio unitario\n0-Salir";
            int opc = 0;
            Console.WriteLine("Bienvenido al gestor de stock.\nIngrese 1 para ingresar, 0 para salir del programa");
            opc = int.Parse(Console.ReadLine());


            while (opc != 0)
            {                
                do
                {
                    Console.WriteLine(mensaje);
                    opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("1-Cargar todos los datos del producto\n2-Cargar Codigo y descripcion");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    int val = 0;
                                    Console.WriteLine("Ingrese Codigo de Producto");
                                    p.setCodigo(Console.ReadLine());

                                    Console.WriteLine("Ingrese descripcion del producto");
                                    p.setDescripcion(Console.ReadLine());

                                    Console.WriteLine("Ingrese precio unitario del producto");
                                    p.setPrecio(double.Parse(Console.ReadLine()));

                                    Console.WriteLine("Ingrese punto de pedido");
                                    p.setPuntoPedido(int.Parse(Console.ReadLine()));
                                    
                                    do
                                    {
                                        Console.WriteLine("Ingrese maximo de stock permitido");
                                        val = int.Parse(Console.ReadLine());
                                        p.setMaximoStock(val);

                                    } while (val < 0);

                                    do
                                    {
                                        Console.WriteLine("Ingrese stock");
                                        val = int.Parse(Console.ReadLine());
                                        p.setStock(val);
                                    } while (val > p.getMaximoStock());

                                    break;

                                case 2:
                                    Console.WriteLine("Ingrese Codigo de Producto");
                                    p.setCodigo(Console.ReadLine());

                                    Console.WriteLine("Ingrese descripcion del producto");
                                    p.setDescripcion(Console.ReadLine());

                                    break;

                                default:
                                    Console.WriteLine("Opcion invalida");
                                    opc = 0;
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Ingrese la cantidad de productos que desea");
                            p.Comprar(int.Parse(Console.ReadLine()));
                            break;

                        case 3:
                            Console.WriteLine("Ingrese la cantidad de productos a vender");
                            p.Vender(int.Parse(Console.ReadLine()));
                            break;

                        case 4:
                            p.ConsultaStock();
                            break;

                        case 5:
                            Console.WriteLine("Ingrese punto de pedido de stock");
                            p.setPuntoPedido(int.Parse(Console.ReadLine()));
                            break;

                        case 6:
                            Console.WriteLine("Ingrese maximo de stock permitido");
                            p.setMaximoStock(int.Parse(Console.ReadLine()));
                            break;

                        case 7:
                            Console.WriteLine("Ingrese nuevo precio");
                            p.setPrecio(double.Parse(Console.ReadLine()));
                            break;

                        default:
                            Console.WriteLine("Hasta luego!! :)");
                            opc =0;
                            break;
                    }                   
                } while (opc != 0);
            }
        }
    }
}
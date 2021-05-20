using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4b
{
    class Figura
    {
        List<Cuadrado> objcuadrado = new List<Cuadrado>();

        public Figura()
        {
            Menu();
        }



        public void Menu()
        {
            int opc = 0;
            do
            {
                Console.WriteLine("1-Crear figura\n2-Listar Figura\n3-Eliminar figura\n0-Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        AgregarVendedor();
                        break;
                    case 2:
                        ListaVendedores();
                        break;
                    case 3:
                        EliminarVendedor();
                        break;
                }


            } while (opc != 0);
        }

        public void AgregarVendedor()
        {
            objcuadrado.Add(new Cuadrado());
        }

        public void ListaVendedores()
        {
            foreach (Cuadrado c in objcuadrado)
            {
                Console.WriteLine($"{c.ToString()}\n");
            }
        }

        public void EliminarVendedor()
        {
            if (objcuadrado.Count > 0)
            {
                for (int i = 0; i < objcuadrado.Count; i++)
                {
                    Console.WriteLine($"{i}- {objcuadrado[i].ToString()}\n");
                }
                Console.WriteLine("Ingrese el vendedor que desea eliminar");
                int opc = int.Parse(Console.ReadLine());
                objcuadrado.RemoveAt(opc);
            }
        }
    }
}

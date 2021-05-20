using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4a
{
    class Comercio
    {
        List<Vendedor> ven = new List<Vendedor>();

        public Comercio()
        {
            Menu();
        }


        public void Menu()
        {
            int opc = 0;
            do
            {
                Console.WriteLine("1-Ingresar vendedor\n2-Listar vendedores\n3-Eliminar vendedor\n0-Salir");
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
            ven.Add(new Vendedor());
        }

        public void ListaVendedores()
        {
            foreach(Vendedor v in ven)
            {
                Console.WriteLine($"{v.ToString()}\n");
            }
        }

        public void EliminarVendedor()
        {
            if (ven.Count > 0)
            {
                for(int i = 0; i < ven.Count; i++)
                {
                    Console.WriteLine($"{i}- {ven[i].Nombre}");
                }
                Console.WriteLine("Ingrese el vendedor que desea eliminar");
                int opc = int.Parse(Console.ReadLine());
                ven.RemoveAt(opc);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    class Comercio
    {
        private int cuit;

        public Comercio()
        {
            Console.WriteLine("Ingrese cuit del comercio");
            cuit = int.Parse(Console.ReadLine());

        }

        public void VentaAnual(List<Vendedor> ven)
        {
            float venta = 0;
            
                foreach (Vendedor v in ven)
                {
                    venta = v.VentaPrimerSem + v.VentaSegundoSem;
                }


            Console.WriteLine($"La venta anual fue: {venta}");
        }

        public string MejorVentaSem(List<Vendedor> ven)
        {
            string mensaje = "";

            Console.WriteLine("Ingrese DNI para consultar la mejor venta y en que semestre fue");
            int doc = int.Parse(Console.ReadLine());

            if (ven.Count > 0)
            {
                for(int i = 0; ven.Count > i; i++)
                {
                    if (ven[i].Dni == doc)
                    {
                        if (ven[i].VentaPrimerSem > ven[i].VentaSegundoSem)
                        {
                            mensaje = $"La mejor venta se produjo en el Primer semestre y fue por: {ven[i].VentaPrimerSem}";
                        }
                        else if(ven[i].VentaPrimerSem < ven[i].VentaSegundoSem)
                        {
                            mensaje = $"La mejor venta se produjo en el Segundo semestre y fue por: {ven[i].VentaSegundoSem}";
                        }
                        else
                        {
                            mensaje = $"Las ventas fueron iguales en ambos semestres: {ven[i].VentaPrimerSem}";
                        } 
                    }
                }
            }

            return mensaje;
        }

        public void EliminarVendedor(List<Vendedor> ven)
        {
           

            Console.WriteLine("Ingrese DNI del vendedor a eliminar");
            int doc = int.Parse(Console.ReadLine());

            if (ven.Count > 0)
            {
                for (int i = 0; ven.Count > i; i++)
                {
                    if (ven[i].Dni == doc)
                    {
                        ven.RemoveAt(i);
                    }
                }
            }            
        }

    }
}

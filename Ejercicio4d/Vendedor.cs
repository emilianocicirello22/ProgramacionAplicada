using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4d
{
    class Vendedor
    {

        private string nombre;
        private int dni;
        private float ventaPrimerSem;
        private float ventaSegundoSem;
        public int Dni { get => dni; set => dni = value; }
        public float VentaPrimerSem { get => ventaPrimerSem; set => ventaPrimerSem = value; }
        public float VentaSegundoSem { get => ventaSegundoSem; set => ventaSegundoSem = value; }

        public Vendedor()
        {
            Console.WriteLine("Ingrese nombre Y apellido del vendedor");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese DNI del vendedor");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese venta del primer semestre");
            ventaPrimerSem = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese venta del segundo semestre");
            ventaSegundoSem = float.Parse(Console.ReadLine());
        }

        public void VentaMejorSemestre()
        {
            string mensaje = "";
                        
            if (VentaPrimerSem > VentaSegundoSem)
            {
                mensaje = $"La mejor venta se produjo en el Primer semestre y fue por: {VentaPrimerSem}";
            }
            else if (VentaPrimerSem < VentaSegundoSem)
            {
                mensaje = $"La mejor venta se produjo en el Segundo semestre y fue por: {VentaSegundoSem}";
            }
            else
            {
                mensaje = $"Las ventas fueron iguales en ambos semestres: {VentaPrimerSem}";
            }

            Console.WriteLine(mensaje);

        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nDNI: {this.dni}";
        }
    }
}

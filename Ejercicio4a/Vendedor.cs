using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4a
{
    class Vendedor
    {
        private string nombre;
        private int ventaPrimerSem;
        private int ventaSegundoSem;

        public Vendedor()
        {
            Console.WriteLine("Ingrese nombre del vendedor");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese venta del primer semestre");
            this.ventaPrimerSem = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese venta del segundo semestre");
            this.ventaSegundoSem = int.Parse(Console.ReadLine());
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public int ImporteAnual()
        {
            return (this.ventaPrimerSem + this.ventaSegundoSem);
        }

        public string SemestreMejorVenta()
        {
            string mensaje = "";

            if (this.ventaPrimerSem > this.ventaSegundoSem)
            {
                mensaje = $"La mejor venta fue en el primer semestre {this.ventaPrimerSem}";
            }
            else if (this.ventaPrimerSem < this.ventaSegundoSem)
            {
                mensaje = $"La mejor venta fue en el Segundo semestre {this.ventaSegundoSem}";
            }
            else
            {
                mensaje = $"Las ventas fueron iguales en ambos semestres.\nPrimer semestre: {this.ventaPrimerSem}\nSegundo semestre: {this.ventaSegundoSem}";
            }

            return mensaje;
        }

        public override string ToString()
        {
            return $"Vendedor: {this.nombre}.\nVenta anual: {ImporteAnual()}\nSemestre con mejor venta: {SemestreMejorVenta()}";
        }
    }
}

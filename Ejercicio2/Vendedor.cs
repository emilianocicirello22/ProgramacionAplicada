using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Vendedor
    {
        //Atributos

        private string nombre;
        private int ventaPrimerSem;
        private int ventaSegundoSem;

        public Vendedor()
        {

        }

        public Vendedor(string nombre, int venta1, int venta2)
        {
            this.nombre = nombre;
            this.ventaPrimerSem = venta1;
            this.ventaSegundoSem = venta2;
        }


        //Geters Seters

        public void setNombre(string valor)
        {
            this.nombre = valor;
        }

        public void setVentaPrimerSem(int valor)
        {
            this.ventaPrimerSem = valor;
        }

        public void setVentaSegundoSem(int valor)
        {
            this.ventaSegundoSem = valor;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getVentaPrimerSem()
        {
            return this.ventaPrimerSem;
        }

        public int getVentaSegundoSem()
        {
            return this.ventaSegundoSem;
        }

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
            }else if(this.ventaPrimerSem < this.ventaSegundoSem)
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
            return $"Vendedor: {this.nombre}.\nLa venta anual fue de: {ImporteAnual()}\n{SemestreMejorVenta()}";
        }

    }
}

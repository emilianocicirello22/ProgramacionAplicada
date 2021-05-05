using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Notebook:Computadora
    {
        private string tipoPantalla;
        private int tamanioPantalla;
        private Boolean HDD = false;
        private int tamanioDisco;
        private int cantidadTeclas;

        public Notebook()
        {
            Console.WriteLine("Ingrese tipo de pantalla");
            this.tipoPantalla = Console.ReadLine();

            Console.WriteLine("Ingrese Pulgadas de pantalla");
            this.tamanioPantalla = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique escribiendo SI o NO si tiene Disco Solido");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.HDD = true;

            }

            Console.WriteLine("Indique tamaño del disco rigido");
            this.tamanioDisco = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de teclas");
            this.cantidadTeclas = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            string mensajeHDD = "";
            if (this.HDD)
            {
                mensajeHDD += "Posee HDD";
            }
            else
            {
                mensajeHDD += "No posee HDD";
            }

            return $"{base.ToString()}\nTipo de pantalla: {this.tipoPantalla}\nTamaño de pantalla: {this.tamanioPantalla} pulgadas\n{mensajeHDD}\nTamaño de disco: {this.tamanioDisco}\nCantidad de teclas: {this.cantidadTeclas}";
        }
    }
}

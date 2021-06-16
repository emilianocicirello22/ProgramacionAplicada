using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    class Smartphone:Computadora
    {
        private string tipoPantalla;
        private int tamanioPantalla;
        private int cantidadChip;
        private int cantidadFrecuencias;
        static int contSmart = 0;

        public static int ContSmart { get => contSmart; set => contSmart = value; }

        public Smartphone()
        {
            Console.WriteLine("Ingrese tipo de pantalla");
            this.tipoPantalla = Console.ReadLine();

            Console.WriteLine("Ingrese Pulgadas de pantalla");
            this.tamanioPantalla = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Cantidad de chips soportados");
            this.cantidadChip = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Cantidad de frecuencias soportadas");
            this.cantidadFrecuencias = int.Parse(Console.ReadLine());

            Equipo = "Smartphone";
            contSmart++;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Tipo de pantalla: {this.tipoPantalla}\nTamaño de pantalla: {this.tamanioPantalla} pulgadas\nChip: {this.cantidadChip}\nFrecuencia: {this.cantidadFrecuencias}\n";
        }
    }
}

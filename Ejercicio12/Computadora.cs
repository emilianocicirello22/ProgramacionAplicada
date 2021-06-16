using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
    class Computadora
    {
        private static int contador;
        private string CPU;
        private float velocidad;
        private int tamañoRam;
        private string equipo;

        public static int Contador { get => contador; set => contador = value; }
        public string CPU1 { get => CPU; set => CPU = value; }
        public float Velocidad { get => velocidad; set => velocidad = value; }
        public int TamañoRam { get => tamañoRam; set => tamañoRam = value; }
        public string Equipo { get => equipo; set => equipo = value; }

        public Computadora()
        {
            contador++;

            Console.WriteLine("Indique nombre de CPU");
            this.CPU = Console.ReadLine();

            Console.WriteLine("Indique GHz del CPU");
            this.velocidad = float.Parse(Console.ReadLine());

            Console.WriteLine("Indique tamaño de memoria RAM");
            this.TamañoRam = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"*****Equipo:{this.equipo}*****\nMicroprocesador: {this.CPU}\nVelocidad: {this.velocidad}GHz\nRam: {this.tamañoRam} GB\n";
        }
    }
}

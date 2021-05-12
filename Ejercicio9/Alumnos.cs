using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Alumnos
    {
        private string nombre;
        private double[] notas = new double[10];
        private Boolean Aprobado = false;
        static int Desaprobado;
        private double promedio; 
        public string Nombre { get => nombre; set => nombre = value; }
        public double[] Notas { get => notas; set => notas = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        public bool Aprobado1 { get => Aprobado; set => Aprobado = value; }
        

        public Alumnos()
        {
            Console.WriteLine("Ingrese nombre del alumno");
            this.nombre = Console.ReadLine();

            for(int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"Ingrese nota numero {i + 1}");
                Notas[i] = double.Parse(Console.ReadLine());
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{
    class Libro
    {
        private string titulo;
        private string autor;
        private string genero;
        private int ejemplares;
        private int ejemPrestamo;

        public Libro()
        {
            Console.WriteLine("Ingrese titulo del libro");
            this.titulo = Console.ReadLine();
            Console.WriteLine("Ingrese autor del libro");
            this.autor = Console.ReadLine();
            Console.WriteLine("Ingrese genero del libro");
            this.genero = Console.ReadLine();
            Console.WriteLine("Ingrese numero de ejemplares");
            this.ejemplares = int.Parse(Console.ReadLine());
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Ejemplares { get => ejemplares; set => ejemplares = value; }
        public int EjemPrestamo { get => ejemPrestamo; set => ejemPrestamo = value; }

        public override string ToString()
        {
            return $"Titulo: {this.titulo}\nAutor: {this.autor}\nGénero: {this.genero}\nEjemplares: {this.ejemplares}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4c
{


    class Rectangulo
    {

        //Atributos
        private double longitudLado1;
        private double longitudLado2;

        //Constructores      

        public Rectangulo()
        {
            Console.WriteLine("Ingrese base del triangulo");
            this.longitudLado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triangulo");
            this.longitudLado2 = double.Parse(Console.ReadLine());

        }

        public double LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }
        public double LongitudLado2 { get => longitudLado2; set => longitudLado2 = value; }


        //Metodo que calcula e informa el perimetro del rectangulo
        public double Perimetro()
        {
            //variable donde se almacenara el  perimetro
            double per = 0;
            //calculo del perimetro
            per = (this.longitudLado1 * 2) + (this.longitudLado2 * 2);

            //mensaje donde se indica el perimetro
            return per;
        }

        //Metodo que calcula e informa la superficie del rectangulo
        public double Superficie()
        {

            //variable donde se almacenara la superficie
            double sup = 0;

            //calculo de la superficie
            sup = this.longitudLado1 * this.longitudLado2;

            // mensaje donde se indica la superficie
            return sup;

        }
        public override string ToString()
        {
            return $"Rectangulo con base {this.longitudLado1} y altura {this.longitudLado2}\nEl perimetro es: {Perimetro()}.\nLa superficie es: {Superficie()}";
        }
    }
}

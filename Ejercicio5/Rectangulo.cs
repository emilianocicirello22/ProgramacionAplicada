using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Rectangulo
    {

        //Atributos
        private double longitudLado1;
        private double longitudLado2;

        //Constructores
        public Rectangulo()
        {

        }

        public Rectangulo(double a, double b)
        {
            this.longitudLado1 = a;
            this.longitudLado2 = b;

        }

        //Geter Seter
        
        public void setAltura(double a)
        {
            this.longitudLado1 = a;
        }

        public void setBase(double b)
        {
            this.longitudLado2 = b;
        }

        public double getAltura()
        {
            return this.longitudLado1;
        }

        public double getBase()
        {
            return this.longitudLado2;
        }

        //Metodo que calcula e informa el perimetro del rectangulo
        public void Perimetro()
        {
            //variable donde se almacenara el  perimetro
            double per = 0;
            //calculo del perimetro
            per = (getAltura() * 2) + (getBase() * 2);

            //mensaje donde se indica el perimetro
            Console.WriteLine($"El perimetro del rectangulo es: {per}");
        }

        //Metodo que calcula e informa la superficie del rectangulo
        public void Superficie()
        {

            //variable donde se almacenara la superficie
            double sup = 0;

            //calculo de la superficie
            sup = getBase() * getAltura();

            // mensaje donde se indica la superficie
            Console.WriteLine($"La superficie del rectangulo es: {sup}");

        }
    }
}

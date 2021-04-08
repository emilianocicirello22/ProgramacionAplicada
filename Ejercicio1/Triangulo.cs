using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Triangulo
    {
        //Atributos
        private int longitud1;
        private int longitud2;
        private int longitud3;
        private int altura;

        //Constructores
        public Triangulo() { }

        public Triangulo(int longitud1, int longitud2, int longitud3, int altura)
        {
            this.longitud1 = longitud1;
            this.longitud2 = longitud2;
            this.longitud3 = longitud3;
            this.altura = altura;
        }

        

        //Geters Seters

        public void setLongitud1(int valor)
        {
           this.longitud1=valor;
        }

        public void setLongitud2(int valor)
        {
            this.longitud2 = valor;
        }

        public void setLongitud3(int valor)
        {
            this.longitud3 = valor;
        }

        public void setAltura(int valor)
        {
            this.altura = valor;
        }

        public int getLongitud1()
        {
            return this.longitud1;
        }

        public int getLongitud2()
        {
            return this.longitud2;
        }

        public int getLongitud3()
        {
            return this.longitud3;
        }

        public int getAltura()
        {
            return this.altura;
        }

        //Metodo que calcula el Perimetro del Triangulo
        public int Perimetro()
        {
            return (this.longitud1 + this.longitud2 + this.longitud3);
        }

        //Metodo que calcula la superficie del Triangulo
        public double Superficie()
        {
            return ((double)this.longitud3 * (this.altura / 2));
        }

        public override string ToString()
        {
            return $"El perimetro de triangulo es: {Perimetro()} y su superficie es: {Superficie()}";
        }
    }
}

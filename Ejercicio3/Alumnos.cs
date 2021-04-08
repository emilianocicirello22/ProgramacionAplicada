using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Alumnos
    {
        //Atributos
        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double nota5;
        private double nota6;
        private double nota7;
        private double nota8;
        private double nota9;
        private double nota10;

        //Constructores

        public Alumnos()
        {

        }

        public Alumnos(string nombre, double nota1, double nota2, double nota3, double nota4, double nota5, double nota6, double nota7, double nota8, double nota9, double nota10)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.nota5 = nota5;
            this.nota6 = nota6;
            this.nota7 = nota7;
            this.nota8 = nota8;
            this.nota9 = nota9;
            this.nota10 = nota10;
        }

        //Geters Seters

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNota1(double nota)
        {
            this.nota1 = nota;
        }

        public void setNota2(double nota)
        {
            this.nota2 = nota;
        }

        public void setNota3(double nota)
        {
            this.nota3 = nota;
        }

        public void setNota4(double nota)
        {
            this.nota4 = nota;
        }

        public void setNota5(double nota)
        {
            this.nota5 = nota;
        }

        public void setNota6(double nota)
        {
            this.nota6 = nota;
        }

        public void setNota7(double nota)
        {
            this.nota7 = nota;
        }

        public void setNota8(double nota)
        {
            this.nota8 = nota;
        }

        public void setNota9(double nota)
        {
            this.nota9 = nota;
        }

        public void setNota10(double nota)
        {
            this.nota10 = nota;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getNota1()
        {
            return this.nota1;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public double getNota3()
        {
            return this.nota3;
        }
        public double getNota4()
        {
            return this.nota4;
        }
        public double getNota5()
        {
            return this.nota5;
        }
        public double getNota6()
        {
            return this.nota6;
        }
        public double getNota7()
        {
            return this.nota7;
        }
        public double getNota8()
        {
            return this.nota8;
        }
        public double getNota9()
        {
            return this.nota9;
        }
        public double getNota10()
        {
            return this.nota10;
        }



        //Funcion que calcula y retorna el promedio del alumno
        public double Promedio()
        {
            return ((this.nota1 + this.nota2 + this.nota3 + this.nota4 + this.nota5 + this.nota6 + this.nota7 + this.nota8 + this.nota9 + this.nota10) / 10);
        }

        //Funcion que calcula si el alumno esta aprobado
        public Boolean Aprobado()
        {
            Boolean aprov = false;

            if ((this.nota1 >= 4) && (this.nota2 >= 4) && (this.nota3 >= 4) && (this.nota4 >= 4) && (this.nota5 >= 4) && (this.nota6 >= 4) && (this.nota7 >= 4) && (this.nota8 >= 4) && (this.nota9 >= 4) && (this.nota10 >= 4))
            {
                aprov = true;
            }

            return aprov;

        }

        public override string ToString()
        {
            string mensaje = "";

            if (Aprobado())
            {
                mensaje = $"El alumno {getNombre()} esta aprobado";
            }
            else
            {
                mensaje = $"El alumno {getNombre()} esta reprobado";
            }

            return $"{mensaje}. Su promedio fue de: {Promedio()}";
        }

    }


}

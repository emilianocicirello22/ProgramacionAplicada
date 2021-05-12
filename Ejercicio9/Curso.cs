using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Curso
    {
        static int desaprobado;
        private string nombre;
        private int mayorProm;
        

        public Curso()
        {
            Console.WriteLine("Ingrese nombre del curso" );
            this.nombre = Console.ReadLine();
            
        }

        public void Promedio(List<Alumnos> a)
        {
            
            
            for (int i = 0; i < a.Count; i++)
            {
                for(int j = 0; j < a[i].Notas.Length; j++)
                {
                    a[i].Promedio += a[i].Notas[j];

                }

                a[i].Promedio = a[i].Promedio / 10;
            }
        }

        public void Aprobado(List<Alumnos> a)
        {

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Promedio >= 4)
                {
                    a[i].Aprobado1 = true;
                }                
            }
        }

        public void Desaprobado(List<Alumnos> a)
        {
            foreach(Alumnos alu in a)
            {
                if (!alu.Aprobado1)
                {
                    desaprobado++;
                }
            }             
        }
        
        public string MejorProm(List<Alumnos> a)
        {
            string alumno = "";
            double prom = 0;

            for(int i = 0; i < a.Count; i++)
            {
                for(int j = 0; j < a.Count; j++)
                {
                    if (a[i].Promedio <= a[j].Promedio)
                    {
                        alumno = a[j].Nombre;
                        prom = a[j].Promedio;
                    }
                }
            }
            return $"El alumno con mejor promedio es: {alumno} con un promedio de {prom}";
        }

        public override string ToString()
        {

            return $"{this.nombre}\nDesaprobaron {desaprobado} Alumnos.";
        }
    }
}

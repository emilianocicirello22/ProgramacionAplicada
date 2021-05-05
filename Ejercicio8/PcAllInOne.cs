using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class PcAllInOne:PcEscritorio
    {
        private int tipoPantalla;
        private int tamanioPantalla;
        private Boolean pantallaTactil = false;
        private int cantidadTeclas;

        public PcAllInOne()
        {
            Console.WriteLine("Ingrese tipo de pantalla\n1-Plasma\n2-LCD\n3-LED\n4-Touchscreen\n5-MultiTouch");
            this.tipoPantalla = int.Parse(Console.ReadLine());

            if (this.tipoPantalla == 4 || this.tipoPantalla == 5)
            {
                this.pantallaTactil = true;
            }

            Console.WriteLine("Ingrese Pulgadas de pantalla");
            this.tamanioPantalla = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de teclas");
            this.cantidadTeclas = int.Parse(Console.ReadLine());

            Equipo = "All in one";
        }

        public override string ToString()
        {
            string tpantalla = "";
            string tactil = "";
            switch (this.tipoPantalla)
            {
                case 1:
                    tpantalla = "Plasma";
                    break;

                case 2:
                    tpantalla = "LCD";
                    break;

                case 3:
                    tpantalla = "LED";
                    break;

                case 4:
                    tpantalla = "Touchscreen";
                    break;

                case 5:
                    tpantalla = "MultiTouch";
                    break;
                default:
                    tpantalla = "No especificado";
                    break;

            }

            if (pantallaTactil)
            {
                tactil = "SI";
            }
            else
            {
                tactil = "NO";
            }

            return $"{base.ToString()}Tipo de pantalla: {tpantalla}\nPantalla tactil: {tactil}\nTamaño de pantalla: {this.tamanioPantalla} pulgadas\nCantidad de teclas: {this.cantidadTeclas}\n";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class PcEscritorio:Computadora
    {
        private string tamanioGabinete;
        private Boolean DVD = false;
        private Boolean HDD = false; 
        private int tamanioDisco;

        public PcEscritorio()
        {
            Console.WriteLine("Indique tamaño de gabinete");
            this.tamanioGabinete = Console.ReadLine();


            Console.WriteLine("Indique escribiendo SI o NO si tiene reproductor de DVD");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.DVD = true;

            }

            Console.WriteLine("Indique escribiendo SI o NO si tiene Disco Solido");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.HDD = true;

            }

            Console.WriteLine("Indique tamaño del disco rigido");
            this.tamanioDisco = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            string mensajeHDD = "HDD: ";
            string mensajeDVD = "DVD: ";

            if (this.DVD)
            {
                mensajeDVD += "Posee DVD";
            }
            else
            {
                mensajeDVD += "No posee DVD";
            }

            if (this.HDD)
            {
                mensajeHDD += "Posee HDD";
            }
            else
            {
                mensajeHDD += "No posee HDD";
            }


            return $"{base.ToString()}Gabinete: {this.tamanioGabinete}\n{mensajeDVD}\n{mensajeHDD}\nTamaño de disco: {this.tamanioDisco}\n";
        }
    }
}

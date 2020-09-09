using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Galletita galletita = new Galletita();
            Horno horno1 = new Horno();

            Fecha fechaNac = new Fecha(1988, 12, 12);

            /*
            new Galletita[1] { galletita }
            Galletita[] arrayGalletita;
            arrayGalletita = new Galletita[1];
            arrayGalletita[1] = galletita;
            */

            horno1.Hornear(new Galletita[1] { galletita });
        }
    }
}

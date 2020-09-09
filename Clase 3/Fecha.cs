using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Fecha
    {
        int anio;
        int mes;
        int dia;

        public Fecha(int anio, int mes, int dia)
        {
            this.anio = anio;
            this.mes = mes;
            this.dia = dia;
        }

        public int CalcularEdad()
        {
            int edad;

            edad = DateTime.Now.Year - this.anio;

            if( this.mes > DateTime.Now.Month && this.dia > DateTime.Now.Day)
            {
                edad--;
            }


            return edad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Valores por defecto
             * Enteros = 0
             * Punto flotante = 0
             * Lógicos = False
             * Referencias = Null           
             * 
             * POR DEFECTO TODO ES PRIVADO
             */

            //declarar una constante
            //const int PUERTOWEB = 80;

            int cero = 0;
            int numero = 250;
            double numeroLargo = 111;
            string valorEnTexto = "22";
            bool logico = true;
            
            Program miPrograma;            

            if (numero == 5)
                numero = 2;

            //Conversion explicita
            //Casteo para no perder datos de un tipo de dato largo a uno mas corto
            numero = (int)numeroLargo;

            //Conversion implicita
            numeroLargo = numero;

            //Conversion por parseo
            numero = int.Parse(valorEnTexto);

            //Conversion de una palabra a valor logico
            logico = bool.Parse("true");

            //Ternario
            logico = cero == 0 ? false:true;

            //variable = condicion ? verdadero : falso ;
            if (cero == 0)
                return false;
            else
                return true;


            int valorPrueba = 25.5f;

        }

        void metodo(Program miPrograma)
        {
            string texto = "2";
            bool logico2; // = false;

            logico2 = miPrograma == null;
            if (logico2)
                texto = String.Empty;
        }
    }
}

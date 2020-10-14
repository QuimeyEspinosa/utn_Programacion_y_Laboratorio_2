using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Ejercicio nro 2: 
             * Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
             * mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
             * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
             */

            double numero = 0;

            Console.Write("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out numero);


            while (numero < 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                double.TryParse(Console.ReadLine(), out numero);
            }

            Console.Write("\nNumero al cuadrado: {0}\n", Math.Pow(numero, 2));
            Console.Write("Numero al cubo: {0}", Math.Pow(numero, 3));


            Console.ReadKey();
        }
    }
}

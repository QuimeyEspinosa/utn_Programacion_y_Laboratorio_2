using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio nro 1: 
             * Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: 
             * el valor máximo, el valor mínimo y el promedio.
             */

            int[] numeros = new int[5];
            bool flagMax = false;
            bool flagMin = false;
            int numMax = 0;
            int numMin = 0;
            double acumPromedio = 0;

            Console.Write("Ingrese 5 numeros\n\n");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Usted ha ingresado {0} numeros: ", i);
                int.TryParse(Console.ReadLine(), out numeros[i]);


                if (numeros[i] > numMax || flagMax == false)
                {
                    numMax = numeros[i];
                    flagMax = true;
                }

                if (numeros[i] < numMin || flagMin == false)
                {
                    numMin = numeros[i];
                    
                    flagMin = true;
                }

                acumPromedio += numeros[i];
            }

            Console.Write("\nEl numero máximo es: {0}\n", numMax);
            Console.Write("El numero mínimo es: {0}\n", numMin);
            Console.Write("El promedio es: {0}\n", acumPromedio / 2);

            Console.ReadKey();
        }
    }
}

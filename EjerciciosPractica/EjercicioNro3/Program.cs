using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio nro 3:
             * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
             * por consola.
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */
            int numero = 0;

            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numero);
            while (numero < 1)
            {
                Console.Write("Error, reingrese: ");
                int.TryParse(Console.ReadLine(), out numero);
            }


            Console.Write($"Los numeros primos hasta el {numero} son:\n\n");
            for (int i = 0; i <= numero; i++)
            {
                if (esPrimo(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadKey();
        }

        static bool esPrimo(int numero)
        {
            bool esPrimo = false;
            int cont = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                esPrimo = true;
            }

            return esPrimo;
        }
    }
}

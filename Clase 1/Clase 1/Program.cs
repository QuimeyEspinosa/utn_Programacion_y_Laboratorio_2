using System;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //modificar colores y titulo de la consola
            /*
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Mi proyecto";
            */

            //sumar la hora actual con los segundos solo si alguno es mayor a 25

            DateTime horaActual = DateTime.Now;

            int salida = suma(horaActual.Minute, horaActual.Second);

            Console.Write("El resultado es: " + salida);
            //Console.Write("El resultado es: " + salida.ToString());
            //Console.WriteLine(salida);

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                case "2":
                    salida = suma(salida, horaActual.Second);
                    break;
                case "3":
                    salida = suma(horaActual.Minute, 4);
                    break;
                default:
                    salida = 0;
                    break;
            }

            //pedir 5 nombres y mostrarlos en pantalla

            string[] nombres;
            nombres = new string[5];



            //pedir con for
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese 5 nombres: ");
                nombres[i] = Console.ReadLine();
            }

            //mostrar con for
            for (int i = 0; i < 5; i++)
            {
                Console.Write(nombres[i] + "\n");
            }


            //mostrar con foreach
            foreach (string item in nombres)
            {
                Console.WriteLine("El {1,2:}:{2,2}:{3,2} nombre es {0}", item, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            }


            Console.ReadLine();

        }

        static int suma(int numero1, int numero2)
        {
            int resultado = 0;

            if (numero1 > 25 || numero2 > 25)
                resultado = numero1 + numero2;

            return resultado;
        }
    }
}

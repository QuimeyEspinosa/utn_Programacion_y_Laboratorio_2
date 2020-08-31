using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] listaMascotas = new Mascota[4];
            byte opcion;
            string mascotaBuscada;


            Console.Write("|  | | |||| Veterinaria |||| | |  |\n\n");
            Console.Write("Debe ingresar 4 mascotas\n\n\n");


            for (int i = 0; i < listaMascotas.Length; i++)
            {
                listaMascotas[i] = new Mascota();
                listaMascotas[i].altaMascota();
                Console.Write("\n");
            }

            for (int i = 0; i < listaMascotas.Length; i++)
            {
                listaMascotas[i].mostrarMascota();
            }

            do
            {
                Console.Write("Que desea realizar?\n\n");
                Console.Write("1-Mostrar informes\n");
                Console.Write("2-Ingresar nombre de mascota y mostrar sus datos\n\n");
                Console.Write("Ingrese opcion deseada: ");
                byte.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Promedio de pesos totales: {0}\n", calcularPromedio(listaMascotas));
                        Console.WriteLine("El perro mas viejo es: \n{0}\n", masViejo(listaMascotas));
                        listaFiltrada(listaMascotas);
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese nombre de mascota a buscar: ");
                        mascotaBuscada = Console.ReadLine();
                        while (String.IsNullOrEmpty(mascotaBuscada))
                        {
                            Console.Write("Error, reingrese nombre de mascota: ");
                            mascotaBuscada = Console.ReadLine();
                        }
                        for (int i = 0; i < listaMascotas.Length; i++)
                        {
                            if (listaMascotas[i].getNombre() == mascotaBuscada)
                            {
                                listaMascotas[i].mostrarMascota();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No se encuentra la mascota buscada\n");
                            }
                        }
                        break;

                    default:
                        opcion = 3;
                        break;
                }
            }
            while (opcion < 3);

            Console.ReadKey();
        }

        static double calcularPromedio(Mascota[] lista)
        {
            double acumuladorPesos = 0;
            double resultado;

            for (int i = 0; i < lista.Length; i++)
            {
                acumuladorPesos += lista[i].getPeso();
            }
            resultado = acumuladorPesos / lista.Length;

            return resultado;
        }

        static string masViejo(Mascota[] lista)
        {
            bool flag = false;
            string elMasViejo = "";
            int auxEdad = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].getEdad() > auxEdad || flag == false)
                {
                    auxEdad = lista[i].getEdad();
                    elMasViejo = lista[i].getNombre();
                    flag = true;
                }
            }

            return elMasViejo;
        }


        static void listaFiltrada(Mascota[] lista)
        {
            Console.WriteLine("Las mascotas menores a 10kg de peso y mayores a 10 años son:\n\n");

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].getPeso() < 10 && lista[i].getEdad() > 10)
                {
                    Console.WriteLine($"Nombre: {lista[i].getNombre()}\n");
                    Console.WriteLine($"Tipo: {lista[i].getTipo()}\n\n");
                }
            }
        }
    }
}

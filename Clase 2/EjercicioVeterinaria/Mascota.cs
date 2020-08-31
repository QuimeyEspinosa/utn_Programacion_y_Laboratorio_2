using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVeterinaria
{
    class Mascota
    {
        string tipo;
        int edad;
        double peso;
        string nombre;

        //---------------Setters---------------------

        public void setTipo(string tipoMascota)
        {
            this.tipo = tipoMascota;
        }

        public void setEdad(int edadMascota)
        {
            this.edad = edadMascota;
        }

        public void setPeso(double pesoMascota)
        {
            this.peso = pesoMascota;
        }

        public void setNombre(string nombreMascota)
        {
            this.nombre = nombreMascota;
        }

        //---------------Getters---------------------

        public string getTipo()
        {
            return this.tipo;
        }
        public int getEdad()
        {
            return this.edad;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //------------------------------------------------------

        public void altaMascota()
        {
            string auxTipo;
            int auxEdad;
            double auxPeso;
            string auxNombre;


            Console.Write("Ingrese tipo de mascota: ");
            auxTipo = Console.ReadLine();
            while (String.IsNullOrEmpty(auxTipo) || auxTipo != "perro" && auxTipo != "gato")
            {
                Console.Write("Error, el tipo debe ser 'perro' o 'gato': ");
                auxTipo = Console.ReadLine();
            }
            this.setTipo(auxTipo);

            Console.Write("Ingrese edad de mascota: ");
            int.TryParse(Console.ReadLine(), out auxEdad);
            while (auxEdad < 1 || auxEdad > 25)
            {
                Console.Write("Error, la edad debe estar entre 1 y 25: ");
                int.TryParse(Console.ReadLine(), out auxEdad);
            }
            this.setEdad(auxEdad);

            Console.Write("Ingrese peso de mascota: ");
            double.TryParse(Console.ReadLine(), out auxPeso);
            while (auxPeso < 1 || auxPeso > 100)
            {
                Console.Write("Error, el peso debe estar entre 1 y 100: ");
                double.TryParse(Console.ReadLine(), out auxPeso);
            }
            this.setPeso(auxPeso);

            Console.Write("Ingrese nombre de mascota: ");
            auxNombre = Console.ReadLine();
            while (String.IsNullOrEmpty(auxNombre))
            {
                Console.Write("Error, reingrese nombre de mascota: ");
                auxNombre = Console.ReadLine();
            }
            this.setNombre(auxNombre);

        }

        public void mostrarMascota()
        {
            Console.Write("Tipo: {0}\nEdad: {1}\nPeso: {2}\nNombre: {3}\n\n", this.tipo, this.edad, this.peso, this.nombre);
        }

        public double promedioPesosTotales(Mascota[] lista)
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
    }
}

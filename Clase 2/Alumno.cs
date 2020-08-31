using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Alumno
    {
        public byte nota1;
        public byte nota2;
        public float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;


        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random random = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = (byte)random.Next(0,10);
            }
            else
            {
                this.notaFinal = -1;
            }
                
        }

        public void Mostrar()
        {
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nombre: {0} Apellido: {1} Legajo: {2} Primer nota: {3} Segunda nota: {4} Nota final: {5} \n", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, this.notaFinal);
            }
            else
            {
                Console.WriteLine("Nombre: {0} Apellido: {1} Legajo: {2} Primer nota: {3} Segunda nota: {4} Nota final: Alumno desaprobado \n", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2);
            }
        }
    }
}

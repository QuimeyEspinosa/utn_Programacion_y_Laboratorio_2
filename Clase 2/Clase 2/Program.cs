using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Quimey";
            alumno2.nombre = "Santiago";
            alumno3.nombre = "Alejo";
            alumno1.apellido = "Espinosa";
            alumno2.apellido = "Anllo";
            alumno3.apellido = "Carmona";
            alumno1.legajo = 1033;
            alumno2.legajo = 1034;
            alumno3.legajo = 1038;

            alumno1.Estudiar(4, 6);
            alumno2.Estudiar(5, 6);
            alumno3.Estudiar(9, 10);

            Console.Write("--- Notas alumnos ---\n\n");

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey();
        }
    }
}

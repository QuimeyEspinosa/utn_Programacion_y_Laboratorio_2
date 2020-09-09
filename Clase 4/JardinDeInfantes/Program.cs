using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinDeInfantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] arrayAlumnos = new Alumno[5];

            arrayAlumnos[0] = new Alumno("pepito", "juancito", 0000);
            arrayAlumnos[1] = new Alumno("pepito", "juancito", 1111);
            arrayAlumnos[2] = new Alumno("pepito", "juancito", 2222);
            arrayAlumnos[3] = new Alumno("pepito", "juancito", 3333);
            arrayAlumnos[4] = new Alumno("pepito", "juancito", 4444);

            Alumno miAlumno = new Alumno("pepito", "juancito", 4444);

            if(arrayAlumnos == miAlumno)
            {
                Console.WriteLine("Existe el estudiante\n\n");
            }

            if(arrayAlumnos + miAlumno)
            {

            }




            Alumno alumno1 = new Alumno("Quimey", "Espinosa", 1234);
            JardinDeInfantes.AgregarAlumno(alumno1);

            JardinDeInfantes.AgregarAlumno(new Alumno("Quimey", "Espinosa", 1234));


            Console.ReadKey();
        }
    }
}

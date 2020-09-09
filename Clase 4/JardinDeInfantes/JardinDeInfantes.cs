using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinDeInfantes
{
    static class JardinDeInfantes
    {
        static Docente[] arrayDocentes;
        static Alumno[] arrayAlumnos;

        static JardinDeInfantes() //constructor estatico de jardin de infantes, se llama una vez
        {
            arrayDocentes = new Docente[5];
            arrayAlumnos = new Alumno[30];
        }


        /// <summary>
        /// agrega un alumno en la ubicacion disponible del array de alumnos
        /// </summary>
        /// <param name="unAlumno"></param>
        /// <returns></returns>
        public static bool AgregarAlumno(Alumno unAlumno)
        {
            bool retorno = false;

            for (int i = 0; i < arrayAlumnos.Length; i++)
            {
                if (arrayAlumnos[i] == null)
                {
                    arrayAlumnos[i] = unAlumno;
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}

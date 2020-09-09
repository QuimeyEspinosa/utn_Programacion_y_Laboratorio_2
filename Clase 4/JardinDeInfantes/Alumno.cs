using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinDeInfantes
{
    class Alumno
    {
        int dni;
        string nombre;
        string apellido;
        int edad;
        int alturaEnCm;
        string direccion;

        public Alumno(string nombre, string apellido, int dni, int alturaEnCm)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.alturaEnCm = alturaEnCm;
        }

        public Alumno(string nombre, string apellido, int dni, string direccion) : this(nombre, apellido, dni)
        {
            this.direccion = direccion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Alumno(string nombre, string apellido, int dni) : this()
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        //ctor tab tab crear constructor
        private Alumno()
        {
            this.nombre = "sin nombre";   // string.Empty; // ""
            this.apellido = "sin apellido";
            this.dni = -1;
            this.alturaEnCm = -1;
            this.direccion = "sin direccion";
        }


        public static bool operator ==(Alumno[] arrayAux, Alumno auxAlumno) //sobre carga de un operador
        {
            bool retorno = false;

            for (int i = 0; i < arrayAux.Length; i++)
            {
                if (arrayAux[i].dni == auxAlumno.dni)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Alumno[] arrayAux, Alumno auxAlumno) //sobre carga de un operador (debe aclararse la negacion)
        {
            return !(arrayAux == auxAlumno);
        }

        public static bool operator +(Alumno[] arrayAux, Alumno auxAlumno) //sobre carga de un operador
        {
            bool retorno = false;

            if (arrayAux != auxAlumno)
            {
                for (int i = 0; i < arrayAux.Length; i++)
                {
                    if (arrayAux[i] == null)
                    {
                        arrayAux[i] = auxAlumno;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }


        public static bool operator -(Alumno[] arrayAux, Alumno auxAlumno) //sobre carga de un operador
        {
            bool retorno = false;

            if (arrayAux != auxAlumno)
            {
                for (int i = 0; i < arrayAux.Length; i++)
                {
                    if (arrayAux[i] == auxAlumno)
                    {
                        arrayAux[i] = null;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}

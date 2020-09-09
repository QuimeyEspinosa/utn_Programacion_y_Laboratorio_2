using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        private string nombre;
        private string apellido;
        private string especialidad;
        private int dni;

        public Medico(string nombre, string apellido, string especialidad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.dni = dni;
        }



    }
}

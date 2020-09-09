using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Enfermedad
    {
        string nombre;
        string[] sintomas;

        private Enfermedad()
        {
            sintomas = new string[4];
        }

        public Enfermedad(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Enfermedad(string nombre, string[] sintomas) : this(nombre)
        {
            this.sintomas = sintomas;
        }
    }
}

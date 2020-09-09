using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Paciente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private Enfermedad dolencia;
        private string descripcionDolencia;

        public Paciente(string nombre, string apellido, int dni, Enfermedad dolencia, string descripcionDolencia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.Dolencia = dolencia;
            this.descripcionDolencia = descripcionDolencia;
        }

        public Enfermedad Dolencia  //Propiedad Dolencia (Va con mayúscula)
        {
            set { dolencia = value; }
            get { return dolencia; }
        }

        public void SetEnfermedad(Enfermedad dolencia) //Set dolencia
        {
            this.dolencia = dolencia;
        }

    }
}

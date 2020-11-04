using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        int id;
        string nombre;
        string apellido;
        int dni;

        public Persona(int id, string nombre, string apellido, int dni)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();

            datosPersona.AppendFormat($"El id es: {Id}");
            datosPersona.AppendFormat($"El nombre es: {Nombre}");
            datosPersona.AppendFormat($"El apellido es: {Apellido}");
            datosPersona.AppendFormat($"El dni es: {Dni}");
            datosPersona.AppendLine();

            return datosPersona.ToString();
        }
    }
}

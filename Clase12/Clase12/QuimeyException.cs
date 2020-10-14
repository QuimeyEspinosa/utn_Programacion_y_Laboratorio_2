using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    class QuimeyException : Exception
    {
        public QuimeyException(string mensaje) : base("El mensaje personalizado es :  " + mensaje)
        {
        }

    }
}

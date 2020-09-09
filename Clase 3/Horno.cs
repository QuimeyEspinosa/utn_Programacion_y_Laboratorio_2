using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Horno
    {
        Galletita[] galletitas;

        public bool Hornear(Galletita[] galletitas)
        {
            foreach (Galletita item in galletitas)
            {
                item.hornear();
            }
        }
    }
}

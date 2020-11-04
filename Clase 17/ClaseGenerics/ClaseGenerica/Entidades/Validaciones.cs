using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica.Entidades
{
    public class Validaciones
    {
        public static bool ValidarValor<T>(T minimo, T maximo, T valorAValidar) where T : IComparable
        {
            if (minimo.CompareTo(maximo) > 0)
            {
                throw new InvalidOperationException("El minimo debe ser mayor al maximo");
            }
            else
            {
                return (valorAValidar.CompareTo(maximo) < 0 && valorAValidar.CompareTo(minimo) > 0);
            }
        }
    }
}

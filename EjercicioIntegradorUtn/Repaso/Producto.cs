using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        /// <summary>
        /// Inicializa un producto
        /// </summary>
        /// <param name="codigoDeBarra">Codigo del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="precio">Precio del producto</param>
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        /// <summary>
        /// Getter de marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Getter de precio
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string cadenaDatos;

            cadenaDatos = "Producto: " + p.marca + ", " + p.precio + ", " + p.codigoDeBarra;

            return cadenaDatos;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1 == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Producto p, string marcaPasada)
        {
            bool retorno = false;
                        
            if (!(p is null) && p.marca == marcaPasada)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p, string marcaPasada)
        {
            return !(p == marcaPasada);
        }

    }
}

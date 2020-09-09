using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }


        public static string MostrarEstante(Estante e)
        {
            string cadenaDatos;

            cadenaDatos = "Estante: " + e.ubicacionEstante + ", " + e.GetProductos();

            return cadenaDatos;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if (e != p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    Producto[] productosAux = e.GetProductos();
                    if (productosAux[i] is null)
                    {
                        productosAux[i] = p;
                        retorno = true;
                    }
                }

            }

            return retorno;
        }


        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = false;

            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                Producto[] productosAux = e.GetProductos();
                if (productosAux[i] == p)
                {
                    productosAux[i] = null;
                    retorno = true;
                }
            }

            return retorno;
        }







    }
}

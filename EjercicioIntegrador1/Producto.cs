using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    class Producto
    {
        string nombre;
        int idProducto;
        string categoria;
        float precio;
        int stockActual;
        int vendidos;

        public Producto()
        {
            this.nombre = "Sin nombre";
            this.idProducto = -1;
            this.categoria = "Sin categoria";
            this.precio = -1;
            this.stockActual = -1;
            this.vendidos = -1;            
        }

        public Producto(string nombre, int idProducto, string categoria) : this()
        {
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.categoria = categoria;         
        }
        
        public Producto(string nombre, int idProducto, string categoria, float precio, int stockActual, int vendidos) : this(nombre, idProducto, categoria)
        {
            this.precio = precio;
            this.stockActual = stockActual;
            this.vendidos = vendidos;            
        }


        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public int GetIdProducto()
        {
            return this.idProducto;
        }
        public void SetId(int auxId)
        {
            this.idProducto = auxId;
        }

        public int GetStock()
        {
            return this.stockActual;
        }
        public void SetStock(int auxStock)
        {
            this.stockActual = auxStock;
        }

        public double GetPrecio()
        {
            return this.precio;
        }
        public void SetPrecio(float auxPrecio)
        {
            this.precio = auxPrecio;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }
        public void SetCategoria(string auxCategoria)
        {
            this.categoria = auxCategoria;
        }

        public int GetVendidos()
        {
            return this.vendidos;
        }
        public void SetVendidos(int auxVendidos)
        {
            this.vendidos = auxVendidos;
        }




    }
}

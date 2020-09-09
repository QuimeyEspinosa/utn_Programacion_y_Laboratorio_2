using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public static class Inventario
    {
        static Producto[] inventarioProductos;

        static Inventario()
        {
            inventarioProductos = new Producto[12];
        }

        public static void LlenarInventario()
        {
            inventarioProductos[0] = new Producto("Ladrillo", 12, "Construccion", 80, 120, 50);
            inventarioProductos[1] = new Producto("Destornillador", 15, "Herramientas", 95, 124, 13);
            inventarioProductos[2] = new Producto("Bombillas", 4, "Electricidad", 20, 300, 100);
            inventarioProductos[3] = new Producto("Caños de agua", 1, "Plomeria", 100, 0, 500);
            inventarioProductos[4] = new Producto("Pinza", 9, "Herramientas", 135, 80, 25);
            inventarioProductos[5] = new Producto("Flexible caño", 10, "Plomeria", 100, 5, 495);
            inventarioProductos[6] = new Producto("Canillas", 11, "Plomeria", 45, 15, 1200);
            inventarioProductos[7] = new Producto("Bolsa arena", 90, "Construccion", 60, 45, 1500);
            inventarioProductos[8] = new Producto("Martillo", 31, "Herramientas", 120, 150, 95);
            inventarioProductos[9] = new Producto("Cable (por metro)", 7, "Electricidad", 50, 98, 30);
        }

        static void MostrarUnProducto(Producto unProducto)
        {
            Console.WriteLine("{0}   {1}    {2}   {3}   {4}   {5}", unProducto.GetNombre(), unProducto.GetIdProducto(), unProducto.GetCategoria(), unProducto.GetPrecio(), unProducto.GetStock(), unProducto.GetVendidos());
        }

        public static void MostrarProductos()
        {
            Console.WriteLine("|    Nombre    |  ID  |    Categoria    |  Precio  | Stock Actual | Vendidos |");

            foreach (Producto item in inventarioProductos)
            {
                if (item != null)
                {
                    MostrarUnProducto(item);
                }
            }
        }


    }
}

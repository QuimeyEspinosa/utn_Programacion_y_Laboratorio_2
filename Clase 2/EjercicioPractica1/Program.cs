using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractica1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingresoUsuario;
            string ingresoClave;

            Cliente cliente1 = new Cliente();

            cliente1.setNombre("Quimey");
            cliente1.setApellido("Espinosa");
            cliente1.setDni(45068943);
            cliente1.setUsuario("QuimeyEspinosa");
            cliente1.setClave("pruebaCliente321");
            cliente1.setNumeroDeCuenta(5069096863944797007);
            cliente1.setSalario(35000.45);


            Console.Write("Ingrese usuario: ");
            ingresoUsuario = Console.ReadLine();
            while (String.IsNullOrEmpty(ingresoUsuario))
            {
                Console.Write("Error, reingrese usuario: ");
                ingresoUsuario = Console.ReadLine();
            }

            Console.Write("Ingrese su clave bancaria: ");
            ingresoClave = Console.ReadLine();
            while (String.IsNullOrEmpty(ingresoClave))
            {
                Console.Write("Error, reingrese clave: ");
                ingresoClave = Console.ReadLine();
            }


            if (ingresoUsuario == cliente1.getUsuario() && ingresoClave == cliente1.getClave())
            {
                string opcion;
                string monto;

                Console.Clear();
                cliente1.mostrarCliente();

                Console.Write("Que operacion desea realizar?\n1-Agregar saldo\n2-Retirar dinero\n3-Volver al inicio\n\n");
                Console.Write("Ingrese opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();

                        Console.Write("Ingrese saldo a agregar: ");
                        monto = Console.ReadLine();
                        while (String.IsNullOrEmpty(monto))
                        {
                            Console.Write("Error, reingrese saldo: ");
                            monto = Console.ReadLine();
                        }
                        cliente1.agregarSaldo(int.Parse(monto));

                        cliente1.mostrarCliente();
                        break;


                    case "2":
                        Console.Clear();

                        Console.Write("Ingrese dinero a retirar: ");
                        monto = Console.ReadLine();

                        while (String.IsNullOrEmpty(monto) || !cliente1.retirarDinero(int.Parse(monto)))
                        {
                            Console.Write("Error, reingrese dinero a retirar: ");
                            monto = Console.ReadLine();
                        }

                        cliente1.mostrarCliente();
                        break;

                    default:
                        break;

                }
            }
            else
            {
                Console.WriteLine("No existe un usuario con los datos ingresados\n\n");
            }


            Console.ReadKey();


        }
    }
}

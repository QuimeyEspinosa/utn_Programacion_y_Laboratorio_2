using System;

namespace EjercicioPractica1
{
    class Cliente
    {
        string nombre;
        string apellido;
        int dni;
        string usuario;
        string clave;
        long numeroDeCuenta;
        double saldo;


        //----------------Setters-------------------

        public void setNombre(string name)
        {
            this.nombre = name;
        }

        public void setApellido(string surname)
        {
            this.apellido = surname;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public void setUsuario(string username)
        {
            this.usuario = username;
        }

        public void setClave(string password)
        {
            this.clave = password;
        }

        public void setNumeroDeCuenta(long accountNumber)
        {
            this.numeroDeCuenta = accountNumber;
        }

        public void setSalario(double balance)
        {
            this.saldo = balance;
        }

        //----------------Getters-------------------


        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public int getDni()
        {
            return this.dni;
        }

        public string getUsuario()
        {
            return this.usuario;
        }

        public string getClave()
        {
            return this.clave;
        }

        public long getNumeroDeCuenta()
        {
            return this.numeroDeCuenta;
        }

        public double getSaldo()
        {
            return this.saldo;
        }



        public void mostrarCliente()
        {
            Console.Write("||| Datos del cliente |||\n\n");

            Console.WriteLine("Nombre: {0} \nApellido: {1} \nDNI: {2} \nUsuario: {3} \nNumero de cuenta: {4} \nSaldo: {5}\n\n", this.nombre, this.apellido, this.dni, this.usuario, this.numeroDeCuenta, this.saldo);
        }

        public void agregarSaldo(int aumentoSaldo)
        {
            this.saldo = this.saldo + (double)aumentoSaldo;
        }

        public bool retirarDinero(int retiroDinero)
        {
            bool pudoRetirar = false;

            if (this.saldo > retiroDinero)
            {
                this.saldo = this.saldo - (double)retiroDinero;
                pudoRetirar = true;
            }

            return pudoRetirar;
        }


    }
}

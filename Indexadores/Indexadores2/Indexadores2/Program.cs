/*
 * Confeccionar una clase llamada Cliente definir las propiedades Nombre y Dinero 
 * (en el constructor inicializar dichas propiedades)
Desarrollar otra clase llamada Banco donde debemos definir y crear un vector de tres 
elementos de tipo Cliente.
Implementar un indizador en la clase Banco que permita acceder a cada cliente por un 
subíndice entero.
 * 
 * */

using System;

namespace Indexadores2
{
    class Cliente
    {
        private string nombre;
        public string Nombre
        {// Propiedad
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        private int dinero;
        public int Dinero
        {// Propiedad
            set
            {
                dinero = value;
            }
            get
            {
                return dinero;
            }
        }

        public Cliente(string nom, int din)
        {// Constructor
            Nombre = nom;
            Dinero = din;
        }
    }

    class Banco
    {
        private Cliente[] clientes;

        public Banco()
        {// Constructor
            clientes = new Cliente[3];
        }

        public Cliente this[int indice]
        {// Indizador
            set
            {
                clientes[indice] = value;
            }
            get
            {
                return clientes[indice];
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Banco banco1 = new Banco();

            //Creación de los clientes
            Cliente cli1 = new Cliente("juan", 1000);
            Cliente cli2 = new Cliente("ana", 2000);
            Cliente cli3 = new Cliente("luis", 1500);

            // Inicialización de los clientes en el banco
            banco1[0] = cli1;   //Uso de indizador set
            banco1[1] = cli2;   //Uso de indizador set
            banco1[2] = cli3;   //Uso de indizador set


            Console.WriteLine("Datos de los clientes.");
            Console.WriteLine(banco1[0].Nombre);    //Uso de indizador get
            Console.WriteLine(banco1[0].Dinero);    //Uso de indizador get
            Console.WriteLine();

            Console.WriteLine(banco1[1].Nombre);    //Uso de indizador get
            Console.WriteLine(banco1[1].Dinero);    //Uso de indizador get
            Console.WriteLine();

            Console.WriteLine(banco1[2].Nombre);    //Uso de indizador get
            Console.WriteLine(banco1[2].Dinero);    //Uso de indizador get
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

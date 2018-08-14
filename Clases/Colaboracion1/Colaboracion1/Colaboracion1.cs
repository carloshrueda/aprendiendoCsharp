/*
 * Problema 1:
Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.

Lo primero que hacemos es identificar las clases:

Podemos identificar la clase Cliente y la clase Banco.

Luego debemos definir los atributos y los métodos de cada clase:

Cliente		
    atributos
        nombre
        monto
    métodos
        constructor
        Depositar
        Extraer
        RetornarMonto

Banco
    atributos
        3 Cliente (3 objetos de la clase Cliente)
    métodos
        constructor
        Operar
        DepositosTotales
Creamos un proyecto llamado: Colaboracion1 y dentro del proyecto creamos dos clases llamadas: Cliente y Banco.
 * 
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboracion1
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("Pedro");
        }

        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente3.Extraer(150);
        }

        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}

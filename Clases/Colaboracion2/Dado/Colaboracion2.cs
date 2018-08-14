/*
 * Problema 2:
Plantear un programa que permita jugar a los dados. Las reglas de juego son: se tiran tres dados si los tres salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".

Lo primero que hacemos es identificar las clases:

Podemos identificar la clase Dado y la clase JuegoDeDados.

Luego los atributos y los métodos de cada clase:

Dado		
    atributos
        valor
    métodos
        constructor
        Tirar
        Imprimir
        RetornarValor

JuegoDeDados
    atributos
        3 Dado (3 objetos de la clase Dado)
    métodos
        constructor
        Jugar
Creamos un proyecto llamado: Colaboracion2 y dentro del proyecto creamos dos clases llamadas: Dado y JuegoDeDados.
 * 
 * 
 */

using System;

namespace Colaboracion2
{
    class Dado
    {
        private static Random aleatorio;

        public Dado() => aleatorio = new Random();

        public void Tirar() => RetornarValor = aleatorio.Next(1, 7);

        public void Imprimir() => Console.WriteLine("El valor del dado es:" + RetornarValor);

        public int RetornarValor { get; private set; }
    }

    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();
            if (dado1.RetornarValor == dado2.RetornarValor &&
                dado1.RetornarValor == dado3.RetornarValor)
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeDados j = new JuegoDeDados();
            j.Jugar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Program
    {
        class A
        {
            private int[] vec;
            public A()
            {
                vec = new int[3];
            }

            // Definición e implementación del indexador
            public int this[int indice]
            {
                set
                {
                    vec[indice] = value;
                }
                get
                {
                    return vec[indice];
                }
            }
        }

        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1[0] = 7;    //uso del indexador set
            obj1[1] = 34;   //uso del indexador set
            obj1[2] = 45;    //uso del indexador set

            Console.WriteLine(obj1[0]); //uso del indexador get
            Console.WriteLine(obj1[1]); //uso del indexador get
            Console.WriteLine(obj1[2]); //uso del indexador get
            Console.ReadKey();
        }
    }
}

/*
 * Los indizadores permiten acceder mediante subíndices a un objeto de una clase que lo implementa. 
 * El objetivo es facilitar la implementación de un algoritmo.

El indizador evita que implementemos una serie de métodos para administrar el objeto.

La sintaxis de un indizador es:

tipo this[tipo indice]
{
    get
    {
         valor que retorna según indice
    }
    set
    {
        fijar el valor según indice
    }
}
 * 
 * */

/*
 * La clase LinkedList<T> nos facilita administrar una lista doblemente encadenada. A diferencia de la clase List<T> es más eficiente cuando tenemos que insertar y borrar elementos del medio de la colección.

Hay que tener en cuenta que con la clase List<T> si insertamos un elemento en la primer posición se deben desplazar todos los elementos una posición hacia adelante, en cambio con la clase LinkedList<T> solo se modifican punteros.

Como desventaja no podremos acceder a los elementos por medio de un subíndice como lo hacemos con la clase List<T> y deberemos recorrerla mediante una estructura repetitiva.

Problema 1:
Confeccionar un programa que cree un objeto de la clase LinkedList<T> y llamar a sus métodos y propiedades principales.
 * 
 * 
 * */

using System;
using System.Collections.Generic;

namespace ColeccionLinked1
{
    class Program
    {
        private static void ImprimirLista(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.First;   // ira al primero
            while (reco != null)
            {
                Console.Write(reco.Value + "-");
                reco = reco.Next;
            }

            //foreach (int reco in lista)
            //{
            //    Console.Write(reco + "-");

            //}
            Console.WriteLine();
        }

        private static void ImprimirUltimoAlPrimero(LinkedList<int> lista)
        {
            LinkedListNode<int> reco = lista.Last;  // ira al ultimo
            while (reco != null)
            {
                Console.Write(reco.Value + "-");
                reco = reco.Previous;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList<int> lista1 = new LinkedList<int>();

            lista1.AddFirst(30);
            lista1.AddFirst(20);
            lista1.AddFirst(10);
            lista1.AddFirst(5);
            lista1.AddLast(1);

            Console.WriteLine("Imprimimos la lista");
            ImprimirLista(lista1);

            Console.WriteLine("Cantidad de nodos de la lista:" + lista1.Count);

            Console.WriteLine("Imprimimos la lista del final al principio.");
            ImprimirUltimoAlPrimero(lista1);

            Console.ReadKey();
        }
    }
}

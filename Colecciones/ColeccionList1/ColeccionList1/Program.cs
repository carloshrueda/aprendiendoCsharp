using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionList1
{
    class Program
    {
        private static void ImprimirColeccion(List<int> lista)
        {
            for (int x = 0; x < lista.Count; x++)
                Console.Write(lista[x] + "-");
            Console.WriteLine();
        }

        private static bool BorrarSiCumple(int valor)
        {
            if (valor > 100)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();

            Console.WriteLine("Cantidad de elementos de la colección:" + lista1.Count);

            lista1.Add(10);
            lista1.Add(20);
            lista1.Add(30);
            lista1.Add(500);
            lista1.Add(400);
            Console.WriteLine("Insertamos tres elementos en la colección");
            ImprimirColeccion(lista1);

            lista1.Insert(0, 100);
            Console.WriteLine("Luego de insertar un elemento en la posición 0");
            ImprimirColeccion(lista1);

            Console.WriteLine("Luego de eliminar la primer componente que almacena un 10");
            lista1.Remove(10);
            ImprimirColeccion(lista1);

            Console.WriteLine("Luego de eliminar el elemento de la posición 0");
            lista1.RemoveAt(0);
            ImprimirColeccion(lista1);

            lista1.RemoveAll(BorrarSiCumple);
            Console.WriteLine("Luego de borrar todos los elementos mayores a 100");
            ImprimirColeccion(lista1);

            for (var x = 1; x <= 10; x++)
                lista1.Add(x);
            Console.WriteLine("Luego de insertar al final los valores del 1 al 10");
            ImprimirColeccion(lista1);

            Console.WriteLine("Luego de eliminar 3 elementos desde la posición 1");
            lista1.RemoveRange(1, 3);
            ImprimirColeccion(lista1);

            lista1.Sort();
            Console.WriteLine("Luego de ordenar la colección");
            ImprimirColeccion(lista1);

            lista1.Clear();
            Console.WriteLine("Luego de borrar toda la colección");

            Console.ReadKey();
        }
    }
}

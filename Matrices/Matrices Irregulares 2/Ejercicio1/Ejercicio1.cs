/*
 * Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 
 * 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila 
 * (crearla sin la intervención del operador) Realizar la carga por teclado e imprimir posteriormente.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Ejercicio1
    {
        private int[][] mat;
        private const int MAXFIL = 5;

        public void Cargar()
        {
            string linea;

            mat = new int[MAXFIL][];
            for (int f = 0; f < MAXFIL; f++)
            {
                mat[f] = new int[f + 1];
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write("Ingrese componente:" + (c + 1) + " para la fila: " + (f + 1) + "? ");
                    linea = Console.ReadLine();
                    mat[f][c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.Length; f++)
            {
                for (int c = 0; c < mat[f].Length; c++)
                {
                    Console.Write(mat[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Ejercicio1 ma = new Ejercicio1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}

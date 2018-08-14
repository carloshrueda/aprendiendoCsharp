/*
 * Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.
 * 
 * Si queremos saber la cantidad de filas que tiene la matriz debemos llamar al método GetLength con el 
 * valor cero:

Console.WriteLine("Cantidad de filas de la matriz:" + mat.GetLength(0));
Si queremos saber la cantidad de columnas luego:

Console.WriteLine("Cantidad de columnas de la matriz:" + mat.GetLength(1));
La primer dimensión son la cantidad de filas y la segunda dimensión son la cantidad de columnas de la 
matriz.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices__cantidad_de_filas_y_columnas_
{
    class Matriz5
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("Ultima fila");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[mat.GetLength(0) - 1, c] + " ");
            }
        }

        static void Main(string[] args)
        {
            Matriz5 ma = new Matriz5();
            ma.Cargar();
            ma.Imprimir();
            ma.ImprimirUltimaFila();
            Console.ReadKey();
        }
    }
}

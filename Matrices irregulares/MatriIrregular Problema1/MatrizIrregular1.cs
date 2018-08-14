/*
 * La sintaxis para declarar una matriz irregular es:

int [][] mat;
Primero creamos la cantidad de filas dejando vacío el espacio que indica la cantidad de columnas:

mat=new int[3][];
Luego debemos ir creando cada fila de la matriz indicando la cantidad de elementos de la respectiva fila:

mat[0]=new int[2];
mat[1]=new int[4];
mat[2]=new int[3];
Luego la forma para acceder a sus componentes debe ser utilizando corchetes abiertos y cerrados para cada índice:

mat[0][0]=120;
Dará un error si queremos cargar la tercer componente de la fila cero (esto debido a que no existe):

mat[0][2]=230;
Luego si queremos saber la cantidad de filas que tiene la matriz:

Console.Write(mat.Length);
Si queremos saber la cantidad de elementos de una determinada fila:

Console.Write("Cantidad de elementos de la fila 0:"+mat[0].Length);
Console.Write("Cantidad de elementos de la fila 1:"+mat[1].Length);
Console.Write("Cantidad de elementos de la fila 2:"+mat[2].Length);


 * 
 * Problema 1:
Confeccionaremos un programa que permita crear una matriz irregular y luego imprimir la matriz en forma completa.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriIrregular_Problema1
{
    class MatrizIrregular1
    {
        private int[][] mat;    // se crea una matriz irregular

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);
            mat = new int[filas][]; //Se crean las filas
            for (int f = 0; f < mat.Length; f++)
            {
                Console.Write("Cuantas elementos tiene la fila " + f + ":");
                linea = Console.ReadLine();
                int elementos = int.Parse(linea);
                mat[f] = new int[elementos]; // En cada fila se crean las columnas
                for (int c = 0; c < mat[f].Length; c++) // mat[f].Length : long de la fila F
                {   
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f][c] = int.Parse(linea); // Ingreso de un valor el la f,c
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.Length; f++) // hallar cantidad de filas mat.Length
            {
                for (int c = 0; c < mat[f].Length; c++) //hallar cantidad col en cada fila mat[f].Length
                {
                    Console.Write(mat[f][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            MatrizIrregular1 ma = new MatrizIrregular1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}


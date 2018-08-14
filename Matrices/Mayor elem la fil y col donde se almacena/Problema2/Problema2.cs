/*
 *  Problema 2:
 *  Crear una matriz de n * m filas (cargar n y m por teclado) 
 *  Imprimir el mayor elemento y la fila y columna donde se almacena.
 */

using System;

namespace Problema2
{
    class Problema2
    {
        private int[,] mat;
        private int elemmay, filmay, colmay;

        public int Elemmay { get => elemmay; set => elemmay = value; }
        public int Filmay { get => filmay; set => filmay = value; }
        public int Colmay { get => colmay; set => colmay = value; }

        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++) //mat.GetLength(0) obtengo las filas
            {
                for (int c = 0; c < mat.GetLength(1); c++) //mat.GetLength(1) obtengo las columnas
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void encontrarMay()
        {
            Filmay = Colmay = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mat[Filmay, Colmay])
                    {
                        Filmay = f;
                        Colmay = c;
                    }
                }
            }
            Elemmay = mat[Filmay, Colmay];
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

        static void Main(string[] args)
        {
            Problema2 ma = new Problema2();
            ma.Cargar();
            ma.Imprimir();
            ma.encontrarMay();
            Console.WriteLine("El elemento mayor es: \n" + ma.Elemmay);
            Console.WriteLine("Se encuentra en la Fila: " + (ma.Filmay+1) + ", Columna:" + (ma.Colmay+1));


            Console.ReadKey();
        }
    }
}

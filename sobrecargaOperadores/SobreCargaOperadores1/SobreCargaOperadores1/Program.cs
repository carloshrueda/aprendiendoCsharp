/*
 * Problema 1:
Plantear una clase VectorEnteros que permita crear un vector de 5 elementos y sobrecargue el operador +
 * 
 * */

using System;

namespace SobreCargaOperadores1
{
    class VectorEnteros
    {
        private int[] vec;

        public VectorEnteros()
        {
            vec = new int[5];
        }

        public void Cargar()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese componente:");
                vec[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write(vec[f] + " ");
            }
            Console.WriteLine();
        }

        //Aqui está la sobre carga de operadores ----|>
        public static VectorEnteros operator +(VectorEnteros v1, VectorEnteros v2)
        {
            VectorEnteros su = new VectorEnteros();
            for (int f = 0; f < su.vec.Length; f++)
            {
                su.vec[f] = v1.vec[f] + v2.vec[f];
            }
            return su;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            VectorEnteros v1 = new VectorEnteros();
            Console.WriteLine("Carga del primer vector");
            v1.Cargar();
            VectorEnteros v2 = new VectorEnteros();
            Console.WriteLine("Carga del segundo vector");
            v2.Cargar();
            Console.WriteLine("Primer Vector");
            v1.Imprimir();
            Console.WriteLine("Segundo Vector");
            v2.Imprimir();
            VectorEnteros vt;
            vt = v1 + v2;
            Console.WriteLine("Vector Resultante");
            vt.Imprimir();
            Console.ReadKey();
        }
    }
}


/*
 * La sobrecarga de operadores en C# permite redefinir la acción de un operador en relación a una clase.
Por ejemplo podemos plantear una clase Vector y luego redefinir el operador + para dicha clase. Luego 
cuando sumamos dos objetos de esa clase vector podemos generar otro objeto de dicha clase que resulte de 
la suma de sus componentes.

El empleo de la sobrecarga de operadores debe hacerse con mucho cuidado de no desvirtuar el concepto que 
representa dicho operador (por ejemplo sobrecargar el operador "-" para la clase Vector y que genere la 
suma de sus componentes)
 * 
 * */

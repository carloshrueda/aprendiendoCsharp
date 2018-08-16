using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_variable_parametros
{
    class Program
    {
        public int Sumar(params int[] p)
        {
            int su = 0;
            //for (var f = 0; f < p.Length; f++)
            //{
            //    su = su + p[f];
            //}
            foreach (var f in p)
            {
                su += f;
            }
            return su;
        }

        public int Operaciones(string oper, params int[] p)
        {
            int res = 0;

            switch (oper)
            {
                case "suma":
                    res = 0;
                    foreach (var f in p)
                    {
                        res += f;
                    }
                    break;

                case "producto":
                    res = 1;
                    foreach (var f in p)
                    {
                        res *= f;
                    }
                    break;
            }

            return res;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("La suma de 3,4,5 es ");
            Console.WriteLine(p.Sumar(3, 4, 5));
            Console.Write("La suma de 1,9 es ");
            Console.WriteLine(p.Sumar(1, 9));
            Console.Write("La suma de 1,2,3,...,10 es ");
            Console.WriteLine(p.Sumar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            Console.Write("\nLa operacion de sumar de 1,2,3,...,5 es ");
            Console.WriteLine(p.Operaciones("suma", 1, 2, 3, 4, 5));

            Console.Write("La operacion de multiplicar de 1,2,3,...,5 es ");
            Console.WriteLine(p.Operaciones("producto", 1, 2, 3, 4, 5));

            Console.ReadKey();
        }
    }
}

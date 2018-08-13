using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int n1, n2, suma;

            Console.Write("Escriba un numero: ");
            entrada = Console.ReadLine();
            n1 = int.Parse(entrada);
            Console.Write("Escriba otro numero: ");
            entrada = Console.ReadLine();
            n2 = int.Parse(entrada);
            suma = n1 + n2;
            Console.WriteLine("La suma de dos número es: " + suma);
            Console.ReadKey();

        }
    }
}

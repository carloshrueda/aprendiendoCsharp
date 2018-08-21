using System;

namespace ConsoleApp1
{
    class Program
    {
        enum DiasSemana
        {
            DOMINGO = 1,
            LUNES,
            MARTES,
            MIERCOLES,
            JUEVES,
            VIERNES,
            SABADO
        }
        static void Main(string[] args)
        {
            int edad = 20;
            double pi = Math.PI;
            char car = 'A';
            string str1 = "Carlos";
            string str2 = "Carlos";
            const int CANO= 2018;

            Console.WriteLine("Hola mundo!");
            //{v,k}: v: indice de variable || k: cantidad de espacios desplegados
            Console.WriteLine("\nDesplegando el entero: {0,3}\nDesplegando el double: {1,17}", edad, pi);
            Console.WriteLine("\nCaracter A:{0,2}", car);
            Console.WriteLine("Codigo del caracter A:{0,3}", (int)car);

            Console.WriteLine("\nComparando cadenas:{0,5}", str1==str2);
            Console.WriteLine("\nComparando cadenas:{0,5}", String.Equals(str1, str2));
            // String.CompareTo
            // Value Condition Less than zero This instance precedes strB.
            // Zero This instance has the same position in the sort order as strB.
            // Greater than zero This instance follows strB.-or - strB is null
            Console.WriteLine("\nComparando cadenas:{0,5}", str1.CompareTo(str2));

            Console.WriteLine("\nImprimendo una constante:{0,5}", CANO);

            Console.WriteLine("\nImprimendo una eumeracion:  {0,5} - {1}", DiasSemana.DOMINGO, (int) DiasSemana.DOMINGO);


            //Input
            string nombre;
            Console.Write("\nCual es su nombre?: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Muy bien hecho {0}", nombre);

            Console.Write("\nCual es su edad?: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Te faltan {0} anos para morir ;)", 150 - edad);

            Console.ReadLine();
        }
    }
}

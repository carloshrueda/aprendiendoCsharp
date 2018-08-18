using System;

namespace ProgramFactorial1
{
    class Matematicas
    {
        public int Factorial(int n)
        {
            int res = 0;
            if (n > 0)
            {
                res = 1;

                for (int i = 2; i <= n; i++)
                    res *= i;

                return res;
            }
            else if (n == 0)
                res = 1;
            else
                res = 0;

            return res;
        }

        static void Main(string[] args)
        {
            Matematicas m = new Matematicas();
            Console.WriteLine("Factorial de 6 es: " + m.Factorial(6));
            Console.ReadLine();
        }
    }
}

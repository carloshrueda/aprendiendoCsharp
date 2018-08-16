using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_estaticos
{
    class Operacion
    {
        public static int Sumar(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        public static int Restar(int x1, int x2)
        {
            int r = x1 - x2;
            return r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("La suma de 2+4 es ");
            Console.WriteLine(Operacion.Sumar(2, 4));
            Console.Write("La resta de 6-2 es ");
            Console.WriteLine(Operacion.Restar(6, 2));
            Console.ReadKey();
        }
    }
}


/*
 * En C# podemos definir métodos que se crean independientemente a la definición de objetos. Un método estático puede llamarse sin tener que crear un objeto de dicha clase. Un método estático tiene ciertas restricciones:

No puede acceder a los atributos de la clase (salvo que sean estáticos)
No puede utilizar el operador this, ya que este método se puede llamar sin tener que crear un objeto de la clase.
Puede llamar a otro método siempre y cuando sea estático.
Un método estático es lo más parecido a lo que son las funciones en los lenguajes estructurados (con la diferencia que se encuentra encapsulado en una clase)
Si recordamos cada vez que creamos un programa en C# debemos especificar el método Main:

   static void Main(string[] args)
El método Main es estático para que el sistema operativo pueda llamarlo directamente sin tener que crear un objeto de la clase que lo contiene.
 * 
 * */

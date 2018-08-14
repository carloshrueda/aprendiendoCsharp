using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    public class Operacion
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;

        public int Valor1
        {//Propiedad Valor1
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2
        {//Propiedad Valor2
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {//Propiedad Resultado
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }


    public class Suma : Operacion //HERENCIA
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }


    public class Resta : Operacion //HERENCIA
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.Valor1 + " y " +
              suma1.Valor2 + " es " + suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.Valor1 = 8;
            resta1.Valor2 = 4;
            resta1.Operar();
            Console.WriteLine("La diferencia de " + resta1.Valor1 +
              " y " + resta1.Valor2 + " es " + resta1.Resultado);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos_estaticos
{
    class Persona
    {
        private string nombre;
        private int edad;
        public static int cantidad;

        public Persona(string nom, int ed)
        {
            cantidad++;
            nombre = nom;
            edad = ed;
        }

        public void Imprimir()
        {
            Console.WriteLine("\t" + nombre + "-" + edad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Acceso al atributo estático
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad + "\n");

            Persona per1 = new Persona("juan", 30);
            per1.Imprimir();

            //Acceso al atributo estático
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad + "\n");

            Persona per2 = new Persona("ana", 20);
            per2.Imprimir();

            //Acceso al atributo estático
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad + "\n");

            Persona per3 = new Persona("luis", 10);
            per3.Imprimir();

            //Acceso al atributo estático
            Console.WriteLine("Valor del atributo estático cantidad:" + Persona.cantidad + "\n");

            Console.ReadKey();
        }
    }
}

/*
 * Los atributos estáticos tienen un comportamiento muy distinto a los atributos vistos hasta el momento. 
 * Un atributo estático se reserva espacio para el mismo indistintamente que definamos un objeto de dicha 
 * clase. En caso de crear varios objetos de dicha clase todas las instancias acceden al mismo atributo 
 * estático. Recordemos que los atributos que habíamos visto son independientes en cada objeto de la clase.
 * 
 * */


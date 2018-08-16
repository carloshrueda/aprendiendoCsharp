using System;

namespace Llamadas_con_nomb_parametros
{
    class Program
    {
        public void Imprimir(string mensaje, int columna, int fila)
        {
            Console.SetCursorPosition(columna, fila);
            Console.WriteLine(mensaje);
        }

        static void Main(string[] args)
        {
            Program ob1 = new Program();
            ob1.Imprimir(fila: 12, columna: 40, mensaje: "Hola Mundo");
            ob1.Imprimir(mensaje: "Fin", fila: 23, columna: 5);
            Console.ReadKey();
        }
    }
}

/*
 * Esta clase Dictionary<TKey, TValue> nos permite almacenar elementos asociando a cada clave un valor.

Para cada clave tenemos un valor asociado. Podemos después buscar fácilmente un valor para una determinada clave. Las claves en el diccionario no pueden repetirse.

Algunos ejemplos donde podríamos usar un diccionario:

Guardar en la clave las extensiones de archivos y en el valor los nombres de archivos que lo pueden abrir
En una agenda podemos guardar como 'clave' la fecha y hora y las actividades en el 'valor'.
 * 
 * */


using System;
using System.Collections.Generic;

namespace ColeccionDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicc1 = new Dictionary<string, string>();

            dicc1["rojo"] = "red";
            dicc1["verde"] = "green";
            dicc1["azul"] = "blue";
            dicc1["blanco"] = "whilte";

            foreach (KeyValuePair<string, string> elemento in dicc1)
                Console.WriteLine(elemento.Key + "=" + elemento.Value);

            if (dicc1.ContainsKey("rojo"))
                Console.WriteLine(dicc1["rojo"]);

            dicc1.Remove("rojo");
            if (dicc1.ContainsKey("rojo"))
                Console.WriteLine(dicc1["rojo"]);
            else
                Console.WriteLine("No existe la clave 'rojo'");

            Console.ReadKey();
        }
    }
}

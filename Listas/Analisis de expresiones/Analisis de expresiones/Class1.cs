using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_de_expresiones
{
    class Pila
    {
        class Nodo
        {
            public char simbolo;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(char x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.simbolo = x;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public char Extraer()
        {
            if (raiz != null)
            {
                char informacion = raiz.simbolo;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return char.MaxValue;
            }
        }

        public bool Vacia()
        {
            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

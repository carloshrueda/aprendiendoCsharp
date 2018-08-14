using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTipoCola2
{
    class Cola
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz, fondo;

        public Cola()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vacia())
            {
                int informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }
                return informacion;
            }
            else
                return int.MaxValue;
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }
    }
}

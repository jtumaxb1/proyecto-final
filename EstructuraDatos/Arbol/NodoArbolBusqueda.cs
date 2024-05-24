using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Arbol
{
    public class NodoArbolBusqueda
    {
        protected Object dato;
        protected NodoArbolBusqueda izdo;
        protected NodoArbolBusqueda dcho;

        public NodoArbolBusqueda(Object valor)
        {
            dato = valor;
            izdo = dcho = null;
        }

        public NodoArbolBusqueda(NodoArbolBusqueda ramaIzdo, Object valor, NodoArbolBusqueda ramaDcho)
        {
            this.dato = valor;
            this.izdo = ramaIzdo;
            this.dcho = ramaDcho;
        }

        public Object valorNodo()
        {
            return dato;
        }

        public NodoArbolBusqueda subArbolIzdo()
        {
            return izdo;
        }

        public NodoArbolBusqueda subArbolDcho()
        {
            return dcho;
        }

        public void nuevoValor(Object d)
        {
            dato = d;
        }

        public void ramaIzdo(NodoArbolBusqueda n)
        {
            izdo = n;
        }

        public void ramaDcho(NodoArbolBusqueda n)
        {
            dcho = n;
        }

        public string visitar()
        {
            return dato.ToString();
        }
    }
}

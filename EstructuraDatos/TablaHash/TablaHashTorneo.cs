using EstructuraDatos.Arbol;
using EstructuraDatos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.TablaHash
{
    public class TablaHashTorneo
    {
        public static readonly int M = 300;

        public Torneo[] tabla = new Torneo[M];

        public int FuncionHash(string x)
        {
            int numericValue = 0;
            foreach (char item in x)
            {
                numericValue += (int)item;
            }
            return (numericValue % M);
        }

        public void Insertar(String clave)
        {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                tabla[pos] = new Torneo();
                tabla[pos].nombre = clave;
                tabla[pos].arbol = new ArbolAVL();
            } else
            {
                return;
            }
        }

        public void Actualizar(string Dato, String clave)
        {
            int pos = 0;
            int posNuevo = 0;
            Torneo torneoAnterior;
            pos = FuncionHash(clave);
            posNuevo = FuncionHash(Dato);
            if (tabla[pos] == null)
            {
                return;
            } else
            {
                torneoAnterior = tabla[pos];
                torneoAnterior.nombre = Dato;
                tabla[posNuevo] = torneoAnterior;
                tabla[pos] = null;
            }
        }

        public Object Buscar(String clave)
        {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                return null;
            } else
            {
                return tabla[pos];
            }
        }

        public void Eliminar(String clave) {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                return;
            }
            tabla[pos] = null;
        }

    }
}

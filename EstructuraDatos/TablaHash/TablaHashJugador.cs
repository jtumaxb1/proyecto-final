using EstructuraDatos.ListaEnlazada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.TablaHash
{
    public class TablaHashJugador
    {
        public static readonly int M = 300;

        Lista[] tabla = new Lista[M];

        public int FuncionHash(string x)
        {
            int numericValue = 0;
            foreach (char item in x) {
                numericValue += (int)item;
            }
            return (numericValue % M);
        }

        public void Insertar(Object Dato, String Clave)
        {
            int pos = 0;
            pos = FuncionHash(Clave);
            if (tabla[pos] == null)
            {
                tabla[pos] = new Lista();
            }
            tabla[pos].insertarCabezaLista(Dato);
        }

        public Lista buscarLista(String claveTabla)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            return tabla[pos];
        }

        public Object Buscar(String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            return tabla[pos].buscarNodo(claveLista);
        }

        public void Actualizar(Object Dato, String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].actualizarLista(Dato, claveLista);
        }

        public void ActualizarGoles(String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].actualizarGoles(claveLista);
        }

        public void ActualizarTarjetasAmarillas(String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].actualizarTarjetasAmarillas(claveLista);
        }

        public void ActualizarTarjetasRojas(String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].actualizarTarjetasRojas(claveLista);
        }

        public void Eliminar(Object Dato, String claveTabla)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].eliminar(Dato);
        }

    }
}

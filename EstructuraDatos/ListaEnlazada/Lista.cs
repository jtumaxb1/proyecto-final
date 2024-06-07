using EstructuraDatos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.ListaEnlazada
{
    public class Lista
    {
        public int cantidad = 0;
        public Nodo primero;

        public Lista()
        {
            primero = null;
        }

        public Lista insertarCabezaLista(Object vDato)
        {
            Nodo nuevo;
            nuevo = new Nodo(vDato);
            nuevo.Enlace = primero;
            primero = nuevo;
            this.cantidad += 1;
            return this;
        }

        public void insertarOrdenado(List<Object> equipos)
        {
            foreach (Equipo equipo in equipos)
            {
                if (primero == null)
                {
                    Nodo nuevo;
                    nuevo = new Nodo(equipo);
                    nuevo.Enlace = primero;
                    primero = nuevo;
                } 
                else
                {
                    Nodo nuevo, indice;
                    for (indice = primero; indice != null; indice = indice.Enlace)
                    {
                        Equipo equipoLista = (Equipo)indice.Dato;
                        if (equipo.puntos > equipoLista.puntos)
                        {
                            nuevo = new Nodo(equipo);
                            nuevo.Enlace = primero;
                            primero = nuevo;
                            break;
                        }
                    }
                    if (indice == null)
                    {
                        nuevo = new Nodo(equipo);
                        nuevo.Enlace = primero;
                        primero = nuevo;
                    }
                }
            }
        }

        public Object buscarNodoPartido(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Partido partido = (Partido)indice.Dato;
                if (partido.id == clave)
                {
                    return partido;
                }
            }
            return null;
        }

        public Lista actualizarListaPartido(Object vDato, int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Partido partido = (Partido)indice.Dato;
                if (partido.id == clave)
                {
                    indice.Dato = vDato;
                }
            }
            return this;
        }

        public Object buscarNodo(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Jugador jugador = (Jugador)indice.Dato;
                if (jugador.id == clave)
                {
                    return jugador;
                }
            }
            return null;
        }

        public Lista actualizarLista(Object vDato, int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Jugador jugador = (Jugador)indice.Dato;
                if (jugador.id == clave)
                {
                    indice.Dato = vDato;
                }
            }
            return this;
        }

        public Lista actualizarGolesLocal(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Partido partido = (Partido)indice.Dato;
                if (partido.id == clave)
                {
                    partido.marcadorLocal += 1;
                    indice.Dato = partido;
                }
            }
            return this;
        }

        public Lista actualizarGolesVisitante(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Partido partido = (Partido)indice.Dato;
                if (partido.id == clave)
                {
                    partido.marcadorVisitante += 1;
                    indice.Dato = partido;
                }
            }
            return this;
        }

        public Lista actualizarGoles(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Jugador jugador = (Jugador)indice.Dato;
                if (jugador.id == clave)
                {
                    jugador.goles += 1;
                    indice.Dato = jugador;
                }
            }
            return this;
        }

        public Lista actualizarTarjetasAmarillas(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Jugador jugador = (Jugador)indice.Dato;
                if (jugador.id == clave)
                {
                    jugador.tarjetaAmarillas += 1;
                    indice.Dato = jugador;
                }
            }
            return this;
        }

        public Lista actualizarTarjetasRojas(int clave)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.Enlace)
            {
                Jugador jugador = (Jugador)indice.Dato;
                if (jugador.id == clave)
                {
                    jugador.tarjetaRojas += 1;
                    indice.Dato = jugador;
                }
            }
            return this;
        }

        public void eliminar(Object vDato)
        {
            Nodo actual, anterior;
            Boolean encontrado;
            actual = primero;
            anterior = null;
            encontrado = false;
            while ((actual != null) && (!encontrado)) {
                encontrado = (actual.Dato.Equals(vDato));
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.Enlace;
                }
            }

            if (actual != null)
            {
                if (actual == primero)
                {
                    primero = actual.Enlace;
                }
                else
                {
                    anterior.Enlace = actual.Enlace;
                }
                actual = null;
            }
        }

    }
}

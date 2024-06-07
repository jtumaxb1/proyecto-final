using EstructuraDatos.Clases;
using EstructuraDatos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Arbol
{
    public class ArbolAVL
    {

        int salto = 0;

        public int cantidad = 0;

        protected NodoAvl raiz;

        public ArbolAVL()
        {
            raiz = null;
        }

        public NodoAvl raizArbol()
        {
            return raiz;
        }

        protected Object buscarPorNombre(NodoArbolBusqueda raizSub, string buscado)
        {
            try
            {
                Equipo dato = (Equipo)raizSub.valorNodo();
                if (raizSub == null)
                {
                    return null;
                } else if (dato.igualQue(buscado))
                {
                    return dato;
                } else if (dato.menorQue(buscado))
                {
                    return buscarPorNombre(raizSub.subArbolDcho(), buscado);
                } else
                {
                    return buscarPorNombre(raizSub.subArbolIzdo(), buscado);
                }
            } catch (Exception ex)
            {
                return null;
            }
        }

        public Object buscarPorNombre(string dato)
        {
            if (raiz == null)
            {
                return null;
            } else
            {
                return buscarPorNombre(raizArbol(), dato);
            }
        }

        public Object buscar(int dato)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return buscar(raizArbol(), dato);
            }
        }

        protected Object buscar(NodoArbolBusqueda raizSub, int buscado)
        {
            try
            {
                salto++;
                Resp respuesta = new Resp();
                Equipo dato = (Equipo)raizSub.valorNodo();
                if (raizSub == null)
                {
                    return null;
                }
                else if (dato.igualQue(buscado))
                {
                    respuesta.equipo = dato;
                    respuesta.salto = salto;
                    return respuesta;
                }
                else if (dato.menorQue(buscado))
                {
                    return buscar(raizSub.subArbolDcho(), buscado);
                }
                else
                {
                    return buscar(raizSub.subArbolIzdo(), buscado);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private NodoAvl rotacionII(NodoAvl n, NodoAvl n1)
        {
            n.ramaIzdo(n1.subArbolDcho());
            n1.ramaDcho(n);
            if (n1.fe == -1)
            {
                n.fe = 0;
                n1.fe = 0;
            }
            else
            {
                n.fe = -1;
                n1.fe = 1;
            }
            return n1;
        }

        private NodoAvl rotacionDD(NodoAvl n, NodoAvl n1)
        {
            n.ramaDcho(n1.subArbolIzdo());
            n1.ramaIzdo(n);
            if (n1.fe == +1)
            {
                n.fe = 0;
                n1.fe = 0;
            }
            else
            {
                n.fe = +1;
                n1.fe = -1;
            }
            return n1;
        }

        private NodoAvl rotacionID(NodoAvl n, NodoAvl n1)
        {
            NodoAvl n2;
            n2 = (NodoAvl)n1.subArbolDcho();
            n.ramaIzdo(n2.subArbolDcho());
            n2.ramaDcho(n);
            n1.ramaDcho(n2.subArbolIzdo());
            n2.ramaIzdo(n1);
            if (n2.fe == +1)
                n1.fe = -1;
            else
                n1.fe = 0;
            if (n2.fe == -1)
                n.fe = 1;
            else
                n.fe = 0;
            n2.fe = 0;
            return n2;
        }

        private NodoAvl rotacionDI(NodoAvl n, NodoAvl n1)
        {
            NodoAvl n2;
            n2 = (NodoAvl)n1.subArbolIzdo();
            n.ramaDcho(n2.subArbolIzdo());
            n2.ramaIzdo(n);
            n1.ramaIzdo(n2.subArbolDcho());
            n2.ramaDcho(n1);
            if (n2.fe == +1)
                n.fe = -1;
            else
                n.fe = 0;
            if (n2.fe == -1)
                n1.fe = 1;
            else
                n1.fe = 0;
            n2.fe = 0;
            return n2;
        }

        public void actualizar(Object valor, string buscar)
        {
            Comparador dato;
            Logical h = new Logical(false);
            dato = (Comparador)valor;
            raiz = actualizarAvl(raiz, dato, h, buscar);
        }

        private NodoAvl actualizarAvl(NodoAvl raiz, Comparador dt, Logical h, string buscar) {
            NodoAvl n1;
            Equipo dato = (Equipo)raiz.valorNodo();
            if (dato.igualQue(buscar))
            {
                raiz.nuevoValor(dt);
                h.setLogical(true);
            }
            else if (dato.menorQue(buscar))
            {
                NodoAvl iz;
                iz = actualizarAvl((NodoAvl)raiz.subArbolIzdo(), dt, h, buscar);
                raiz.ramaIzdo(iz);
            }
            else if (dato.mayorQue(buscar))
            {
                NodoAvl dr;
                dr = actualizarAvl((NodoAvl)raiz.subArbolDcho(), dt, h, buscar);
                raiz.ramaDcho(dr);
            }
            return raiz;
        }

        public void insertar(Object valor)//throws Exception
        {
            Comparador dato;
            Logical h = new Logical(false); // intercambia un valor booleano
            dato = (Comparador)valor;
            raiz = insertarAvl(raiz, dato, h);
        }

        private NodoAvl insertarAvl(NodoAvl raiz, Comparador dt, Logical h)
        //throws Exception
        {
            NodoAvl n1;
            if (raiz == null)
            {
                raiz = new NodoAvl(dt);
                this.cantidad += 1;
                h.setLogical(true);
            } else
            {
                Equipo equipo = (Equipo)raiz.valorNodo();
                if (dt.menorQue(equipo.nombre))
                {
                    NodoAvl iz;
                    iz = insertarAvl((NodoAvl)raiz.subArbolIzdo(), dt, h);
                    raiz.ramaIzdo(iz);
                    // regreso por los nodos del camino de búsqueda
                    if (h.booleanValue())
                    {
                        // decrementa el fe por aumentar la altura de rama izquierda
                        switch (raiz.fe)
                        {
                            case 1:
                                raiz.fe = 0;
                                h.setLogical(false);
                                break;
                            case 0:
                                raiz.fe = -1;
                                break;
                            case -1: // aplicar rotación a la izquierda
                                n1 = (NodoAvl)raiz.subArbolIzdo();
                                if (n1.fe == -1)
                                    raiz = rotacionII(raiz, n1);
                                else
                                    raiz = rotacionID(raiz, n1);
                                h.setLogical(false);
                                break;
                        }
                    }
                }
                else if (dt.mayorQue(equipo.nombre))
                {
                    NodoAvl dr;
                    dr = insertarAvl((NodoAvl)raiz.subArbolDcho(), dt, h);
                    raiz.ramaDcho(dr);
                    // regreso por los nodos del camino de búsqueda
                    if (h.booleanValue())
                    {
                        // incrementa el fe por aumentar la altura de rama izquierda
                        switch (raiz.fe)
                        {
                            case 1: // aplicar rotación a la derecha
                                n1 = (NodoAvl)raiz.subArbolDcho();
                                if (n1.fe == +1)
                                    raiz = rotacionDD(raiz, n1);
                                else
                                    raiz = rotacionDI(raiz, n1);
                                h.setLogical(false);
                                break;
                            case 0:
                                raiz.fe = +1;
                                break;
                            case -1:
                                raiz.fe = 0;
                                h.setLogical(false);
                                break;
                        }
                    }
                }
                else
                    throw new Exception("No puede haber claves repetidas ");
            }
            return raiz;
        }

        public void eliminar(Object valor) //throws Exception
        {
            Comparador dato;
            dato = (Comparador)valor;
            Logical flag = new Logical(false);
            raiz = borrarAvl(raiz, dato, flag);
        }

        private NodoAvl borrarAvl(NodoAvl r, Comparador clave, Logical cambiaAltura) //throws Exception
        {
            if (r == null)
            {
                throw new Exception(" Nodo no encontrado ");
            }
            else if (clave.menorQue(r.valorNodo()))
            {
                NodoAvl iz;
                iz = borrarAvl((NodoAvl)r.subArbolIzdo(), clave, cambiaAltura);
                r.ramaIzdo(iz);
                if (cambiaAltura.booleanValue())
                    r = equilibrar1(r, cambiaAltura);
            }
            else if (clave.mayorQue(r.valorNodo()))
            {
                NodoAvl dr;
                dr = borrarAvl((NodoAvl)r.subArbolDcho(), clave, cambiaAltura);
                r.ramaDcho(dr);
                if (cambiaAltura.booleanValue())
                    r = equilibrar2(r, cambiaAltura);
            }
            else // Nodo encontrado
            {
                NodoAvl q;
                q = r; // nodo a quitar del árbol
                if (q.subArbolIzdo() == null)
                {
                    r = (NodoAvl)q.subArbolDcho();
                    cambiaAltura.setLogical(true);
                }
                else if (q.subArbolDcho() == null)
                {
                    r = (NodoAvl)q.subArbolIzdo();
                    cambiaAltura.setLogical(true);
                }
                else
                { // tiene rama izquierda y derecha
                    NodoAvl iz;
                    iz = reemplazar(r, (NodoAvl)r.subArbolIzdo(), cambiaAltura);
                    r.ramaIzdo(iz);
                    if (cambiaAltura.booleanValue())
                        r = equilibrar1(r, cambiaAltura);
                }
                q = null;
            }
            return r;
        }

        private NodoAvl reemplazar(NodoAvl n, NodoAvl act, Logical cambiaAltura)
        {
            if (act.subArbolDcho() != null)
            {
                NodoAvl d;
                d = reemplazar(n, (NodoAvl)act.subArbolDcho(), cambiaAltura);
                act.ramaDcho(d);
                if (cambiaAltura.booleanValue())
                    act = equilibrar2(act, cambiaAltura);
            }
            else
            {
                n.nuevoValor(act.valorNodo());
                n = act;
                act = (NodoAvl)act.subArbolIzdo();
                n = null;
                cambiaAltura.setLogical(true);
            }
            return act;
        }

        private NodoAvl equilibrar1(NodoAvl n, Logical cambiaAltura)
        {
            NodoAvl n1;
            switch (n.fe)
            {
                case -1:
                    n.fe = 0;
                    break;
                case 0:
                    n.fe = 1;
                    cambiaAltura.setLogical(false);
                    break;
                case +1: //se aplicar un tipo de rotación derecha
                    n1 = (NodoAvl)n.subArbolDcho();
                    if (n1.fe >= 0)
                    {
                        if (n1.fe == 0) //la altura no vuelve a disminuir
                            cambiaAltura.setLogical(false);
                        n = rotacionDD(n, n1);
                    }
                    else
                        n = rotacionDI(n, n1);
                    break;
            }
            return n;
        }

        private NodoAvl equilibrar2(NodoAvl n, Logical cambiaAltura)
        {
            NodoAvl n1;
            switch (n.fe)
            {
                case -1: // Se aplica un tipo de rotación izquierda
                    n1 = (NodoAvl)n.subArbolIzdo();
                    if (n1.fe <= 0)
                    {
                        if (n1.fe == 0)
                            cambiaAltura.setLogical(false);
                        n = rotacionII(n, n1);
                    }
                    else
                        n = rotacionID(n, n1);
                    break;
                case 0:
                    n.fe = -1;
                    cambiaAltura.setLogical(false);
                    break;
                case +1:
                    n.fe = 0;
                    break;
            }
            return n;
        }

        bool esVacio()
        {
            return raiz == null;
        }

        public static List<Equipo> orden(NodoArbolBusqueda r, List<Equipo> lista)
        {
            if (r != null)
            {
                lista.Add((Equipo)r.valorNodo());
                if (r.subArbolIzdo() != null)
                {
                    orden(r.subArbolIzdo(), lista);
                }
                if (r.subArbolDcho() != null)
                {
                    orden(r.subArbolDcho(), lista);
                }
            }
            return lista;
        }

        //Devuelve el número de nodos que tiene el árbol
        public int numNodos(NodoArbolBusqueda raiz)
        {
            if (raiz == null)
                return 0;
            else
                return 1 + numNodos(raiz.subArbolIzdo()) +
                numNodos(raiz.subArbolDcho());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.ListaEnlazada
{
    public class Nodo
    {
        public Object Dato;
        public Nodo Enlace;

        public Nodo(object vDato)
        {
            this.Dato = vDato;
            this.Enlace = null;
        }
    }
}

using EstructuraDatos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Clases
{
    public class Equipo : Comparador
    {
        public string nombre { get; set; }
        public string pais { get; set; }
        public string liga { get; set; }

        public Equipo(string nombre, string pais, string liga) {
            this.nombre = nombre;
            this.pais = pais;
            this.liga = liga;
        }

        public bool igualQue(string q)
        {
            return this.nombre == q;
        }

        public bool menorQue(string q)
        {
            if (this.nombre.CompareTo(q) < 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool mayorQue(string q)
        {
            if (this.nombre.CompareTo(q) > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool igualQue(object q)
        {
            Equipo q2 = (Equipo)q;
            return this.nombre == q2.nombre;
        }

        public bool menorQue(object q)
        {
            Equipo q2 = (Equipo)q;
            if (this.nombre.CompareTo(q2.nombre) < 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool mayorQue(object q)
        {
            Equipo q2 = (Equipo)q;
            if (this.nombre.CompareTo(q2.nombre) > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

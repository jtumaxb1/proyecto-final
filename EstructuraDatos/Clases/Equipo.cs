﻿using EstructuraDatos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Clases
{
    public class Equipo : Comparador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string pais { get; set; }
        public string liga { get; set; }

        public Equipo(int id, string nombre, string pais, string liga) {
            this.id = id;
            this.nombre = nombre;
            this.pais = pais;
            this.liga = liga;
        }

        public bool igualQue(int q)
        {
            return this.id == q;
        }

        public bool menorQue(int q)
        {
            return this.id < q;
        }

        public bool mayorQue(int q)
        {
            return this.id > q;
        }

        public bool igualQue(object q)
        {
            Equipo q2 = (Equipo)q;
            return this.id == q2.id;
        }

        public bool menorQue(object q)
        {
            Equipo q2 = (Equipo)q;
            return this.id < q2.id;
        }

        public bool mayorQue(object q)
        {
            Equipo q2 = (Equipo)q;
            return this.id > q2.id;
        }
    }
}

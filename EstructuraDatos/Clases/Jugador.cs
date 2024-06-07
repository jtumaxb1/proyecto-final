using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Clases
{
    public class Jugador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dorsal { get; set; }
        public string posicion { get; set; }
        public int goles { get; set; }
        public int tarjetaAmarillas { get; set; }
        public int tarjetaRojas { get; set; }

        public Jugador(int id, string nombre, string apellido, int dorsal, string posicion) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dorsal = dorsal;
            this.posicion = posicion;
            this.goles = 0;
            this.tarjetaAmarillas = 0;
            this.tarjetaRojas = 0;
        }

    }
}

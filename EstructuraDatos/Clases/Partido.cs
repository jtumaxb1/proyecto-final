using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.Clases
{
    public class Partido
    {
        public int id { get; set; }
        public string equipoLocal { get; set; }
        public int marcadorLocal { get; set; }
        public string equipoVisitante { get; set; }
        public int marcadorVisitante { get; set; }
        public bool flag { get; set; }

        public Partido(int id, string equipoLocal, string equipoVisitante)
        {
            this.id = id;
            this.equipoLocal = equipoLocal;
            this.marcadorLocal = 0;
            this.equipoVisitante = equipoVisitante;
            this.marcadorVisitante = 0;
            this.flag = true;
        }
    }
}

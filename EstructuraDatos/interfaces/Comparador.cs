using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos.interfaces
{
    public interface Comparador
    {
        // Buscar por nombre
        bool igualQue(string q);
        bool menorQue(string q);
        bool mayorQue(string q);

        // Buscado
        bool igualQue(int q);
        bool menorQue(int q);
        bool mayorQue(int q);

        // Insertar y Eliminar
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool mayorQue(Object q);
    }
}

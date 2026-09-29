using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface IABM <T> where T : class
    {
        void Agregar(T obj);
        void Borrar(T obj);
        void Modificar(T obj);
    }
}

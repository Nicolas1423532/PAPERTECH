using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Idioma
    {
        string id_Idioma;
        string nombre;
        public BE_Idioma(string id, string pNombre)
        {
            id_Idioma = id;
            nombre = pNombre;
        }
        public override string ToString() => nombre;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Idioma
    {
        public string Id_Idioma { get; set; }
        public string Nombre { get; set; }
        public BE_Idioma(string id, string pNombre)
        {
            Id_Idioma = id;
            Nombre = pNombre;
        }
        public override string ToString() => Nombre;
    }
}

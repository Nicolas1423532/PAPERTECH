using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BE_Rol
    {
        public string Id_rol { get; set; }
        public string Titulo {  get; set; }
        public abstract List<BE_Rol> RetornarComponentes();
        public virtual List<BE_Rol> RetornarComponentesPlanos() => new List<BE_Rol> { this };
    }
}

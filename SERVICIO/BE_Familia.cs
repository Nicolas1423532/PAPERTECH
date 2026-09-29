using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Familia : BE_Rol
    {
        private readonly List<BE_Rol> componentes = new List<BE_Rol>();

        public BE_Familia(string idRol, string titulo)
        {
            Id_rol = idRol;
            Titulo = titulo;
        }

        public void AgregarComponente(BE_Rol componente)
        {
            if (!componentes.Exists(r => r.Id_rol == componente.Id_rol))
                componentes.Add(componente);
        }

        public void QuitarComponente(BE_Rol componente)
        {
            componentes.RemoveAll(r => r.Id_rol == componente.Id_rol);
        }

        public override List<BE_Rol> RetornarComponentes() => componentes;

        // Recursion delegada al polimorfismo: cada componente sabe aplanarse
        // a si mismo (Patente => ella misma; Familia => sigue recorriendo).
        // No hace falta ningun "if (componente is BE_Familia)" aca.
        public override List<BE_Rol> RetornarComponentesPlanos()
        {
            var planos = new List<BE_Rol>();
            foreach (BE_Rol componente in componentes)
                planos.AddRange(componente.RetornarComponentesPlanos());
            return planos;
        }
        public BE_Familia() { }

        public BE_Familia(object[] datos)
        {
            this.Id_rol = datos[0].ToString();
            this.Titulo = datos[1].ToString();
        }
    }
}

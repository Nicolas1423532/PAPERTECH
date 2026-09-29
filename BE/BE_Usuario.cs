using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuario
    {
        public string Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Edad { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool Activo { get; set; }
        public BE_Usuario() { }
        public BE_Usuario(string idUsuario, string _nombre, string _apellido, int _dni, int _edad, string _nombreUsuario, string _contraseña, bool _activo)
        {
            Id_usuario = idUsuario;
            Nombre = _nombre;
            Apellido = _apellido;
            Dni = _dni;
            Edad = _edad;
            NombreUsuario = _nombreUsuario;
            Contraseña = _contraseña;
            Activo = _activo;
        }
        public BE_Usuario(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4]), datos[5].ToString(), datos[6].ToString(), Convert.ToBoolean(datos[7])) 
        { }
    }
}

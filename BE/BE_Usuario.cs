using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuario
    {
        string id_usuario;
        string nombre;
        string apellido;
        int dni;
        int edad;
        string email;
        string contraseña;
        string rol;
        bool activo;
        public BE_Usuario() { }
        public BE_Usuario(string idUsuario, string _nombre, string _apellido, int _dni, int _edad, string _email, string _contraseña, string _rol, bool _activo)
        {
            id_usuario = idUsuario;
            nombre = _nombre;
            apellido = _apellido;
            dni = _dni;
            edad = _edad;
            email = _email;
            contraseña = _contraseña;
            rol = _rol;
            activo = _activo;
        }
        public BE_Usuario(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4]), datos[5].ToString(), datos[6].ToString(), datos[7].ToString(), Convert.ToBoolean(datos[8])) 
        { }
    }
}

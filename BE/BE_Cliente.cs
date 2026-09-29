using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Cliente
    {
        public string Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        public BE_Cliente() { }
        public BE_Cliente(string idCliente, string _nombre, string _apellido, int _dni)
        {
            Id_cliente = idCliente;
            Nombre = _nombre;
            Apellido = _apellido;
            Dni = _dni;
        }
        public BE_Cliente(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]))
        { }
    }
}

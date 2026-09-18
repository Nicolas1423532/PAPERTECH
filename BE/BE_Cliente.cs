using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Cliente
    {
        string id_cliente;
        string nombre;
        string apellido;
        int dni;

        public BE_Cliente() { }
        public BE_Cliente(string idCliente, string _nombre, string _apellido, int _dni)
        {
            id_cliente = idCliente;
            nombre = _nombre;
            apellido = _apellido;
            dni = _dni;
        }
        public BE_Cliente(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]))
        { }
    }
}

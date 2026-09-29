using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Proveedor
    {
        public string Id_proveedor {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public BE_Proveedor() { }
        public BE_Proveedor(string idProveedor, string _nombre, string _apellido, int _telefono, string _direccion)
        {
            Id_proveedor = idProveedor;
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            Direccion = _direccion;
        }
        public BE_Proveedor(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]), (datos[4]).ToString())
        { }
    }
}

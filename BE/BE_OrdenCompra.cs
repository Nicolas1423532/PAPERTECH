using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class BE_OrdenCompra
    {
        public string Id_OrdenCompra { get; set; }
        public int Cantidad_Solicitada { get; set; }
        public string Descripcion { get; set; }
        public string Nombre_Producto { get; set; }
        public string Nombre_Proveedor { get; set; }
        public BE_OrdenCompra() { }
        public BE_OrdenCompra(string id_ordenCompra, int cantidad_solicitada, string descripcion, string nombre_producto, string nombre_Proveedor)
        {
            Id_OrdenCompra = id_ordenCompra;
            Cantidad_Solicitada = cantidad_solicitada;
            Descripcion = descripcion;
            Nombre_Producto = nombre_producto;
            Nombre_Proveedor = nombre_Proveedor;
        }
        public BE_OrdenCompra(object[] datos) : this(datos[0].ToString(), Convert.ToInt32(datos[1]), datos[2].ToString(), datos[3].ToString(), datos[4].ToString())
        { }

    }
}

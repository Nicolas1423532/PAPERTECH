using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Producto
    {
        public string Id_producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_unitario { get; set; }
        public int Stock {  get; set; }
        public BE_Producto() { }
        public BE_Producto(string idProducto, string _nombre, string _descripcion, decimal _precioUnitario, int _stock)
        {
            Id_producto = idProducto;
            Nombre = _nombre;
            Descripcion = _descripcion;
            Precio_unitario = _precioUnitario;
            Stock = _stock;
        }
        public BE_Producto(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToDecimal(datos[3]), Convert.ToInt32(datos[4]))
        { }
    }
}

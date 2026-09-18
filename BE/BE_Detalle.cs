using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Detalle
    {
        string id_detalle;
        string id_factura;
        string id_producto;
        int cantidad;
        decimal subtotal;
        decimal precio_venta;
        decimal descuento;
        public BE_Detalle() { }
        public BE_Detalle(string idDetalle, string idFactura, string idProducto, int _cantidad, decimal subTotal, decimal _precioVenta,decimal _descuento)
        {
            id_detalle = idDetalle;
            id_factura = idFactura;
            id_producto = idProducto;
            cantidad = _cantidad;
            subtotal = subTotal;
            precio_venta = _precioVenta;
            descuento = _descuento;
        }
        public BE_Detalle(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]), Convert.ToDecimal(datos[4]), Convert.ToDecimal(datos[5]), Convert.ToDecimal(datos[6]))
        { }
    }
}

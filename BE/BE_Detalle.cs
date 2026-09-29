using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Detalle
    {
        public string Id_detalle { get; set; }
        public string Id_factura { get; set; }
        public string Id_producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Precio_venta { get; set; }
        public decimal Descuento { get; set; }
        public BE_Detalle() { }
        public BE_Detalle(string idDetalle, string idFactura, string idProducto, int _cantidad, decimal subTotal, decimal _precioVenta,decimal _descuento)
        {
            Id_detalle = idDetalle;
            Id_factura = idFactura;
            Id_producto = idProducto;
            Cantidad = _cantidad;
            Subtotal = subTotal;
            Precio_venta = _precioVenta;
            Descuento = _descuento;
        }
        public BE_Detalle(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), Convert.ToInt32(datos[3]), Convert.ToDecimal(datos[4]), Convert.ToDecimal(datos[5]), Convert.ToDecimal(datos[6]))
        { }
    }
}

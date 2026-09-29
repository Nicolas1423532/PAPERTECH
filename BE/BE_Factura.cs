using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Factura
    {
        public string Id_factura { get; set; }
        public string Id_cliente { get; set; }
        public string Descripcion { get; set; }
        public string Metodo_pago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public BE_Factura() { }
        public BE_Factura(string idFactura, string idCliente, string _descripcion, string metodoPago, DateTime fechaEmision, decimal _total)
        {
            Id_factura = idFactura;
            Id_cliente = idCliente;
            Descripcion = _descripcion;
            Metodo_pago = metodoPago;
            Fecha = fechaEmision;
            Total = _total;
        }
        public BE_Factura(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), datos[3].ToString(), Convert.ToDateTime(datos[4]), Convert.ToDecimal(datos[5]))
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BE;
using System.Data;
namespace DAL
{
    public class DAL_Producto : IABM<BE_Producto>
    {
        private DataTable tablaProducto;
        private SqlDataAdapter adapterProducto;
        private SqlCommandBuilder cmbProducto;

        public DAL_Producto()
        {
            tablaProducto = new DataTable("Producto");
            adapterProducto = new SqlDataAdapter("SELECT * FROM Producto", DAL_.ObtenerConexion());
            cmbProducto = new SqlCommandBuilder(adapterProducto);
        }

        public void Agregar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }

        public void Borrar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }

        public List<BE_Producto> ConsultarTodosLosProductos()
        {
            CargarFilasProductos();
            List<BE_Producto> listaProductos = new List<BE_Producto>();
            foreach(DataRow fila in tablaProducto.Rows)
            {
                listaProductos.Add(new BE_Producto(fila.ItemArray));
            }
            return listaProductos;
        }

        public void Modificar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }

        private void CargarFilasProductos()
        {
            tablaProducto.Clear();
            adapterProducto.Fill(tablaProducto);
        }
    }
}

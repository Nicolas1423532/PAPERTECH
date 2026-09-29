using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Producto : IABM<BE_Producto>
    {
        DAL_Producto dalProducto;
        public BLL_Producto()
        {
            dalProducto = new DAL_Producto();
        }

        public void Agregar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }

        public void Borrar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(BE_Producto obj)
        {
            throw new NotImplementedException();
        }
        public List<BE_Producto> ConsultarTodosLosProductos()
        {
           return dalProducto.ConsultarTodosLosProductos().ToList();
        }
    }
}

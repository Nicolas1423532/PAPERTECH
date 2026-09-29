using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Usuario : IABM<BE_Usuario>
    {
        private DataTable tablaUsuario;
        private SqlDataAdapter adapterUsuario;
        private SqlCommandBuilder cmbUsuario;

        public DAL_Usuario()
        {
            tablaUsuario = new DataTable("Usuario");
            adapterUsuario = new SqlDataAdapter("SELECT * FROM Usuario",DAL_.ObtenerConexion());
            cmbUsuario = new SqlCommandBuilder(adapterUsuario);
        }

        public void Agregar(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Borrar(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(BE_Usuario obj)
        {
            throw new NotImplementedException();
        }
        public List<BE_Usuario> ConsultarTodosLosUsuarios()
        {
            List<BE_Usuario> lstUsuarios = new List<BE_Usuario>();
            foreach(DataRow fila in tablaUsuario.Rows)
            {
                lstUsuarios.Add(new BE_Usuario(fila.ItemArray));
            }
            return lstUsuarios;
        }
        private void CargarFilasUsuario()
        {
            tablaUsuario.Clear();
            adapterUsuario.Fill(tablaUsuario);
        }
    }
}

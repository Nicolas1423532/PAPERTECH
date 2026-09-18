using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DAL_
    {
        private const string ServidorPorDefecto = ".";
        private const string BaseDeDatos = "PAPERTECH";
        private const string ArchivoConfig = "config.txt";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ArmarCadena());
        }

        private static string ArmarCadena()
        {
            string servidor = LeerServidor();

            return $"Server={servidor};" +
                   $"Database={BaseDeDatos};" +
                   "Trusted_Connection=True;" +
                   "TrustServerCertificate=True;";
        }
        private static string LeerServidor()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ArchivoConfig);

            if (!File.Exists(ruta))
            {
                return ServidorPorDefecto;
            }

            string servidor = File.ReadAllText(ruta).Trim();

            return string.IsNullOrWhiteSpace(servidor) ? ServidorPorDefecto : servidor;
        }
    }
}

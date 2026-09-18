using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Bitacora
    {
        string id_bitacora;
        string logIn;
        string evento;
        string modulo;
        int criticidad;
        DateTime fecha;

        public BE_Bitacora() { }
        public BE_Bitacora(string id_Bitacora, string pLogIn,string pEvento, string pModulo, int criticidad, DateTime pFecha)
        {
            id_bitacora = id_Bitacora;
            logIn = pLogIn;
            evento = pEvento;
            modulo = pModulo;
            criticidad = criticidad;
            fecha = pFecha;
        }
        public BE_Bitacora(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), datos[3].ToString(), Convert.ToInt16(datos[4]) ,Convert.ToDateTime(datos[5]))
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Bitacora
    {
        public string Id_bitacora { get; set; }
        public string LogIn { get; set; }
        public string Evento { get; set; }
        public string Modulo { get; set; }
        public int Criticidad { get; set; }
        public DateTime Fecha { get; set; }

        public BE_Bitacora() { }
        public BE_Bitacora(string id_Bitacora, string pLogIn,string pEvento, string pModulo, int criticidad, DateTime pFecha)
        {
            Id_bitacora = id_Bitacora;
            LogIn = pLogIn;
            Evento = pEvento;
            Modulo = pModulo;
            Criticidad = criticidad;
            Fecha = pFecha;
        }
        public BE_Bitacora(object[] datos) : this(datos[0].ToString(), datos[1].ToString(), datos[2].ToString(), datos[3].ToString(), Convert.ToInt16(datos[4]) ,Convert.ToDateTime(datos[5]))
        {

        }

    }
}

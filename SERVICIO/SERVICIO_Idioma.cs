using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SERVICIO
{
    public class SERVICIO_Idioma
    {
        private static readonly string RutaPersonalizada = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?
    .Parent?.Parent?.Parent?.Parent?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string RutaIdiomaJson =
           Path.Combine(RutaPersonalizada, "idioma.json");

        private static readonly string RutaTraduccionesJson =
            Path.Combine(RutaPersonalizada, "traducciones.json");

        private string _idiomaActual = "es";   // español por defecto

        // Diccionario cargado en memoria: idioma -> (clave -> texto)
        private Dictionary<string, Dictionary<string, string>> _traducciones
            = new Dictionary<string, Dictionary<string, string>>();

        private List<IObservadorIdioma> _suscriptores = new List<IObservadorIdioma>();

        private static SERVICIO_Idioma? _instancia;

        private SERVICIO_Idioma() { }

        public static SERVICIO_Idioma ObtenerInstancia()
        {
            if (_instancia == null)
                _instancia = new SERVICIO_Idioma();
            return _instancia;
        }
        public void CargarDesdeJson()
        {
            if (File.Exists(RutaIdiomaJson))
            {
                string jsonIdioma = File.ReadAllText(RutaIdiomaJson);
                var doc = JsonDocument.Parse(jsonIdioma);

                if (doc.RootElement.TryGetProperty("idioma", out JsonElement elem))
                {
                    string? codigo = elem.GetString();
                    if (codigo == "es" || codigo == "en")
                        _idiomaActual = codigo;
                }
            }
            CargarTraducciones();
        }

        public string ObtenerIdiomaActual()=> _idiomaActual;
        public void CambiarIdioma(string codigoIdioma)
        {
            if (codigoIdioma != "es" && codigoIdioma != "en")
                throw new Exception($"Idioma '{codigoIdioma}' no soportado. Use 'es' o 'en'.");

            _idiomaActual = codigoIdioma;
            Notificar();
        }
        // OBSERVER
        public void Suscribir(IObservadorIdioma observador)
        {
            if (!_suscriptores.Contains(observador))
                _suscriptores.Add(observador);
        }
        public void Desuscribir(IObservadorIdioma observador)
        {
            _suscriptores.Remove(observador);
        }

        private void Notificar()
        {
            foreach (IObservadorIdioma observador in _suscriptores)
            {
                observador.ActualizarIdioma();
            }
        }
        public string ObtenerTraduccion(string clave)
        {
            if (_traducciones.TryGetValue(_idiomaActual, out var diccionario))
            {
                if (diccionario.TryGetValue(clave, out string? texto))
                    return texto;
            }
            // Si la clave no se encontró se retorna la clave entre corchetes para que sea visible en pantalla y fácil de detectar
            return $"[{clave}]";
        }
        public void GuardarEnJson()
        {
            var contenido = new { idioma = _idiomaActual };
            string json = JsonSerializer.Serialize(contenido, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(RutaIdiomaJson, json);
        }
        private void CargarTraducciones()
        {
            if (!File.Exists(RutaTraduccionesJson))
                throw new FileNotFoundException(
                    $"No se encontró el archivo de traducciones en: {RutaTraduccionesJson}");

            string jsonTraducciones = File.ReadAllText(RutaTraduccionesJson);
            var doc = JsonDocument.Parse(jsonTraducciones);

            _traducciones.Clear();

            // Recorre los idiomas: es y en)
            foreach (var idiomaEntry in doc.RootElement.EnumerateObject())
            {
                string codigoIdioma = idiomaEntry.Name;
                var diccionario = new Dictionary<string, string>();

                // Recorre cada clave-valor dentro del idioma
                foreach (var par in idiomaEntry.Value.EnumerateObject())
                {
                    diccionario[par.Name] = par.Value.GetString() ?? string.Empty;
                }

                _traducciones[codigoIdioma] = diccionario;
            }
        }

    }
}

using System.Configuration;

namespace Hundred.SolicitudPersonal.Infraestructura
{
    public static class Conexion
    {

        public readonly static string Cadena = ConfigurationSettings.AppSettings["cadenaProyectos"].ToString();

    }
}

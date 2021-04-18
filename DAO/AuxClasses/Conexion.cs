using System.Configuration;

namespace DAO
{
    public class Conexion
    {
        public string StrCon { get; }

        #region Conexion
        public Conexion()
        {
            StrCon = ConfigurationManager.ConnectionStrings["DB_ReportesCovid"].ToString();
        }
        #endregion
    }
}

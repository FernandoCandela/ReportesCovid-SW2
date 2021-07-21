using System.Configuration;

namespace DAO
{
    public class Conexion
    {
        public string StrCon { get; }

        #region Conexion
        public Conexion()
        {
            StrCon = "Data Source =reportescovidsw2.database.windows.net; initial catalog=DB_ReportesCovid; User Id=admin1; Password=!administrador123";
        }
        #endregion
    }
}

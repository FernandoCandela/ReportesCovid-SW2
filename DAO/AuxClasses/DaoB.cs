using System;
using System.Data.SqlClient;

namespace DAO
{
    [Serializable]
    public class DaoB : Fields
    {
        protected SqlConnection ObjCn;

        public DaoB()
        {
            var cn = new Conexion();
            ObjCn = new SqlConnection(cn.StrCon);
        }
    }
}

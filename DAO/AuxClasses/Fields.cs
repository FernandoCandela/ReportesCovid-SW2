using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace DAO
{
    public class Fields
    {
        private readonly object _valueObj;

        public Fields()
        {
        }
        public Fields(object value)
        {
            _valueObj = value;
        }
        public Int16 ValueInt16 => _valueObj == null ? Convert.ToInt16(0) : Convert.ToInt16(_valueObj);
        public Int32 ValueInt32 => _valueObj == null ? 0 : Convert.ToInt32(_valueObj);
        public Int64 ValueInt64 => _valueObj == null ? Convert.ToInt64(0) : Convert.ToInt64(_valueObj);
        public String ValueString => _valueObj == null ? string.Empty : Convert.ToString(_valueObj);
        public bool ValueBool => _valueObj != null && Convert.ToBoolean(_valueObj.Equals(true) || _valueObj.Equals(false) ? _valueObj : (int)_valueObj);
        public DateTime ValueDateTime => (DateTime?)_valueObj ?? DateTime.Now;
        public DateTime ValueDateTimeMin => (DateTime?)_valueObj ?? DateTime.MinValue;
        public TimeSpan ValueTimeSpan => (TimeSpan?)_valueObj ?? TimeSpan.MinValue;
        public Decimal ValueDecimal => (decimal?)_valueObj ?? decimal.Zero;
        public Guid ValueGuid => (Guid?)_valueObj ?? Guid.NewGuid();
        public Byte[] ValueBytes => _valueObj == null ? null : ObjectToByteArray(_valueObj);

        #region Methods
        protected Fields GetValue(string miCampo, SqlDataReader reader)
        {
            return reader.GetValue(reader.GetOrdinal(miCampo)) == DBNull.Value ? new Fields(null) : new Fields(reader.GetValue(reader.GetOrdinal(miCampo)));
        }
        protected Fields GetValue(object reader)
        {
            return reader == DBNull.Value ? new Fields(null) : new Fields(reader);
        }
        protected String ToSenteceCase(String sourcestring)
        {
            var lowerCase = sourcestring.ToLower();
            var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
            return r.Replace(lowerCase, s => s.Value.ToUpper());
        }
        public Byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                List<Byte> temp = ms.ToArray().ToList();
                temp.RemoveRange(0, 27);
                return temp.ToArray();
            }
        }
        protected object V_ValidaPrNull(object pr)
        {
            if (pr != null)
                if (pr.GetType().Name == "DateTime")
                {
                    if (pr.ToString().Substring(0, 10) == "01/01/0001" || pr.ToString().Substring(0, 10) == "1/1/0001 1" || pr.ToString().Substring(0, 10) == "1/1/0001 0")
                    { return DBNull.Value; }
                }
            if (pr == null || pr.ToString().Trim() == "" || pr.Equals(0) || pr.Equals(decimal.Zero) || pr.Equals((Int64)0)) return DBNull.Value;
            return pr;

        }
        protected object V_ValidaPrNullWithZeroAllowed(object pr)
        {
            if (pr != null)
                if (pr.GetType().Name == "DateTime")
                {
                    if (pr.ToString().Substring(0, 10) == "01/01/0001" || pr.ToString().Substring(0, 10) == "1/1/0001 1")
                    { return DBNull.Value; }
                }
            if (pr == null || pr.ToString().Trim() == "" || pr.Equals(-1) || pr.Equals((Int32)(-1)) || pr.Equals((Int64)(-1))) return DBNull.Value;
            return pr;

        }
        protected String ToString(string metodo)
        {
            return "\n\rClase error: " + base.ToString() + "\n\rMetodo error: " + metodo;
        }
        #endregion
    }
}

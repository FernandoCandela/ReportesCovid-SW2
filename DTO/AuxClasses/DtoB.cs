using System;
using System.ComponentModel;
using System.Reflection;

namespace DTO
{
    [Serializable]
    public class DtoB : ClassResultV, ICloneable
    {

        private string _msjError;

        [Browsable(false)]
        public string MsjError
        {
            get => _msjError;
            set => _msjError = value;
        }

        [Browsable(false)]
        public DtoB Error(string msj)
        {
            _msjError = msj;
            return this;
        }
        public String Criterio { get; set; }
        #region Miembros de ICloneable

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
public static class Extensions
{
    /// <summary>
    /// Perform a deep Copy of the object.
    /// </summary>
    /// <typeparam name="T">The type of object being copied.</typeparam>
    /// <returns>The copied object.</returns>
    public static T Clone<T>(this T item) where T : ICloneable
    {
        return (T)item.Clone();
    }
    public static bool IsEqualsTo<T>(this T dtoAnt, T dtoNew)
    {
        try
        {
            var type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead)
                {
                    if (property.GetValue(dtoAnt, null) != null && property.GetValue(dtoNew, null) != null)
                    {
                        if (property.GetValue(dtoAnt, null).ToString() != property.GetValue(dtoNew, null).ToString())
                            return false;
                    }
                }
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
}
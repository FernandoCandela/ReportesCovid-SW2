using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace DTO
{
    public class ClassResultV
    {
        string _errorEx;
        string _errorMsj;
        string _lugarError;

        /// <summary>
        /// Lista de  dto's
        /// </summary>
        public List<DtoB> List { get; set; }

        bool _huboError;

        /// <summary>
        /// Tabla de resultado (GET or SET) 
        /// </summary>
        [Browsable(false)]
        public DataTable Dt { get; set; }

        /// <summary>
        /// DataSet de resultado (GET or SET) 
        /// </summary>
        [Browsable(false)]
        public DataSet Ds { get; set; }

        /// <summary>
        /// Nos indica si hubo algun error (GET) 
        /// </summary>
        [Browsable(false)]
        public bool HuboError => _huboError;

        /// <summary>
        /// Lugar de donde se produjo el error (SET) 
        /// </summary>
        [Browsable(false)]
        public string LugarError
        {
            set => _lugarError = value;
        }

        /// <summary>
        /// Msj de error que vera el Usuario (GET or SET) 
        /// </summary>
        [Browsable(false)]
        public string ErrorMsj
        {
            get => _errorMsj;
            set
            {
                _errorMsj = value;
                _huboError = true;
            }
        }

        /// <summary>
        /// Msj de error que provoca la Excepcion (SET) 
        /// </summary>
        [Browsable(false)]
        public string ErrorEx
        {
            set => _errorEx = value;
            get => _errorEx;
        }

        /// <summary>
        /// Nos muestra el detalle del error (GET) 
        /// </summary>
        [Browsable(false)]
        public string Detalle => _errorEx + "\n\rLUGAR DE ERROR :" + _lugarError;


        /// <summary>
        /// Metodo de conversion entre listas (DtoB a T)
        /// </summary>
        /// <typeparam name="T">Tipo de Dto a la cual se convertira la lista</typeparam>
        /// <returns></returns>
        public List<T> ConvertToGenericList<T>()
        {
            if (List == null) List = new List<DtoB>();
            ArrayList arrayList = new ArrayList(List);
            return new List<T>(arrayList.ToArray(typeof(T)) as T[]);
        }
    }
}

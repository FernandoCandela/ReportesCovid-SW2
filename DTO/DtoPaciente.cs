using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPaciente : DtoB
    {
        public int IdPaciente { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IN_Tipodoc { get; set; }
        public string Numdoc { get; set; }
        public int IN_TipoSeguro { get; set; }
        public int IN_EstadoPaciente { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Estado { get; set; }
        //public string Credencial { get; set; }

        ////Nombres de los IN
        //public string NombreTipodoc { get; set; }
        //public string NombreTipoSeguro { get; set; }
        //public string NombreEstadoPaciente { get; set; }




    }
}
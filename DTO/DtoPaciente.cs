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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IN_Tipodoc { get; set; }
        public string Numdoc { get; set; }
        public int IN_TipoSeguro { get; set; }
        public int IN_estadopaciente { get; set; }
        public string UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IN_Estado { get; set; }
        public string Credencial { get; set; }
    }
}
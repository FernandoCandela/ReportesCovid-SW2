using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoCredencial : DtoB
    {
        public int IdCredencial { get; set; }
        public int ContactoId { get; set; }
        public int PacienteId { get; set; }
        public string CrendenciaCod { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Estado { get; set; }
    }
}

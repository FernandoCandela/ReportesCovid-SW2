using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoMensajes : DtoB
    {
        public int IdMensaje {get; set;}
        public String NombreCompleto {get; set;}
        public String Email {get; set;}
        public String Asunto { get; set; }
        public String Mensaje { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Respondido { get; set; }
        public int IdMensajeRespuesta { get; set; }
        public int IN_TipoMensaje { get; set; }
        public int OrganizacionId { get; set; }
    }
}

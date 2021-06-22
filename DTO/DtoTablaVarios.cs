using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoTablaVarios : DtoB
    {
        public int IdTabVarios { get; set; }
        public string Valor { get; set; }
        public string Descripcion{ get; set; }
        public string TipoAtributo{ get; set; }
        public string EntidadTabla{ get; set; }
        public int UsuarioCreacionId{ get; set; }
        public DateTime FechaCreacion{ get; set; }
        public int UsuarioModificacionId{ get; set; }
        public DateTime FechaModificacion{ get; set; }
        public bool IB_Estado { get; set; }
        public String TipoMensaje { get; set; }
}
}

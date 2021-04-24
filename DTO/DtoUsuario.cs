using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoUsuario : DtoB
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Numdoc { get; set; }
        public int IN_tipodoc { get; set; }
        public string Telefono { get; set; }
        public int IN_Rol { get; set; }
        public int IN_CargoId { get; set; }
        public int OrganizacionId { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string IN_estado { get; set; }
    }
}

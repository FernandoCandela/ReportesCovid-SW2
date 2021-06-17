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
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Numdoc { get; set; }
        public int IN_Tipodoc { get; set; }
        public string Telefono { get; set; }
        public int IN_Rol { get; set; }
        public int IN_Cargo { get; set; }
        public int OrganizacionId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Estado { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        //Nombres de los IN
        public string NombreTipodoc { get; set; }
        public string NombreRol { get; set; }
        public string NombreCargo { get; set; }
    }
}

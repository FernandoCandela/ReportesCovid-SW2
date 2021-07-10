using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoOrganizacion : DtoB
    {
        public int IdOrganizacion { get; set; }
        public string NombreOrganizacion { get; set; }
        public string Departamento { get; set; }
        public string Distrito { get; set; }
        public int Capacidad { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Estado { get; set; }
}
}

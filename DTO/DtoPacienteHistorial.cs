using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPacienteHistorial : DtoB
    {
        public int IdHistorial { get; set; }
        public int PacienteId { get; set; }
        public string Temperatura { get; set; }
        public string FrecuenciaCardiaca { get; set; }
        public string PresionArterial { get; set; }
        public string Saturacion { get; set; }
        public string Pronostico { get; set; }
        public string Requerimiento { get; set; }
        public string Evolucion { get; set; }
        public bool IB_Traslado { get; set; }
        public int IN_TipoTraslado { get; set; }
        public string DescTraslado { get; set; }
        public DateTime FechaSolicitudTraslado { get; set; }
        public int OrganizacionId { get; set; }
        public int ContactoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool IB_Estado { get; set; }
        //Datos filtro
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}

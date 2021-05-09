using DTO;
using DAO;

namespace CTR
{
    public class CtrContacto
    {
        public DtoContacto Usp_Contacto_Insert(DtoB dtoBase) => new DaoContacto().Usp_Contacto_Insert(dtoBase);
        public DtoContacto Usp_Contacto_SelectOne(DtoB dtoBase) => new DaoContacto().Usp_Contacto_SelectOne(dtoBase);
        public ClassResultV Usp_Contacto_Update_ByPacienteId(DtoB dtoBase) => new DaoContacto().Usp_Contacto_Update_ByPacienteId(dtoBase);
    }
}

using DTO;
using DAO;

namespace CTR
{
    public class CtrOrganizacion
    {
        public DtoOrganizacion Usp_Organizacion_Insert(DtoB dtoBase) => new DaoOrganizacion().Usp_Organizacion_Insert(dtoBase);
        public ClassResultV Usp_Organizacion_Select(DtoB dtoBase) => new DaoOrganizacion().Usp_Organizacion_SelectAll(dtoBase);
        public ClassResultV Usp_Organizacion_Update_ByIdPaciente(DtoB dtoBase) => new DaoOrganizacion().Usp_Organizacion_Update_ByIdOrganizacion(dtoBase);
        public DtoOrganizacion Usp_Organizacion_SelectOne(DtoB dtoBase) => new DaoOrganizacion().Usp_Organizacion_SelectOne(dtoBase);
    }
}

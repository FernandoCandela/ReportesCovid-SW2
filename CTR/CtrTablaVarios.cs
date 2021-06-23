using DTO;
using DAO;

namespace CTR
{
    public class CtrTablaVarios
    {
        public ClassResultV Usp_TablaVarios_SelectAll(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_SelectAll(dtoBase);
        public ClassResultV Usp_TablaVarios_SelectAll_Admin(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_SelectAll_Admin(dtoBase);
        public DtoTablaVarios Usp_TablaVarios_Insert(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_Insert(dtoBase);
        public DtoTablaVarios Usp_TablaVarios_SelectOne(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_SelectOne(dtoBase);
        public ClassResultV Usp_TablaVarios_Update(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_Update(dtoBase);
    }
}

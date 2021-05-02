using DTO;
using DAO;

namespace CTR
{
    public class CtrTablaVarios
    {
        public ClassResultV Usp_TablaVarios_Select(DtoB dtoBase) => new DaoTablaVarios().Usp_TablaVarios_Select(dtoBase);
    }
}

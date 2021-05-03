using DTO;
using DAO;

namespace CTR
{
    public class CtrCredencial
    {
        public DtoCredencial Usp_Credencial_Insert(DtoB dtoBase) => new DaoCredencial().Usp_Credencial_Insert(dtoBase);
    }
}

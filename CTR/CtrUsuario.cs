using DTO;
using DAO;

namespace CTR
{
    public class CtrUsuario
    {
        public DtoUsuario Usp_Usuario_Login(DtoB dtoBase) => new DaoUsuario().Usp_Usuario_Login(dtoBase);
        public DtoUsuario Usp_Usuario_SelectOne(DtoB dtoBase) => new DaoUsuario().Usp_Usuario_SelectOne(dtoBase);

    }
}

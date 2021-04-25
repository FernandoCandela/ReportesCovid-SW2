using DTO;
using DAO;

namespace CTR
{
    public class CtrUsuario
    {

        public DtoUsuario Usp_Usuario_Login(DtoB dtoBase) => new DaoUsuario().Usp_Usuario_Login(dtoBase);

    }
}

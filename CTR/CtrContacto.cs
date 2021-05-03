using DTO;
using DAO;

namespace CTR
{
    public class CtrContacto
    {
        public DtoContacto Usp_Contacto_Insert(DtoB dtoBase) => new DaoContacto().Usp_Contacto_Insert(dtoBase);
    }
}

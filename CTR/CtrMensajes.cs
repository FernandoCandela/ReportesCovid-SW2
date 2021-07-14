using DTO;
using DAO;

namespace CTR
{
    public class CtrMensajes
    {
        public DtoMensajes Usp_Mensajes_Insert(DtoB dtoBase) => new DaoMensajes().Usp_Mensajes_Insert(dtoBase);
        public ClassResultV Usp_Mensajes_SelectAll(DtoB dtoBase) => new DaoMensajes().Usp_Mensajes_SelectAll(dtoBase);
        public ClassResultV Usp_Mensajes_SelectAll_Contacto(DtoB dtoBase) => new DaoMensajes().Usp_Mensajes_SelectAll_Contacto(dtoBase);
        //public DtoMensajes Usp_Mensajes_SelectOne(DtoB dtoBase) => new DaoMensajes().Usp_Mensajes_SelectOne(dtoBase);
    }
}

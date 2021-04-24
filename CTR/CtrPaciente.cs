using DTO;
using DAO;

namespace CTR
{
    public class CtrPaciente
    {
        public ClassResultV Usp_Paciente_Insert(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Insert(dtoBase);
    }
}

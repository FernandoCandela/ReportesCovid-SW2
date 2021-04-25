using DTO;
using DAO;

namespace CTR
{
    public class CtrPaciente
    {
        public ClassResultV Usp_Paciente_Insert(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Insert(dtoBase);
        public ClassResultV Usp_Paciente_Select(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Select(dtoBase);
        public ClassResultV Usp_Paciente_Update(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Update(dtoBase);
        public ClassResultV Usp_Paciente_Update_Estado(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Update_Estado(dtoBase);
    }
}

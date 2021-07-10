using DTO;
using DAO;

namespace CTR
{
    public class CtrPaciente
    {
        public DtoPaciente Usp_Paciente_Insert(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Insert(dtoBase);
        public ClassResultV Usp_Paciente_Select(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Select(dtoBase);
        public ClassResultV Usp_Paciente_Update_ByIdPaciente(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_Update_ByIdPaciente(dtoBase);
        public DtoPaciente Usp_Paciente_SelectOne(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_SelectOne(dtoBase);
        public ClassResultV Usp_Paciente_ForgotCredential(DtoB dtoBase) => new DaoPaciente().Usp_Paciente_ForgotCredential(dtoBase);
    }
}

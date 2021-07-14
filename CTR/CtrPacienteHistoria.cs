using DTO;
using DAO;

namespace CTR
{
    public class CtrPacienteHistoria
    {
        public DtoPacienteHistorial Usp_PacienteHistorial_Insert(DtoB dtoBase) => new DaoPacienteHistorial().Usp_PacienteHistorial_Insert(dtoBase);
        public DtoPacienteHistorial Usp_PacienteHistorial_Update_ByIdHistorial(DtoB dtoBase) => new DaoPacienteHistorial().Usp_PacienteHistorial_Update_ByIdHistorial(dtoBase);
        public ClassResultV Usp_PacienteHistorial_SelectAll_Usuario(DtoB dtoBase) => new DaoPacienteHistorial().Usp_PacienteHistorial_SelectAll_Usuario(dtoBase);
        public DtoPacienteHistorial Usp_PacienteHistorial_SelectOne(DtoB dtoBase) => new DaoPacienteHistorial().Usp_PacienteHistorial_SelectOne(dtoBase);
    }
}

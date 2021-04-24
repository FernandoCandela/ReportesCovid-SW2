using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoPaciente : DaoB
    {
        public ClassResultV Usp_Paciente_Insert(DtoB dtoBase)
        {
            DtoPaciente dto = (DtoPaciente)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@Nombre", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Nombre)
                };
                pr[1] = new SqlParameter("@Apellido", SqlDbType.VarChar, 200)
                {
                    Value = (dto.Apellido)
                };
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Insert", pr);
                if (pr[2].Value.ToString() != "")
                {
                    cr.LugarError = ToString("Usp_Paciente_Insert()");
                    cr.ErrorMsj = pr[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al crear Paciente";
            }
            ObjCn.Close();
            return cr;
        }
    }
}


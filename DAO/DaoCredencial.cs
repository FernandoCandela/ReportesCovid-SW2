using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DaoCredencial : DaoB
    {
        public DtoCredencial Usp_Credencial_Insert(DtoB dtoBase)
        {
            DtoCredencial dto = (DtoCredencial)dtoBase;
            SqlParameter[] pr = new SqlParameter[9];
            try
            {
                pr[0] = new SqlParameter("@IdCredencial", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@ContactoId", SqlDbType.VarChar, 200)
                {
                    Value = (V_ValidaPrNull(dto.ContactoId))
                };
                pr[2] = new SqlParameter("@PacienteId", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.PacienteId))
                };
                pr[3] = new SqlParameter("@CrendenciaCod", SqlDbType.VarChar, 20)
                {
                    Value = (V_ValidaPrNull(dto.CrendenciaCod))
                };
                pr[4] = new SqlParameter("@UsuarioCreacionId", SqlDbType.VarChar, 50)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioCreacionId))
                };            
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Credencial_Insert", pr);
                dto.IdCredencial = Convert.ToInt32(pr[0].Value);
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al insertar Credencial";
            }
            ObjCn.Close();
            return dto;
        }

    }
}

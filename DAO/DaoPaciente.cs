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
        public ClassResultV Usp_Cliente_Insert(DtoB dtoBase)
        {
            DTOCliente dto = (DTOCliente)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@RUC", SqlDbType.VarChar, 20)
                {
                    Value = (dto.RUC)
                };
                pr[1] = new SqlParameter("@Razon_Social", SqlDbType.VarChar, 200)
                {
                    Value = (dto.Razon_Social)
                };
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Cliente_Insert", pr);
                if (pr[2].Value.ToString() != "")
                {
                    cr.LugarError = ToString("Usp_Cliente_Insert()");
                    cr.ErrorMsj = pr[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al crear Cliente";
            }
            ObjCn.Close();
            return cr;
        }
    }
}


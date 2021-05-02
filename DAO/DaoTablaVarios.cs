using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoTablaVarios : DaoB
    {
        public ClassResultV Usp_TablaVarios_Select(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoTablaVarios)dtoBase;
            SqlParameter[] pr = new SqlParameter[2];
            try
            {
                pr[0] = new SqlParameter("@TipoAtributo", SqlDbType.VarChar, 200)
                {
                    Value = (dto.TipoAtributo)
                };
                pr[1] = new SqlParameter("@EntidadTabla", SqlDbType.VarChar, 200)
                {
                    Value = (dto.EntidadTabla)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_TablaVarios_Select", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    cr.List.Add(new DtoTablaVarios
                    {
                        Valor = GetValue("Valor", reader).ValueString,
                        Descripcion = GetValue("Descripcion", reader).ValueString
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar tabla varios";
            }
            ObjCn.Close();
            return cr;
        }
    }
}

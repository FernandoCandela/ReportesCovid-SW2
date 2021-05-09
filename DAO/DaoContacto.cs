using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoContacto : DaoB
    {
        public DtoContacto Usp_Contacto_Insert (DtoB dtoBase)   
        {
            DtoContacto dto = (DtoContacto)dtoBase;
            SqlParameter[] pr = new SqlParameter[9];
            try
            {
                pr[0] = new SqlParameter("@IdContacto", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@NombreCompleto", SqlDbType.VarChar,200)
                {
                    Value = (V_ValidaPrNull(dto.NombreCompleto))
                };
                pr[2] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Tipodoc))
                };
                pr[3] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (V_ValidaPrNull(dto.Numdoc))
                };
                pr[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50)
                {
                    Value = (V_ValidaPrNull(dto.Email))
                };
                pr[5] = new SqlParameter("@Telefono", SqlDbType.VarChar, 50)
                {
                    Value = (V_ValidaPrNull(dto.Telefono))
                };
                pr[6] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioCreacionId))
                };
                pr[7] = new SqlParameter("@PacienteId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.PacienteId))
                };
                pr[8] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Contacto_Insert", pr);
                dto.IdContacto = Convert.ToInt32(pr[0].Value);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[8].Value)))
                {
                    dto.ErrorMsj = Convert.ToString(pr[8].Value);
                    dto.LugarError = "Usp_Contacto_Insert";
                }
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al insertar Contacto";
            }
            ObjCn.Close();
            return dto;
        }
        public DtoContacto Usp_Contacto_SelectOne (DtoB dtoBase)
        {
            DtoContacto dto = (DtoContacto)dtoBase;
            SqlParameter[] pr = new SqlParameter[1];

            try
            {
                pr[0] = new SqlParameter("@PacienteId", SqlDbType.Int)
                {
                    Value = (dto.PacienteId)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Contacto_SelectOne", pr);

                //cr.List = new List<DtoB>();
                if (reader.Read())
                {
                    dto = new DtoContacto
                    {
                        IdContacto = GetValue("IdContacto", reader).ValueInt32,
                        NombreCompleto = GetValue("NombreCompleto", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        Email = GetValue("Email", reader).ValueString,
                        Telefono = GetValue("Telefono", reader).ValueString,
                        EnvioCredencial = GetValue("EnvioCredencial", reader).ValueBool,
                        FechaEnvioCredencial = GetValue("FechaEnvioCredencial", reader).ValueDateTime,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        PacienteId = GetValue("PacienteId", reader).ValueInt32
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error en Usp_Contacto_SelectOne";
            }
            ObjCn.Close();
            return dto;
        }
    }

}


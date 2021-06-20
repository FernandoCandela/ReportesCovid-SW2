using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoMensajes : DaoB
    {
        public DtoMensajes Usp_Mensajes_Insert(DtoB dtoBase)
        {
            DtoMensajes dto = (DtoMensajes)dtoBase;
            SqlParameter[] pr = new SqlParameter[6];
            try
            {
                pr[0] = new SqlParameter("@IdMensaje", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@NombreCompleto", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.NombreCompleto))
                };
                pr[2] = new SqlParameter("@Email", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Email))
                };
                pr[3] = new SqlParameter("@Asunto", SqlDbType.VarChar, 500)
                {
                    Value = (V_ValidaPrNull(dto.Asunto))
                };
                pr[4] = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500)
                {
                    Value = (V_ValidaPrNull(dto.Mensaje))
                };
                pr[5] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioCreacionId))
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Mensajes_Insert", pr);
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al crear mensaje";
            }
            ObjCn.Close();
            return dto;
        }
        public ClassResultV Usp_Paciente_Select(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoPaciente)dtoBase;
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@Criterio", SqlDbType.VarChar, 300)
                {
                    Value = (dto.Criterio)
                };
                pr[1] = new SqlParameter("@IN_EstadoPaciente", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_EstadoPaciente))
                };
                pr[2] = new SqlParameter("@IB_Estado", SqlDbType.Bit)
                {
                    Value = (dto.IB_Estado)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Select", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    cr.List.Add(new DtoPaciente
                    {
                        IdPaciente = GetValue("IdPaciente", reader).ValueInt32,
                        Nombres = GetValue("Nombres", reader).ValueString,
                        Apellidos = GetValue("Apellidos", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        IN_TipoSeguro = GetValue("IN_TipoSeguro", reader).ValueInt32,
                        IN_EstadoPaciente = GetValue("IN_EstadoPaciente", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        Credencial = GetValue("Credencial", reader).ValueString,
                        NombreTipodoc = GetValue("NombreTipodoc", reader).ValueString,
                        NombreTipoSeguro = GetValue("NombreTipoSeguro", reader).ValueString,
                        NombreEstadoPaciente = GetValue("NombreEstadoPaciente", reader).ValueString
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar usuarios del Paciente";
            }
            ObjCn.Close();
            return cr;
        }
        public DtoMensajes Usp_Mensajes_SelectOne(DtoB dtoBase)
        {
            DtoMensajes dto = (DtoMensajes)dtoBase;
            SqlParameter[] pr = new SqlParameter[1];

            try
            {
                pr[0] = new SqlParameter("@IdMensaje", SqlDbType.Int)
                {
                    Value = (dto.IdMensaje)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Mensajes_SelectOne", pr);

                if (reader.Read())
                {
                    dto = new DtoMensajes
                    {
                        IdMensaje = GetValue("IdMensaje", reader).ValueInt32,
                        NombreCompleto = GetValue("NombreCompleto", reader).ValueString,
                        Email = GetValue("Email", reader).ValueString,
                        Asunto = GetValue("Asunto", reader).ValueString,
                        Mensaje = GetValue("Mensaje", reader).ValueString,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Respondido = GetValue("IB_Respondido", reader).ValueBool,
                        IdMensajeRespuesta = GetValue("IdMensajeRespuesta", reader).ValueInt32,
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error en Usp_Mensajes_SelectOne";
            }
            ObjCn.Close();
            return dto;
        }
    }
}

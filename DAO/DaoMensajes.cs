﻿using DTO;
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
        public ClassResultV Usp_Mensajes_SelectAll(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoMensajes)dtoBase;
            SqlParameter[] pr = new SqlParameter[2];
            try
            {
                pr[0] = new SqlParameter("@Criterio", SqlDbType.VarChar, 300)
                {
                    Value = (dto.Criterio)
                };
                pr[1] = new SqlParameter("@IB_Respondido", SqlDbType.Bit)
                {
                    Value = (dto.IB_Respondido)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Mensajes_SelectAll", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    cr.List.Add(new DtoMensajes
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
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al mostrar la bandeja de entrada";
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
using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoPacienteHistorial : DaoB
    {
        public DtoPacienteHistorial Usp_PacienteHistorial_Insert(DtoB dtoBase)
        {
            DtoPacienteHistorial dto = (DtoPacienteHistorial)dtoBase;
            SqlParameter[] pr = new SqlParameter[15];
            try
            {
                pr[0] = new SqlParameter("@IdHistorial", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@PacienteId", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.PacienteId))
                };
                pr[2] = new SqlParameter("@Temperatura", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Temperatura))
                };
                pr[3] = new SqlParameter("@FrecuenciaCardiaca", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.FrecuenciaCardiaca))
                };
                pr[4] = new SqlParameter("@PresionArterial", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.PresionArterial))
                };
                pr[5] = new SqlParameter("@Saturacion", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Saturacion))
                };
                pr[6] = new SqlParameter("@Pronostico", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Pronostico))
                };
                pr[7] = new SqlParameter("@Requerimiento", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Requerimiento))
                };
                pr[8] = new SqlParameter("@Evolucion", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Evolucion))
                };
                pr[9] = new SqlParameter("@IB_Traslado", SqlDbType.Bit)
                {
                    Value = (V_ValidaPrNull(dto.IB_Traslado))
                };
                pr[10] = new SqlParameter("@IN_TipoTraslado", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_TipoTraslado))
                };
                pr[11] = new SqlParameter("@DescTraslado", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.DescTraslado))
                };
                pr[12] = new SqlParameter("@FechaSolicitudTraslado", SqlDbType.DateTime)
                {
                    Value = (V_ValidaPrNull(dto.FechaSolicitudTraslado))
                };
                pr[13] = new SqlParameter("@OrganizacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.OrganizacionId))
                };
                pr[14] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioCreacionId))
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_PacienteHistorial_Insert", pr);
                dto.IdHistorial = Convert.ToInt32(pr[0].Value);
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al insertar PacienteHistorial";
            }
            ObjCn.Close();
            return dto;
        }
        public DtoPacienteHistorial Usp_PacienteHistorial_Update_ByIdHistorial(DtoB dtoBase)
        {
            DtoPacienteHistorial dto = (DtoPacienteHistorial)dtoBase;
            SqlParameter[] pr = new SqlParameter[15];
            try
            {
                pr[0] = new SqlParameter("@IdHistorial", SqlDbType.Int)
                {
                    Value = V_ValidaPrNull(dto.IdHistorial)
                };
                pr[1] = new SqlParameter("@Temperatura", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Temperatura))
                };
                pr[2] = new SqlParameter("@FrecuenciaCardiaca", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.FrecuenciaCardiaca))
                };
                pr[3] = new SqlParameter("@PresionArterial", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.PresionArterial))
                };
                pr[4] = new SqlParameter("@Saturacion", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Saturacion))
                };
                pr[5] = new SqlParameter("@Pronostico", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Pronostico))
                };
                pr[6] = new SqlParameter("@Requerimiento", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Requerimiento))
                };
                pr[7] = new SqlParameter("@Evolucion", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.Evolucion))
                };
                pr[8] = new SqlParameter("@IB_Traslado", SqlDbType.Bit)
                {
                    Value = (V_ValidaPrNull(dto.IB_Traslado))
                };
                pr[9] = new SqlParameter("@IN_TipoTraslado", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_TipoTraslado))
                };
                pr[10] = new SqlParameter("@DescTraslado", SqlDbType.VarChar, int.MaxValue)
                {
                    Value = (V_ValidaPrNull(dto.DescTraslado))
                };
                pr[11] = new SqlParameter("@FechaSolicitudTraslado", SqlDbType.DateTime)
                {
                    Value = (V_ValidaPrNull(dto.FechaSolicitudTraslado))
                };
                pr[14] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioModificacionId))
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_PacienteHistorial_Update_ByIdHistorial", pr);

            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al actualizar PacienteHistorial";
            }
            ObjCn.Close();
            return dto;
        }
        public ClassResultV Usp_PacienteHistorial_SelectAll_Usuario(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoPacienteHistorial)dtoBase;
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@PacienteId", SqlDbType.Int)
                {
                    Value = (dto.PacienteId)
                };
                pr[1] = new SqlParameter("@FechaInicio", SqlDbType.Date)
                {
                    Value = V_ValidaPrNull(dto.FechaInicio)
                };
                pr[2] = new SqlParameter("@FechaFin", SqlDbType.Date)
                {
                    Value = V_ValidaPrNull(dto.FechaFin)
                };
                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_PacienteHistorial_SelectAll_Usuario", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    cr.List.Add(new DtoPacienteHistorial
                    {
                        IdHistorial = GetValue("IdHistorial", reader).ValueInt32,
                        PacienteId = GetValue("PacienteId", reader).ValueInt32,
                        Temperatura = GetValue("Temperatura", reader).ValueString,
                        PresionArterial = GetValue("PresionArterial", reader).ValueString,
                        Saturacion = GetValue("Saturacion", reader).ValueString,
                        Pronostico = GetValue("Pronostico", reader).ValueString,
                        Requerimiento = GetValue("Requerimiento", reader).ValueString,
                        Evolucion = GetValue("Evolucion", reader).ValueString,
                        IB_Traslado = GetValue("IB_Traslado", reader).ValueBool,
                        IN_TipoTraslado = GetValue("IN_TipoTraslado", reader).ValueInt32,
                        DescTraslado = GetValue("DescTraslado", reader).ValueString,
                        FechaSolicitudTraslado = GetValue("FechaSolicitudTraslado", reader).ValueDateTime,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        ContactoId = GetValue("ContactoId", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool

                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar usuarios del PacienteHistorial";
            }
            ObjCn.Close();
            return cr;
        }
       
        public DtoPacienteHistorial Usp_PacienteHistorial_SelectOne(DtoB dtoBase)
        {
            //ClassResultV cr = new ClassResultV();
            DtoPacienteHistorial dto = (DtoPacienteHistorial)dtoBase;
            SqlParameter[] pr = new SqlParameter[1];

            try
            {
                pr[0] = new SqlParameter("@IdHistorial", SqlDbType.Int)
                {
                    Value = (dto.IdHistorial)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_PacienteHistorial_SelectOne", pr);

                //cr.List = new List<DtoB>();
                if (reader.Read())
                {
                    dto = new DtoPacienteHistorial
                    {
                        IdHistorial = GetValue("IdHistorial", reader).ValueInt32,
                        PacienteId = GetValue("PacienteId", reader).ValueInt32,
                        Temperatura = GetValue("Temperatura", reader).ValueString,
                        FrecuenciaCardiaca = GetValue("FrecuenciaCardiaca", reader).ValueString,
                        PresionArterial = GetValue("PresionArterial", reader).ValueString,
                        Saturacion = GetValue("Saturacion", reader).ValueString,
                        Pronostico = GetValue("Pronostico", reader).ValueString,
                        Requerimiento = GetValue("Requerimiento", reader).ValueString,
                        Evolucion = GetValue("Evolucion", reader).ValueString,
                        IB_Traslado = GetValue("IB_Traslado", reader).ValueBool,
                        IN_TipoTraslado = GetValue("IN_TipoTraslado", reader).ValueInt32,
                        DescTraslado = GetValue("DescTraslado", reader).ValueString,
                        FechaSolicitudTraslado = GetValue("FechaSolicitudTraslado", reader).ValueDateTime,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        ContactoId = GetValue("ContactoId", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error en Usp_PacienteHistorial_SelectOne";
            }
            ObjCn.Close();
            return dto;
        }
    }

}

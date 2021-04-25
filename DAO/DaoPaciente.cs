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
            SqlParameter[] pr = new SqlParameter[14];
            try
            {
                pr[0] = new SqlParameter("@IdPaciente", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@Nombre", SqlDbType.VarChar, 100)
                {
                    Value = (dto.Nombre)
                };
                pr[2] = new SqlParameter("@Apellido", SqlDbType.VarChar, 100)
                {
                    Value = (dto.Apellido)
                };
                pr[3] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (dto.IN_Tipodoc)
                };
                pr[4] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Numdoc)
                };
                pr[5] = new SqlParameter("@IN_TipoSeguro", SqlDbType.Int)
                {
                    Value = (dto.IN_TipoSeguro)
                };
                pr[6] = new SqlParameter("@IN_estadopaciente", SqlDbType.Int)
                {
                    Value = (dto.IN_estadopaciente)
                };
                pr[7] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (dto.UsuarioCreacionId)
                };
                pr[8] = new SqlParameter("@FechaCreacion", SqlDbType.DateTime)
                {
                    Value = (dto.FechaCreacion)
                };
                pr[9] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (dto.UsuarioModificacionId)
                };
                pr[10] = new SqlParameter("@FechaModificacion", SqlDbType.DateTime)
                {
                    Value = (dto.FechaModificacion)
                };
                pr[11] = new SqlParameter("@IN_Estado", SqlDbType.Int)
                {
                    Value = (dto.IN_Estado)
                };
                pr[12] = new SqlParameter("@Credencial", SqlDbType.VarChar, 200)
                {
                    Value = (dto.Credencial)
                };
                pr[13] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Insert", pr);
                dto.IdPaciente = Convert.ToInt32(pr[0].Value);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[13].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[13].Value);
                    cr.LugarError = "Usp_Paciente_Insert";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al insertar Paciente";
            }
            ObjCn.Close();
            return cr;
        }
        public ClassResultV Usp_Paciente_Select(DtoB dtoBase)
        {
            DtoPaciente dto = (DtoPaciente)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (dto.Nombre)
                };
                pr[1] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Numdoc)
                };
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Select", pr);
                dto.IN_Tipodoc = Convert.ToInt32(pr[0].Value);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[3].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[3].Value);
                    cr.LugarError = "Usp_Paciente_Select";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al buscar al Paciente";
            }
            ObjCn.Close();
            return cr;
        }
        public ClassResultV Usp_Paciente_Update(DtoB dtoBase)
        {
            DtoPaciente dto = (DtoPaciente)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[13];
            try
            {
                pr[0] = new SqlParameter("@Nombre", SqlDbType.VarChar, 100)
                {
                    Value = (dto.Nombre)
                };
                pr[1] = new SqlParameter("@Apellido", SqlDbType.VarChar, 100)
                {
                    Value = (dto.Apellido)
                };
                pr[2] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (dto.IN_Tipodoc)
                };
                pr[3] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Numdoc)
                };
                pr[4] = new SqlParameter("@IN_TipoSeguro", SqlDbType.Int)
                {
                    Value = (dto.IN_TipoSeguro)
                };
                pr[5] = new SqlParameter("@IN_estadopaciente", SqlDbType.Int)
                {
                    Value = (dto.IN_estadopaciente)
                };
                pr[6] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (dto.UsuarioCreacionId)
                };
                pr[7] = new SqlParameter("@FechaCreacion", SqlDbType.DateTime)
                {
                    Value = (dto.FechaCreacion)
                };
                pr[8] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (dto.UsuarioModificacionId)
                };
                pr[9] = new SqlParameter("@FechaModificacion", SqlDbType.DateTime)
                {
                    Value = (dto.FechaModificacion)
                };
                pr[10] = new SqlParameter("@IN_Estado", SqlDbType.Int)
                {
                    Value = (dto.IN_Estado)
                };
                pr[11] = new SqlParameter("@Credencial", SqlDbType.VarChar, 200)
                {
                    Value = (dto.Credencial)
                };
                pr[12] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Update", pr);
                dto.IdPaciente = Convert.ToInt32(pr[0].Value);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[12].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[12].Value);
                    cr.LugarError = "Usp_Paciente_Update";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar los datos del paciente";
            }
            ObjCn.Close();
            return cr;
        }
        public ClassResultV Usp_Paciente_Update_Estado(DtoB dtoBase)
        {
            DtoPaciente dto = (DtoPaciente)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[4];
            try
            {
                pr[0] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (dto.IN_Tipodoc)
                };
                pr[1] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Numdoc)
                };
                
                pr[2] = new SqlParameter("@IN_Estado", SqlDbType.Int)
                {
                    Value = (dto.IN_Estado)
                };
                pr[3] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Update_Estado", pr);
                dto.IdPaciente = Convert.ToInt32(pr[0].Value);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[3].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[3].Value);
                    cr.LugarError = "Usp_Paciente_Update_Estado";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar el estado del paciente";
            }
            ObjCn.Close();
            return cr;
        }
    }
}
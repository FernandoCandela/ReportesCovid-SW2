using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DaoUsuario : DaoB
    {
        public DtoUsuario Usp_Usuario_Login(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            SqlParameter[] pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@Correo", SqlDbType.VarChar, 200) { Value = dto.Usuario };
                pr[1] = new SqlParameter("@Password", SqlDbType.VarChar, 100) { Value = dto.Contrasena };
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_Login", pr);
                if (reader.Read())
                {
                    dto = new DtoUsuario
                    {
                        IdUsuario = GetValue("IdUsuario", reader).ValueInt32,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Telefono = GetValue("ApMat", reader).ValueString,
                        IN_Rol = GetValue("IN_Rol", reader).ValueInt32,
                        IN_Cargo = GetValue("IN_Cargo", reader).ValueInt32,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        NombreRol = GetValue("NombreRol", reader).ValueString,
                        NombreCargo = GetValue("NombreCargo", reader).ValueString
                    };
                }
                reader.Close();
                if (!String.IsNullOrEmpty(Convert.ToString(pr[2].Value)))
                {
                    dto.ErrorMsj = Convert.ToString(pr[2].Value);
                    dto.LugarError = "Usp_Usuario_Login";
                }
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al loguear usuario";
            }
            ObjCn.Close();
            return dto;
        }



        //public ClassResultV Usp_Usuario_Insert(DtoB dtoBase)
        //{
        //    DtoUsuario dto = (DtoUsuario)dtoBase;
        //    ClassResultV cr = new ClassResultV();
        //    SqlParameter[] pr = new SqlParameter[14];
        //    try
        //    {
        //        pr[0] = new SqlParameter("@IdPaciente", SqlDbType.Int)
        //        {
        //            Direction = ParameterDirection.Output
        //        };
        //        pr[1] = new SqlParameter("@Nombre", SqlDbType.VarChar, 100)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[2] = new SqlParameter("@Apellido", SqlDbType.VarChar, 100)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[3] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[4] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[5] = new SqlParameter("@IN_TipoSeguro", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[6] = new SqlParameter("@IN_estadopaciente", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[7] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[8] = new SqlParameter("@FechaCreacion", SqlDbType.DateTime)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[9] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[10] = new SqlParameter("@FechaModificacion", SqlDbType.DateTime)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[11] = new SqlParameter("@IN_Estado", SqlDbType.Int)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[12] = new SqlParameter("@Credencial", SqlDbType.VarChar, 200)
        //        {
        //            Value = (dto.Nombres)
        //        };
        //        pr[13] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
        //        {
        //            Direction = ParameterDirection.Output
        //        };
        //        SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Paciente_Insert", pr);
        //        dto.IdPaciente = Convert.ToInt32(pr[0].Value);
        //        if (!String.IsNullOrEmpty(Convert.ToString(pr[13].Value)))
        //        {
        //            cr.ErrorMsj = Convert.ToString(pr[13].Value);
        //            cr.LugarError = "Usp_Paciente_Insert";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        cr.LugarError = ex.StackTrace;
        //        cr.ErrorEx = ex.Message;
        //        cr.ErrorMsj = "Error al insertar Usuario";
        //    }
        //    ObjCn.Close();
        //    return cr;
        //}
    }
}

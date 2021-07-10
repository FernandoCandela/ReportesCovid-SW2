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
                pr[0] = new SqlParameter("@Usuario", SqlDbType.VarChar, 200) { Value = dto.Usuario };
                pr[1] = new SqlParameter("@Contrasena", SqlDbType.VarChar, 100) { Value = dto.Contrasena };
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100) { Direction = ParameterDirection.Output };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_Login", pr);
                if (reader.Read())
                {
                    dto = new DtoUsuario
                    {
                        IdUsuario = GetValue("IdUsuario", reader).ValueInt32,
                        Usuario = GetValue("Usuario", reader).ValueString,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Telefono = GetValue("Telefono", reader).ValueString,
                        IN_Rol = GetValue("IN_Rol", reader).ValueInt32,
                        IN_Cargo = GetValue("IN_Cargo", reader).ValueInt32,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        PrimerNombre = GetValue("PrimerNombre", reader).ValueString,
                        SegundoNombre = GetValue("SegundoNombre", reader).ValueString,
                        ApellidoPaterno = GetValue("ApellidoPaterno", reader).ValueString,
                        ApellidoMaterno = GetValue("ApellidoMaterno", reader).ValueString,
                        Email = GetValue("Email", reader).ValueString,
                        NombreRol = GetValue("NombreRol", reader).ValueString,
                        NombreCargo = GetValue("NombreCargo", reader).ValueString,
                        NombreOrganizacion = GetValue("NombreOrganizacion", reader).ValueString
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

        public DtoUsuario Usp_Usuario_SelectOne(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            SqlParameter[] pr = new SqlParameter[1];

            try
            {
                pr[0] = new SqlParameter("@IdUsuario", SqlDbType.Int)
                {
                    Value = (dto.IdUsuario)
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_SelectOne", pr);

                //cr.List = new List<DtoB>();
                if (reader.Read())
                {
                    dto = new DtoUsuario
                    {
                        IdUsuario = GetValue("IdUsuario", reader).ValueInt32,
                        Usuario = GetValue("Usuario", reader).ValueString,
                        Contrasena = GetValue("Contrasena", reader).ValueString,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Telefono = GetValue("Telefono", reader).ValueString,
                        IN_Rol = GetValue("IN_Rol", reader).ValueInt32,
                        IN_Cargo = GetValue("IN_Cargo", reader).ValueInt32,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        PrimerNombre = GetValue("PrimerNombre", reader).ValueString,
                        SegundoNombre = GetValue("SegundoNombre", reader).ValueString,
                        ApellidoPaterno = GetValue("ApellidoPaterno", reader).ValueString,
                        ApellidoMaterno = GetValue("ApellidoMaterno", reader).ValueString,
                        Email = GetValue("Email", reader).ValueString,
                        NombreRol = GetValue("NombreRol", reader).ValueString,
                        NombreCargo = GetValue("NombreCargo", reader).ValueString
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error en Usp_Usuario_SelectOne";
            }
            ObjCn.Close();
            return dto;
        }

        public ClassResultV Usp_Usuario_SelectAll(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoUsuario)dtoBase;
            SqlParameter[] pr = new SqlParameter[4];
            try
            {
                pr[0] = new SqlParameter("@Criterio", SqlDbType.VarChar, 300)
                {
                    Value = (dto.Criterio)
                };
                pr[1] = new SqlParameter("@IB_Estado", SqlDbType.Bit)
                {
                    Value = (dto.IB_Estado)
                };
                pr[2] = new SqlParameter("@IN_Rol", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Rol))
                };
                pr[3] = new SqlParameter("@OrganizacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.OrganizacionId))
                };

                SqlDataReader reader = SqlHelper.ExecuteReader(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_SelectAll", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    cr.List.Add(new DtoUsuario
                    {
                        IdUsuario = GetValue("IdUsuario", reader).ValueInt32,
                        Usuario = GetValue("Usuario", reader).ValueString,
                        Numdoc = GetValue("Numdoc", reader).ValueString,
                        IN_Tipodoc = GetValue("IN_Tipodoc", reader).ValueInt32,
                        Telefono = GetValue("Telefono", reader).ValueString,
                        IN_Rol = GetValue("IN_Rol", reader).ValueInt32,
                        IN_Cargo = GetValue("IN_Cargo", reader).ValueInt32,
                        OrganizacionId = GetValue("OrganizacionId", reader).ValueInt32,
                        UsuarioCreacionId = GetValue("UsuarioCreacionId", reader).ValueInt32,
                        FechaCreacion = GetValue("FechaCreacion", reader).ValueDateTime,
                        UsuarioModificacionId = GetValue("UsuarioModificacionId", reader).ValueInt32,
                        FechaModificacion = GetValue("FechaModificacion", reader).ValueDateTime,
                        IB_Estado = GetValue("IB_Estado", reader).ValueBool,
                        PrimerNombre = GetValue("PrimerNombre", reader).ValueString,
                        SegundoNombre = GetValue("SegundoNombre", reader).ValueString,
                        ApellidoPaterno = GetValue("ApellidoPaterno", reader).ValueString,
                        ApellidoMaterno = GetValue("ApellidoMaterno", reader).ValueString,
                        Email = GetValue("Email", reader).ValueString,
                        NombreTipodoc = GetValue("NombreTipodoc", reader).ValueString,
                        NombreRol = GetValue("NombreRol", reader).ValueString,
                        NombreCargo = GetValue("NombreCargo", reader).ValueString
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Usuarios";
            }
            ObjCn.Close();
            return cr;
        }

        public DtoUsuario Usp_Usuario_Insert(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            //ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[17];
            try
            {
                pr[0] = new SqlParameter("@IdUsuario", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                pr[1] = new SqlParameter("@Usuario", SqlDbType.VarChar, 100)
                {
                    Value = (dto.Usuario)
                };
                pr[2] = new SqlParameter("@Contrasena", SqlDbType.VarChar, 200)
                {
                    Value = (dto.Contrasena)
                };
                pr[3] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Numdoc)
                };
                pr[4] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (dto.IN_Tipodoc)
                };
                pr[5] = new SqlParameter("@Telefono", SqlDbType.VarChar, 20)
                {
                    Value = (dto.Telefono)
                };
                pr[6] = new SqlParameter("@IN_Rol", SqlDbType.Int)
                {
                    Value = (dto.IN_Rol)
                };
                pr[7] = new SqlParameter("@IN_Cargo", SqlDbType.Int)
                {
                    Value = (dto.IN_Cargo)
                };
                pr[8] = new SqlParameter("@OrganizacionId", SqlDbType.Int)
                {
                    Value = (dto.OrganizacionId)
                };
                pr[9] = new SqlParameter("@UsuarioCreacionId", SqlDbType.Int)
                {
                    Value = (dto.UsuarioCreacionId)
                };
                pr[10] = new SqlParameter("@IB_Estado", SqlDbType.Bit)
                {
                    Value = (dto.IB_Estado)
                };
                pr[11] = new SqlParameter("@PrimerNombre", SqlDbType.VarChar, 100)
                {
                    Value = (dto.PrimerNombre)
                };
                pr[12] = new SqlParameter("@SegundoNombre", SqlDbType.VarChar, 100)
                {
                    Value = (dto.SegundoNombre)
                };
                pr[13] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar, 100)
                {
                    Value = (dto.ApellidoPaterno)
                };
                pr[14] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 100)
                {
                    Value = (dto.ApellidoMaterno)
                };
                pr[15] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                pr[16] = new SqlParameter("@Email", SqlDbType.VarChar, 50)
                {
                    Value = dto.Email
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_Insert", pr);
                if (pr[0].Value != DBNull.Value)
                {
                    dto.IdUsuario = Convert.ToInt32(pr[0].Value);
                }
                if (!String.IsNullOrEmpty(Convert.ToString(pr[15].Value)))
                {
                    dto.ErrorMsj = Convert.ToString(pr[15].Value);
                    dto.LugarError = "Usp_Usuario_Insert";
                }
            }
            catch (Exception ex)
            {
                dto.LugarError = ex.StackTrace;
                dto.ErrorEx = ex.Message;
                dto.ErrorMsj = "Error al insertar Usuario";
            }
            ObjCn.Close();
            return dto;
        }

        public ClassResultV Usp_Usuario_Update(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[16];
            try
            {
                pr[0] = new SqlParameter("@IdUsuario", SqlDbType.Int)
                {
                    Value = (dto.IdUsuario)
                };
                pr[1] = new SqlParameter("@Usuario", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Usuario))
                };
                pr[2] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (V_ValidaPrNull(dto.Numdoc))
                };
                pr[3] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Tipodoc))
                };
                pr[4] = new SqlParameter("@Telefono", SqlDbType.VarChar, 20)
                {
                    Value = (V_ValidaPrNull(dto.Telefono))
                };
                pr[5] = new SqlParameter("@IN_Rol", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Rol))
                };
                pr[6] = new SqlParameter("@IN_Cargo", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Cargo))
                };
                pr[7] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioModificacionId))
                };
                pr[8] = new SqlParameter("@IB_Estado", SqlDbType.Bit)
                {
                    Value = (V_ValidaPrNull(dto.IB_Estado))
                };
                pr[9] = new SqlParameter("@PrimerNombre", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.PrimerNombre))
                };
                pr[10] = new SqlParameter("@SegundoNombre", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.SegundoNombre))
                };
                pr[11] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar,100)
                {
                    Value = (V_ValidaPrNull(dto.ApellidoPaterno))
                };
                pr[12] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.ApellidoMaterno))
                };
                pr[13] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                pr[14] = new SqlParameter("@Email", SqlDbType.VarChar, 50)
                {
                    Value = (V_ValidaPrNull(dto.Email))
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_Update", pr);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[13].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[13].Value);
                    cr.LugarError = "Usp_Usuario_Update";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar los datos del usuario";
            }
            ObjCn.Close();
            return cr;
        }
        public ClassResultV Usp_Usuario_ForgotPassword(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[6];
            try
            {
                
                pr[0] = new SqlParameter("@Usuario", SqlDbType.VarChar, 100)
                {
                    Value = (V_ValidaPrNull(dto.Usuario))
                };
                pr[1] = new SqlParameter("@Numdoc", SqlDbType.VarChar, 20)
                {
                    Value = (V_ValidaPrNull(dto.Numdoc))
                };
                pr[2] = new SqlParameter("@IN_Tipodoc", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IN_Tipodoc))
                };
                pr[3] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioModificacionId))
                };
                pr[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50)
                {
                    Value = (V_ValidaPrNull(dto.Email))
                };
                pr[5] = new SqlParameter("@NuevaContrasena", SqlDbType.VarChar, 200)
                {
                    Value = (V_ValidaPrNull(dto.Contrasena))
                };
                pr[6] = new SqlParameter("@msj", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_ForgotPassword", pr);
                if (!String.IsNullOrEmpty(Convert.ToString(pr[6].Value)))
                {
                    cr.ErrorMsj = Convert.ToString(pr[6].Value);
                    cr.LugarError = "Usp_Usuario_ForgotPassword";
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar la nueva contraseña";
            }
            ObjCn.Close();
            return cr;
        }

        public ClassResultV Usp_Usuario_ResetPassword_Admin(DtoB dtoBase)
        {
            DtoUsuario dto = (DtoUsuario)dtoBase;
            ClassResultV cr = new ClassResultV();
            SqlParameter[] pr = new SqlParameter[3];
            try
            {

                pr[0] = new SqlParameter("@IdUsuario", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.IdUsuario))
                };
                pr[1] = new SqlParameter("@UsuarioModificacionId", SqlDbType.Int)
                {
                    Value = (V_ValidaPrNull(dto.UsuarioModificacionId))
                };
                pr[2] = new SqlParameter("@NuevaContrasena", SqlDbType.VarChar,200)
                {
                    Value = (V_ValidaPrNull(dto.Contrasena))
                };

                SqlHelper.ExecuteNonQuery(ObjCn, CommandType.StoredProcedure, "Usp_Usuario_ResetPassword_Admin", pr);

            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar contraseña";
            }
            ObjCn.Close();
            return cr;
        }
    }
}

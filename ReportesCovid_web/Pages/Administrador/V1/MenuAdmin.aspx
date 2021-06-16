<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="px-4 py-5  text-center">
        <h1 class="display-5 fw-bold mt-4">REPORTE MÉDICO</h1>
    </div>

    <div class="container my-md-5 mt-2">

            <div class="row row-cols-1 row-cols-md-3 mb-3 text-center mt-10">
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Crear Cuenta</h3>
                        </div>
                        <div class="card-body p-5">
                            <i class="fas fa-user-plus d-block mb-3 fa-10x"></i>
                            <asp:LinkButton ID="lnkCrear" runat="server" class="w-75 btn btn-lg btn-primary" PostBackUrl="/CrearUsuario">Crear</asp:LinkButton>

                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Modificar Usuario</h3>
                        </div>
                        <div class="card-body p-5">
                            <i class="fas fa-user-edit d-block mb-3 fa-10x"></i>
                            <asp:LinkButton runat="server" ID="lnkModificar" class="w-75 btn btn-lg btn-primary" PostBackUrl="/ModificarUsuario">Modificar</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Revisar Mensajes</h3>
                        </div>
                        <div class="card-body p-5">
                            <i class="fas fa-envelope d-block mb-3 fa-10x"></i>
                            <asp:LinkButton ID="lnkEntrar" runat="server" class="w-75 btn btn-lg btn-primary" PostBackUrl="/TablaMensaje">Entrar</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>

    </div>
</asp:Content>

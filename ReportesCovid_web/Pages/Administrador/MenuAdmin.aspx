<%@ Page Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-md-5">

        <main>
            <div class="row row-cols-1 row-cols-md-3 mb-3 text-center">
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Crear Cuenta</h3>
                        </div>
                        <div class="card-body p-5">
                            <asp:LinkButton ID="LinkButton1" runat="server" class="w-100 btn btn-lg btn-primary" PostBackUrl="/CrearUsuario">Crear</asp:LinkButton>
                            <%--<a href="4.CrearUsuario.html"><asp:Button runat="server" type="button" class="w-100 btn btn-lg btn-primary" Text="Entrar"></asp:Button></a>--%>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Modificar Usuario</h3>
                        </div>
                        <div class="card-body p-5">
                            <asp:LinkButton runat="server" ID="LinkButton2" class="w-100 btn btn-lg btn-primary" PostBackUrl="/ModificarUsuario">Modificar</asp:LinkButton>
                            <%--<a href="6.ModificarUsuario.html"><asp:Button runat="server" type="button" class="w-100 btn btn-lg btn-primary" Text="Entrar"></asp:Button></a>--%>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Revisar Mensajes</h3>
                        </div>
                        <div class="card-body p-5">
                            <asp:LinkButton ID="LinkButton3" runat="server" class="w-100 btn btn-lg btn-primary" PostBackUrl="/TablaMensaje">Entrar</asp:LinkButton>
                            <%--<a href="7.TablaMensaje.html"><asp:Button runat="server" type="button" class="w-100 btn btn-lg btn-primary" Text="Entrar"></asp:Button></a>--%>
                        </div>
                    </div>
                </div>
            </div>
        </main>

        <footer class="pt-4 my-md-5 pt-md-5 border-top">
            <div class="row">
                <div class="col-12 col-md">
                    <small class="d-block mb-3 text-muted">&copy;   2021</small>
                </div>
            </div>
        </footer>
    </div>
</asp:Content>

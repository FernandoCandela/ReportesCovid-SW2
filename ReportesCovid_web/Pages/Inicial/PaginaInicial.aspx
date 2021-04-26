<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Inicial.Master" CodeBehind="PaginaInicial.aspx.cs" Inherits="ReportesCovid_web.Pages.Inicial.PaginaInicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="px-4 py-5 my-5 text-center">
        <img class="d-block mx-auto mb-4" src="/img/corazon.svg" alt="" width="72" height="57">
        <h1 class="display-5 fw-bold mb-4">JUNTOS CONTRA EL COVID</h1>
        <div class="col-lg-6 mx-auto">
            <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary btn-lg px-4 me-sm-3" PostBackUrl="/logIn">Iniciar Sesion</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-outline-secondary btn-lg px-4" PostBackUrl="/IngresarCredencial">Ingresar credencial</asp:LinkButton>

                <%--<a href="2.InicioSesion.html">
                    <asp:Button runat="server" type="button" class="btn btn-primary btn-lg px-4 me-sm-3" Text="Iniciar Sesion"></asp:Button></a>
                <a href="15.IngresarCredencial.html">
                    <asp:Button runat="server" type="button" class="btn btn-outline-secondary btn-lg px-4" Text="Ingresar Credencial"></asp:Button>
                </a>--%>
            </div>
        </div>
    </div>

</asp:Content>

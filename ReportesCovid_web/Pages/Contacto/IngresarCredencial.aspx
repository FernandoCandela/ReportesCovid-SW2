<%@ Page Language="C#" MasterPageFile="~/MasterPages/Contacto.Master" AutoEventWireup="true" CodeBehind="IngresarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.IngresarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="px-4 py-5 my-5 text-center">
        <img class="d-block mx-auto mb-4" src="/img/corazon.svg" alt="" width="72" height="57">
        <h1 class="display-5 fw-bold">JUNTOS CONTRA EL COVID</h1>
        <div class="col-lg-6 mx-auto">
            <div class="col mb-4">
                <label for="exampleInputCredencial" class="form-label">Credencial</label>
                <input class="form-control" id="exampleInputCredencial">
            </div>
            <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary btn-lg px-4 me-sm-3">Verificar</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-outline-secondary btn-lg px-4">Olvide Credencial</asp:LinkButton>
                <asp:LinkButton ID="LinkButton3" runat="server" class="btn btn-outline-secondary btn-lg px-4" PostBackUrl="/EnviarMensaje">Soporte</asp:LinkButton>

                <%--<a href="#"><asp:Button runat="server" type="button" class="btn btn-primary btn-lg px-4 me-sm-3" Text="Verificar"></asp:Button></a>
                <a href="17.RecuperarCredencial.html"><asp:Button runat="server" type="button" class="btn btn-outline-secondary btn-lg px-4" Text="Olvide Credencial"></asp:Button></a>
                <a href="#"><asp:Button runat="server" type="button" class="btn btn-outline-secondary btn-lg px-4" text="Soporte"></asp:Button></a>--%>
            </div>
        </div>
    </div>
</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/MasterPages/Inicial.Master" AutoEventWireup="true" CodeBehind="IngresarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.IngresarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="px-4 py-5 my-5 text-center">
        <img class="d-block mx-auto mb-4" src="/img/corazon.svg" alt="" width="72" height="57">
        <h1 class="display-5 fw-bold">JUNTOS CONTRA EL COVID</h1>
        <div class="col-lg-6 mx-auto">
            <div class="col mb-4">
                <label for="txtCredencial" class="form-label">Credencial</label>
                <asp:TextBox runat="server" type="password" CssClass="form-control" ClientIDMode="Static" ID="txtCredencial" />
            </div>
            <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <asp:LinkButton ID="lnkIngresar" runat="server" OnClick="LoguearContacto" class="btn btn-primary btn-lg px-4 me-sm-3">Ingresar</asp:LinkButton>
                <%--<asp:LinkButton ID="LinkButton2" runat="server" class="btn btn-outline-secondary btn-lg px-4">Olvide Credencial</asp:LinkButton>--%>
                <%--<asp:LinkButton ID="LinkButton3" runat="server" class="btn btn-outline-secondary btn-lg px-4" PostBackUrl="/EnviarMensaje">Soporte</asp:LinkButton>--%>
            </div>
        </div>
    </div>
</asp:Content>

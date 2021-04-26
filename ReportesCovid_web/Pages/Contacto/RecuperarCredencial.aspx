<%@ Page Language="C#" MasterPageFile="~/MasterPages/Contacto.Master" AutoEventWireup="true" CodeBehind="RecuperarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.RecuperarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="px-4 py-5 my-5 text-center">
        <img class="d-block mx-auto mb-4" src="/img/corazon.svg" alt="" width="72" height="57">
        <h1 class="display-5 fw-bold">JUNTOS CONTRA EL COVID</h1>
        <div class="col-lg-6 mx-auto">
            <div class="col mb-4">
                <label for="exampleInputDniPaciente" class="form-label">DNI (paciente)</label>
                <input type="text" class="form-control" id="exampleInputDniPaciente">
            </div>
            <div class="col mb-4">
                <label for="exampleInputCorreo" class="form-label">Correo</label>
                <input type="email" class="form-control" id="exampleInputCorreo">
            </div>
            <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <asp:Button runat="server" type="button" class="btn btn-primary btn-lg px-4 me-sm-3" Text="Solicitar Credencial"></asp:Button>
            </div>
        </div>
    </div>

</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="ResponderMensaje.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.ResponderMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center mt-4">
        <h1 class="display-5 fw-bold">MENSAJES</h1>
    </div>

    <div class="foto mt-4">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-thumbnail d-block">
    </div>

    <div class="row g-3 mt-4">
        <div class="mb-3 col-md-5">
            <label for="exampleInputNombre" class="form-label">Nombre</label>
            <input class="form-control" id="exampleInputNombre" aria-describedby="nombreHelp" disabled>
        </div>
        <div class="mb-3 col-md-5">
            <label for="exampleInputApellido" class="form-label">Apellidos</label>
            <input class="form-control" id="exampleInputApellido" aria-describedby="apellidoHelp" disabled>
        </div>
        <div class="mb-3 col-md-5">
            <label for="exampleInputCorreo" class="form-label">Correo</label>
            <input class="form-control" id="exampleInputCorreo" disabled>
        </div>
        <div class="mb-3 col-md-5">
            <label for="exampleInputAsunto" class="form-label">Asunto</label>
            <input class="form-control" id="exampleInputAsunto" disabled>
        </div>
        <div class="col-10 form-floating">
            <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea1" style="height: 100px" disabled></textarea>
            <label for="floatingTextarea2">Mensaje</label>
        </div>
        <div class="col-10 form-floating">
            <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea2" style="height: 100px"></textarea>
            <label for="floatingTextarea2">Respuesta</label>
        </div>
        <div class="col-12">
            <asp:Button runat="server" type="submit" class="btn btn-primary w-25 mb-4" Text="Guardar Cambios"></asp:Button>
            <asp:Button runat="server" type="submit" class="btn btn-danger w-25 mb-4" text="Borrar Usuario"></asp:Button>
        </div>
    </div>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.ModificarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center mt-4">
        <h1 class="display-5 fw-bold">MODIFICAR CUENTA</h1>
    </div>

    <div class="foto mt-4">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-thumbnail d-block">
    </div>

    <div class="row g-3 mt-4">
        <div class="mb-3 col-md-5">
            <label for="exampleInputNombre" class="form-label">Nombre</label>
            <input class="form-control" id="exampleInputNombre" aria-describedby="nombreHelp">
        </div>
        <div class="mb-3 col-md-5">
            <label for="exampleInputApellido" class="form-label">Apellidos</label>
            <input class="form-control" id="exampleInputApellido" aria-describedby="apellidoHelp">
        </div>
        <div class="mb-3 col-md-4">
            <label for="exampleInputDni" class="form-label">DNI</label>
            <input class="form-control" id="exampleInputDni">
        </div>
        <div class="mb-3 col-md-5">
            <label for="exampleInputCorreo" class="form-label">Correo</label>
            <input class="form-control" id="exampleInputCorreo">
        </div>
        <div class="mb-3 col-md-4">
            <label for="exampleInputTelefono" class="form-label">Telefono</label>
            <input class="form-control" id="exampleInputTelefono">
        </div>
        <div class="col-md-4 mb-4">
            <label for="inputState" class="form-label">Usuario</label>
            <select id="inputState" class="form-select">
                <option selected>Escoge...</option>
                <option>Médico</option>
                <option>Enfermera</option>
            </select>
        </div>
        <div class="col-12">
            <asp:Button runat="server" type="submit" class="btn btn-primary w-25 mb-4" Text="Guardar Cambios"></asp:Button>
            <asp:Button runat="server" type="submit" class="btn btn-danger w-25 mb-4" Text="Borrar Usuario"></asp:Button>
        </div>
    </div>
</asp:Content>

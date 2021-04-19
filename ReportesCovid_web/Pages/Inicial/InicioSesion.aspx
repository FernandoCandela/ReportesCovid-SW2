<%@ Page Language="C#" MasterPageFile="~/MasterPages/Inicial.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ReportesCovid_web.Pages.Inicial.InicioSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main class="form-signin">
        <asp:Image ID="Image1" runat="server" CssClass="mb-4 float-md-end" ImageUrl="~/img/person.svg" Width="90%" Height="90%"/>
        <form>
            <h1 class="h3 mb-3 fw-normal">Inicio de Sesion</h1>

            <div class="form-floating">
                <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
                <label for="floatingInput">Correo</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
                <label for="floatingPassword">Contraseña</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me">
                    Remember me
                </label>
            </div>
            <asp:Button runat="server" class="w-100 btn btn-lg btn-primary" type="submit" Text="Iniciar Sesion"></asp:Button>
            <p class="mt-5 mb-3 text-muted">&copy;2021</p>
        </form>
    </main>
</asp:Content>

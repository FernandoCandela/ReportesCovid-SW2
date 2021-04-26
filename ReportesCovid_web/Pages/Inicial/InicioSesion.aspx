<%@ Page Language="C#" MasterPageFile="~/MasterPages/Inicial.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="ReportesCovid_web.Pages.Inicial.InicioSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main class="form-signin">
            <asp:Image ID="Image1" runat="server" CssClass="mb-4 float-md-end" ImageUrl="~/img/person.svg" Width="90%" Height="90%"/>
            <h1 class="h3 mb-3 fw-normal">Inicio de Sesion</h1>

            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ClientIDMode="Static" type="text" id="username" placeholder="Ingresa tu username"/>
                <label for="floatingInput">Username</label>
            </div>
            <div class="form-floating">
                <asp:TextBox runat="server" CssClass="form-control" ClientIDMode="Static" type="password" id="password" placeholder="Ingresa tu contraseña" />
                <label for="floatingPassword">Password</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me">
                    Remember me
                </label>
            </div>
            <asp:Button runat="server" ID="btnLogin" class="w-100 btn btn-lg btn-primary" OnClick="LoguearUsuario" Text="Iniciar Sesion"></asp:Button>
            <p class="mt-5 mb-3 text-muted">&copy;2021</p>
    </main>
</asp:Content>

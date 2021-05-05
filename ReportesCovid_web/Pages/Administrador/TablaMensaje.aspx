<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="TablaMensaje.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.TablaMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="text-center mt-4 mb-4">
        <h1 class="display-5 fw-bold">Mensajes</h1>
    </div>

    <div class="navbar container-fluid mx-5">
            <input class="form-control container-fluid" type="search" placeholder="Buscar" aria-label="Buscar">
            <asp:Button runat="server" class="btn btn-success mt-3" type="submit" Text="Buscar"></asp:Button>
    </div>

    <div class="foto mt-4">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-fluid img-thumbnail">
    </div>

    <h2>Mensajes</h2>
    <div class="table-responsive mx-5">
        <table class="table table-striped table-sm table-primary">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Correo</th>
                    <th>Asunto</th>
                    <th>#</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1,001</td>
                    <td>random</td>
                    <td>data</td>
                    <td>placeholder</td>
                    <td>text</td>
                </tr>
                <tr>
                    <td>1,002</td>
                    <td>placeholder</td>
                    <td>irrelevant</td>
                    <td>visual</td>
                    <td>layout</td>
                </tr>
                <tr>
                    <td>1,003</td>
                    <td>data</td>
                    <td>rich</td>
                    <td>dashboard</td>
                    <td>tabular</td>
                </tr>
                <tr>
                    <td>1,003</td>
                    <td>information</td>
                    <td>placeholder</td>
                    <td>illustrative</td>
                    <td>data</td>
                </tr>
                <tr>
                    <td>1,004</td>
                    <td>text</td>
                    <td>random</td>
                    <td>layout</td>
                    <td>dashboard</td>
                </tr>
                <tr>
                    <td>1,005</td>
                    <td>dashboard</td>
                    <td>irrelevant</td>
                    <td>text</td>
                    <td>placeholder</td>
                </tr>
                <tr>
                    <td>1,006</td>
                    <td>dashboard</td>
                    <td>illustrative</td>
                    <td>rich</td>
                    <td>data</td>
                </tr>
                <tr>
                    <td>1,007</td>
                    <td>placeholder</td>
                    <td>tabular</td>
                    <td>information</td>
                    <td>irrelevant</td>
                </tr>
                <tr>
                    <td>1,008</td>
                    <td>random</td>
                    <td>data</td>
                    <td>placeholder</td>
                    <td>text</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
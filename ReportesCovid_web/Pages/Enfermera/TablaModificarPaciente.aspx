<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="TablaModificarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.TablaModificarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="text-center">
        <h1 class="display-5 fw-bold">LISTA DE PACIENTES</h1>
    </div>

    <div class="navbar container-fluid mx-5">
        <div class="d-flex">
            <input class="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar">
            <asp:Button runat="server" class="btn btn-outline-success" type="submit" Text="Buscar"></asp:Button>
        </div>
    </div>

    <div class="foto">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-fluid img-thumbnail">
    </div>

    <h2>Cuentas</h2>
    <div class="table-responsive mx-5">
        <table class="table table-striped table-sm table-primary">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Tipo de usuario</th>
                    <th>DNI</th>
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
            </tbody>
        </table>
    </div>
</asp:Content>

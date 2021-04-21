<%@ Page Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="TablaUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.TablaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
        <h1 class="display-5 fw-bold">MODIFICAR CUENTA</h1>
    </div>

    <div class="navbar container-fluid mx-5">
        <form class="d-flex">
            <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
            <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
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
                <tr>
                    <td>1,006</td>
                    <td>dashboard</td>
                    <td>illustrative</td>
                    <td>rich</td>
                    <td>data</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>

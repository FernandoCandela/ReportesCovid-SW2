<%@ Page Language="C#" MasterPageFile="~/MasterPages/Medico.Master" AutoEventWireup="true" CodeBehind="BuscarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.BuscarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main class="form-signin">
            <div class="form-floating mb-4">
                <input type="text" class="form-control" id="floatingInput" placeholder="12345678">
                <label for="floatingInput">DNI</label>
            </div>
            <div class="form-floating mb-4">
                <input type="text" class="form-control" id="floatingPaciente" placeholder="paciente">
                <label for="floatingPaciente">Paciente</label>
            </div>

            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Nombre</th>
                        <th scope="col">Apellido</th>
                        <th scope="col">DNI</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                    </tr>
                    <tr>
                        <th scope="row">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
                        <td>@fat</td>
                    </tr>
                </tbody>
            </table>

            <div class="card-body p-5">
                <asp:Button runat="server" class="w-100 btn btn-lg btn-primary mb-3" type="submit" Text="Seleccionar"></asp:Button>
                <asp:Button runat="server" class="w-100 btn-sm btn btn-lg btn-outline-secondary fs-6" text="Atras"></asp:Button>
            </div>
            <p class="mt-5 mb-3 text-center">&copy;2021</p>
    </main>

</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.RegistrarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container m-auto mt-4 shadow p-3 mb-5 bg-body rounded">
        <main>
            <div>
                <h4 class="mb-3">Nuevo Paciente</h4>
                <div>
                    <div class="row g-3 my-4">
                        <div class="col-sm-6">
                            <label for="firstName" class="form-label">Nombres</label>
                            <input type="text" class="form-control" id="firstName" required>
                            <div class="invalid-feedback">
                                Valid first name is required.
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <label for="lastName" class="form-label">Apellidos</label>
                            <input type="text" class="form-control" id="lastName" required>
                            <div class="invalid-feedback">
                                Valid last name is required.
                            </div>
                        </div>

                        <%--  --%>
                        <div class="col-sm-6">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Text="DNI"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <%--  --%>

                        <div class="col-6">
                            <label for="dni" class="form-label">DNI</label>
                            <input type="text" class="form-control" id="dni" required>
                            <div class="invalid-feedback">
                                Please enter your DNI.
                            </div>
                        </div>

                        <%--  --%>
                        <div class="col-sm-6">
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Text="Tipo de seguro"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-sm-6">
                            <asp:DropDownList ID="DropDownList3" runat="server">
                                <asp:ListItem Text="Estado de paciente"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <%--  --%>

                        <div class="col-6">
                            <label for="emailResponsable" class="form-label">Correo de Responsable</label>
                            <input type="email" class="form-control" id="emailResponsable" placeholder="you@example.com" required>
                            <div class="invalid-feedback">
                                Please enter a valid email address.
                            </div>
                        </div>

                        <div class="col-6">
                            <label for="telefonoResponsable" class="form-label">Telefono de Responsable </label>
                            <input type="text" class="form-control" id="telefonoResponsable" required>
                        </div>

                        <div class="col-sm-6">
                            <label for="firstName" class="form-label">Nombre y Apellido de Responsable</label>
                            <input type="text" class="form-control" id="name" required>
                            <div class="invalid-feedback">
                                Valid first name is required.
                            </div>
                        </div>

                        <div class="card-body m-5 position-relative">
                            <asp:Button runat="server" class=" w-50 btn btn-primary mb-2 position-absolute top-100 start-50 translate-middle" type="submit" Text="Crear Paciente y Enviar Credencial"></asp:Button>
                            <%--<asp:Button runat="server" class="w-50 btn btn-secondary my-5 position-absolute top-100 start-50 translate-middle" type="submit" Text="Cargar CSV"></asp:Button>--%>
                        </div>
                    </div>
                </div>
            </div>

        </main>
    </div>
</asp:Content>

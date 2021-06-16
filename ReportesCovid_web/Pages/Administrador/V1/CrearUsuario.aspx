<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="foto mt-4">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-thumbnail d-block">
    </div>

    <div class="container">
        <main>
            <!-- <div class="col-md-7 col-lg-8"> -->
            <div>
                <h4 class="mb-3">Nuevo Usuario</h4>
                <div class="row g-3 my-4">

                    <div class="col-sm-6">
                        <label for="firstName" class="form-label">Primer nombre</label>
                        <%--<input type="text" class="form-control" id="firstName1">--%>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="firstName1" />
                        <div class="invalid-feedback">
                            Valid first name is required.
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <label for="firstName" class="form-label">Segundo nombre</label>
                        <%--<input type="text" class="form-control" id="firstName2">--%>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="firstName2" />
                        <div class="invalid-feedback">
                            Valid first name is required.
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <label for="lastName" class="form-label">Apellido Paterno</label>
                        <%--<input type="text" class="form-control" id="lastName1" required>--%>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="lastName1"/>
                        <div class="invalid-feedback">
                            Valid last name is required.
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <label for="lastName" class="form-label">Apellido Materno</label>
                        <%--<input type="text" class="form-control" id="lastName2" required>--%>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="lastName2"/>
                        <div class="invalid-feedback">
                            Valid last name is required.
                        </div>
                    </div>

                    <div class="col-12">
                        <label for="dni" class="form-label">DNI</label>
                        <%--<input type="text" class="form-control" id="dni" placeholder="12345678" required>--%>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="dni"/>
                        <div class="invalid-feedback">
                            Please enter your DNI.
                        </div>
                    </div>

<%--                    <div class="col-12">
                        <label for="email" class="form-label">Correo </label>
                        <input type="email" class="form-control" id="email" placeholder="you@example.com">
                        <div class="invalid-feedback">
                            Please enter a valid email address.
                        </div>
                    </div>--%>

                    <div class="col-12 form-floating">
                        <label for="email" class="form-label">Telefono </label>
                        <asp:TextBox runat="server" type="text" CssClass="form-control" ID="telefono" placeholder="telefono"/>
                    </div>

                    <%-- añadido drop --%>
                    <div class="col-md-5">
                        <label for="usuario" class="form-label">Rol</label>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select-sm">
                            <asp:ListItem Text="Administrador" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Enfermera" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Medico" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-5">
                        <label for="usuario" class="form-label">Cargo</label>
                        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-select-sm">
                            <asp:ListItem Text="Cargo1" ></asp:ListItem>
                            <asp:ListItem Text="Cargo2" ></asp:ListItem>
                            <asp:ListItem Text="Cargo3" ></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <%--  --%>

                </div>
                <asp:Button runat="server" class="w-50 btn btn-primary btn-lg" type="submit" Text="Crear Usuario"></asp:Button>
            </div>

        </main>
        <!-- colocar en el master page -->
        <footer class="my-5 pt-5 text-muted text-center text-small">
            <p class="mb-1">&copy; 2021 ESSALUD</p>
        </footer>
    </div>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/MasterPages/Admin.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="foto">
        <img src="/img/paciente.svg" class="d-block mx-auto mb-4">
    </div>

    <div class="container">
        <main>
            <!-- <div class="col-md-7 col-lg-8"> -->
            <div>
                <h4 class="mb-3">Nuevo Usuario</h4>
                <form class="needs-validation" novalidate>
                    <div class="row g-3 my-4">
                        <div class="col-sm-6">
                            <label for="firstName" class="form-label">Nombres</label>
                            <input type="text" class="form-control" id="firstName" placeholder="" value="" required>
                            <div class="invalid-feedback">
                                Valid first name is required.
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <label for="lastName" class="form-label">Apellidos</label>
                            <input type="text" class="form-control" id="lastName" placeholder="" value="" required>
                            <div class="invalid-feedback">
                                Valid last name is required.
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="dni" class="form-label">DNI</label>
                            <input type="text" class="form-control" id="dni" placeholder="12345678" required>
                            <div class="invalid-feedback">
                                Please enter your DNI.
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="email" class="form-label">Correo </label>
                            <input type="email" class="form-control" id="email" placeholder="you@example.com">
                            <div class="invalid-feedback">
                                Please enter a valid email address.
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="telefo" class="form-label">Telefono </label>
                            <input type="text" class="form-control" id="telefono" placeholder="123456789">
                        </div>

                        <div class="col-md-5">
                            <label for="usuario" class="form-label">Usuario</label>
                            <select class="form-select" id="usuario" required>
                                <option value="">Escoge...</option>
                                <option>Medico</option>
                                <option>Enfermero</option>
                            </select>
                            <div class="invalid-feedback">
                                Please select a valid user.
                            </div>
                        </div>
                    </div>
                    <asp:Button runat="server" class="w-50 btn btn-primary btn-lg" type="submit" Text="Crear Usuario"></asp:Button>
                </form>
            </div>

        </main>
        <!-- colocar en el master page -->
        <footer class="my-5 pt-5 text-muted text-center text-small">
            <p class="mb-1">&copy; 2021 ESSALUD</p>
        </footer>
    </div>

</asp:Content>

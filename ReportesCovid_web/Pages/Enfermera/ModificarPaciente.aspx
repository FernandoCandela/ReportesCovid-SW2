<%@ Page Language="C#" MasterPageFile="~/MasterPages/Enfermera.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.ModificarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container m-auto mt-4 shadow p-3 mb-5 bg-body rounded">
        <main>
            <div>
                <h4 class="mb-3">Modificando Paciente</h4>
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

                        <div class="col-6">
                            <label for="dni" class="form-label">DNI</label>
                            <input type="text" class="form-control" id="dni" placeholder="12345678" required>
                            <div class="invalid-feedback">
                                Please enter your DNI.
                            </div>
                        </div>

                        <div class="col-6">
                            <label for="emailResponsable" class="form-label">Correo de Responsable</label>
                            <input type="email" class="form-control" id="emailResponsable" placeholder="you@example.com" required>
                            <div class="invalid-feedback">
                                Please enter a valid email address.
                            </div>
                        </div>

                        <div class="col-6">
                            <label for="telefonoResponsable" class="form-label">Telefono de Responsable </label>
                            <input type="text" class="form-control" id="telefonoResponsable" placeholder="123456789" required>
                        </div>

                        <div class="col-sm-6">
                            <label for="firstName" class="form-label">Nombre y Apellido de Responsable</label>
                            <input type="text" class="form-control" id="firstNameR" required>
                            <div class="invalid-feedback">
                                Valid first name is required.
                            </div>
                        </div>
                    </div>

                    <div class="col-12 position-relative">
                        <asp:Button runat="server" type="submit" class="btn btn-primary w-25 mb-4" Text="Guardar Cambios"></asp:Button>
                        <asp:Button runat="server" type="submit" class="btn btn-danger w-25 mb-4 position-absolute bottom-0 end-0" Text="Dar de alta"></asp:Button>
                    </div>

                </div>
            </div>

        </main>

    </div>
</asp:Content>

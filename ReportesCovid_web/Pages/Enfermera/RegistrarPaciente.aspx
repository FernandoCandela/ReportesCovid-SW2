<%@ Page Language="C#" MasterPageFile="~/MasterPages/Enfermera.Master" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.RegistrarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container m-auto mt-4 shadow p-3 mb-5 bg-body rounded">
        <main>
            <div>
                <h4 class="mb-3">Nuevo Usuario</h4>
                <form class="needs-validation" novalidate>
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
                            <input type="number" class="form-control" id="dni" required>
                            <div class="invalid-feedback">
                                Please enter your DNI.
                            </div>
                        </div>

                        <div class="col-6">
                            <label for="emailResponsable" class="form-label">Correo de Responsable</label>
                            <input type="email" class="form-control" id="emailResponsable" placeholder="you@example.com">
                            <div class="invalid-feedback">
                                Please enter a valid email address.
                            </div>
                        </div>

                        <div class="col-6">
                            <label for="telefonoResponsable" class="form-label">Telefono de Responsable </label>
                            <input type="number" class="form-control" id="telefonoResponsable">
                        </div>

                        <div class="col-sm-6">
                            <label for="firstName" class="form-label">Nombre y Apellido de Responsable</label>
                            <input type="text" class="form-control" id="name" required>
                            <div class="invalid-feedback">
                                Valid first name is required.
                            </div>
                        </div>
                    </div>
                    <div class="card-body p-5 position-relative">
                        <button class=" w-50 btn btn-primary mb-2 position-absolute top-100 start-50 translate-middle" type="submit ">Crear Paciente y Enviar Credencial</button>
                        <button class="w-50 btn btn-secondary my-5 position-absolute top-100 start-50 translate-middle" type="submit ">Cargar CSV</button>
                    </div>
                </form>
            </div>

        </main>
    </div>
</asp:Content>

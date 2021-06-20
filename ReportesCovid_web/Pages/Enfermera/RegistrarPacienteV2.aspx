<%@ Page Title="Essalud - Nuevo" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="RegistrarPacienteV2.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.RegistrarPacienteV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Nuevo Paciente</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="app-content content">
        <div class="content-overlay"></div>
        <div class="content-wrapper">
            <div class="content-header row">
            </div>
            <div class="content-body">
                <!-- users edit start -->
                <section class="users-edit">
                    <div class="card">
                        <div class="card-body">
                            <ul class="nav nav-tabs mb-2" id="MyTab" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link d-flex align-items-center active" id="paciente-tab" data-toggle="tab" href="#paciente" aria-controls="paciente" role="tab" aria-selected="true">
                                        <i class="bx bx-highlight mr-25"></i><span class="d-none d-sm-block">Datos de Paciente</span>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link d-flex align-items-center" id="contacto-tab" data-toggle="tab" href="#contacto" aria-controls="contacto" role="tab" aria-selected="false">
                                        <i class="bx bxs-contact  mr-25"></i><span class="d-none d-sm-block">Datos de Contacto</span>
                                    </a>
                                </li>
                            </ul>

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-6">
                                            <label for="txtNombres" class="form-label">Nombres</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNombres" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="tApellidos" class="form-label">Apellidos</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtApellidos" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="ddlTipoDocumento" class="form-label">Tipo Documento</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoDocumento" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de documento valido.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtNumdoc" class="form-label">Número de Documento</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNumdoc" onkeypress="return solonumerosydecimales(event);" name="tDoc" MaxLength="10" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="ddlTipoSeguro" class="form-label">Tipo Seguro</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoSeguro" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de seguro valido.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="ddlEstadoPaciente" class="form-label">Estado Paciente</label>
                                            <asp:DropDownList runat="server" ID="ddlEstadoPaciente" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Estado de paciente valido.
                                            </div>
                                        </div>

                                    </div>
                                </div>
                                <div class="tab-pane fade show" id="contacto" aria-labelledby="contacto-tab" role="tabpanel">
                                    <div class="row g-3 my-4">

                                        <div class="col-md-6">
                                            <label for="ddlTipoDocumento" class="form-label">Tipo Documento</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoDocContacto" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de documento valido.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtNumdoc" class="form-label">Número de Documento</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNumDocContacto" onkeypress="return solonumerosydecimales(event);" name="tNumDocContacto" MaxLength="10" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>


                                        <div class="col-md-6">
                                            <label for="txtTelefonoResponsable" class="form-label">Nombres y Apellidos</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNombreApellidoContacto" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtCorreo" class="form-label">Correo</label>
                                            <div class="input-group has-validation">
                                                <span class="input-group-text" id="inputGroupPrepend">@</span>
                                                <asp:TextBox type="email" CssClass="form-control" ID="txtCorreoContacto" runat="server" aria-describedby="inputGroupPrepend" required="true"></asp:TextBox>
                                                <div class="invalid-feedback">
                                                    Debe ingresar un correo valido.
                                                </div>
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtTelefonoResponsable" class="form-label">Telefono</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtTelefonoContacto" onkeypress="return solonumerosydecimales(event);" runat="server" required="true" MaxLength="9"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">

                                    <asp:Button runat="server" ID="btnRegistrarPaciente" CssClass="btn btn-primary glow" Text="Registrar Paciente" OnClick="btnRegistrarPaciente_Click"></asp:Button>
                                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow" NavigateUrl="/enfermera/paciente/lista" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>

                                </div>

                            </div>
                        </div>
                    </div>
                </section>
                <!-- users edit ends -->

            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Foot" runat="server">
    <script>
        (function () {
            'use strict'

            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.querySelectorAll('.needs-validation')

            // Loop over them and prevent submission
            Array.prototype.slice.call(forms)
                .forEach(function (form) {
                    form.addEventListener('submit', function (event) {
                        if (!form.checkValidity()) {
                            event.preventDefault()
                            event.stopPropagation()
                        }

                        form.classList.add('was-validated')
                    }, false)
                })
        })()

        jQuery(function () {
            jQuery('#MyTab a').on('click', function () {
                $(this).tab('show');
            });
        })

    </script>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.RegistrarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container m-auto mt-4 shadow p-3 mb-5 bg-body rounded">

        <h4 class="mb-3">Nuevo Paciente</h4>

        <ul class="nav nav-tabs mb-2" id="MyTab" role="tablist">
            <li class="nav-item">
                <a class="nav-link d-flex align-items-center active" id="paciente-tab" data-toggle="tab" href="#paciente" aria-controls="paciente" role="tab" aria-selected="true">
                    <i class="bx bx-shopping-bag mr-25"></i><span class="d-none d-sm-block">Datos de Paciente</span>
                </a>
            </li>
            <li class="nav-item">
                <a class="nav-link d-flex align-items-center" id="contacto-tab" data-toggle="tab" href="#contacto" aria-controls="contacto" role="tab" aria-selected="false">
                    <i class="bx bx-user mr-25"></i><span class="d-none d-sm-block">Datos de Contacto</span>
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
                        <asp:TextBox type="text" class="form-control" ID="txtNumdoc" onkeypress="return solonumerosydecimales(event);" name="tDoc" runat="server" required="true"></asp:TextBox>
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
                        <asp:DropDownList runat="server" ID="DropDownList1" class="form-select" required="true">
                        </asp:DropDownList>
                        <div class="invalid-feedback">
                            Debe seleccionar un Tipo de documento valido.
                        </div>
                    </div>

                    <div class="col-md-6">
                        <label for="txtNumdoc" class="form-label">Número de Documento</label>
                        <asp:TextBox type="text" class="form-control" ID="TextBox1" onkeypress="return solonumerosydecimales(event);" name="tDoc" runat="server" required="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este cambo.
                        </div>
                    </div>
                    

                    <div class="col-md-6">
                        <label for="txtTelefonoResponsable" class="form-label">Nombre y Apellido de Responsable</label>
                        <asp:TextBox type="text" class="form-control" ID="txtNombreApellidoResposable" runat="server" required="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este cambo.
                        </div>
                    </div>

                    <div class="col-md-6">
                        <label for="txtCorreo" class="form-label">Correo</label>
                        <div class="input-group has-validation">
                            <span class="input-group-text" id="inputGroupPrepend">@</span>
                            <asp:TextBox type="email" CssClass="form-control" ID="txtCorreo" runat="server" aria-describedby="inputGroupPrepend" required="true"></asp:TextBox>
                            <div class="invalid-feedback">
                                Debe ingresar un correo valido.
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <label for="txtTelefonoResponsable" class="form-label">Telefono de Responsable</label>
                        <asp:TextBox type="text" class="form-control" ID="txtTelefonoResponsable" onkeypress="return solonumerosydecimales(event);" runat="server" required="true" MaxLength="9"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este cambo.
                        </div>
                    </div>

                </div>


            </div>
            <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">

                <asp:Button runat="server" ID="btnRegistrarPaciente" CssClass="btn btn-primary" Text="Registrar Paciente" OnClick="btnRegistrarPaciente_Click"></asp:Button>
            </div>


        </div>
    </div>

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

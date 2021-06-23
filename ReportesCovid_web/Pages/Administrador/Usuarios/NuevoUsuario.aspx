<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.Usuarios.NuevoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Nuevo Usuario</h3>
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
                                        <i class="bx bx-user mr-25"></i><span class="d-none d-sm-block">Datos de Usuario</span>
                                    </a>
                                </li>
                            </ul>

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-6">
                                            <label for="txtPrimerNombre" class="form-label">Primer Nombre</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtPrimerNombre" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="txtSegundoNombre" class="form-label">Segundo Nombre</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtSegundoNombre" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="txtApellidoPaterno" class="form-label">Apellido Paterno</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtApellidoPaterno" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="txtApellidoMaterno" class="form-label">Apellido Materno</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtApellidoMaterno" runat="server" required="true"></asp:TextBox>
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
                                            <label for="tUsuario" class="form-label">Usuario</label>
                                            <div class="input-group mb-3">
                                                <%--<button class="btn btn-outline-primary" type="button" id="button-addon1">Generar Usuario</button>--%>
                                                <asp:TextBox type="text" class="form-control" ID="tUsuario" runat="server" required="true"></asp:TextBox>
                                                <div class="invalid-feedback">
                                                    Debe llenar este cambo.
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="tContrasena" class="form-label">Contraseña</label>
                                            <asp:TextBox type="password" class="form-control" ID="tContrasena" runat="server" required="true"></asp:TextBox>
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
                                            <label for="txtTelefono" class="form-label">Telefono</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtTelefono" onkeypress="return solonumerosydecimales(event);" name="tTelefono" MaxLength="9" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="ddlRol" class="form-label">Rol</label>
                                            <asp:DropDownList runat="server" ID="ddlRol" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Rol valido.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="ddlCargo" class="form-label">Cargo</label>
                                            <asp:DropDownList runat="server" ID="ddlCargo" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Cargo valido.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="ddlEstado" class="form-label">Estado</label>
                                            <asp:DropDownList runat="server" ID="ddlEstado" class="form-select">
                                                <asp:ListItem Text="Activo" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Desactivado" Value="0"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>

                                    </div>
                                </div>
                                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">

                                    <asp:Button runat="server" ID="btnRegistrar" CssClass="btn btn-primary glow" Text="Registrar" OnClick="btnRegistrar_Click"></asp:Button>
                                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow" NavigateUrl="/administrador/usuario/lista" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>
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
    <%-- <script type="text/javascript">
        function mostrarPassword() {
            var cambio = document.getElementById("txtPassword");
            if (cambio.type == "password") {
                cambio.type = "text";
                $('.icon').removeClass('fa fa-eye-slash').addClass('fa fa-eye');
            } else {
                cambio.type = "password";
                $('.icon').removeClass('fa fa-eye').addClass('fa fa-eye-slash');
            }
        }

        $(document).ready(function () {
            //CheckBox mostrar contraseña
            $('#ShowPassword').click(function () {
                $('#Password').attr('type', $(this).is(':checked') ? 'text' : 'password');
            });
        });
    </script>--%>
</asp:Content>

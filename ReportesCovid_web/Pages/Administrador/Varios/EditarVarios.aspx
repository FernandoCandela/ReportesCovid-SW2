<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="EditarVarios.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.Varios.EditarVarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Editar Varios</h3>
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
                                        <i class="bx bx-user mr-25"></i><span class="d-none d-sm-block">Datos de Varios</span>
                                    </a>
                                </li>
                            </ul>

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-6">
                                            <label for="txtDescripcion" class="form-label">Descripcion</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtDescripcion" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="ddlTiposVarios" class="form-label">Tipo Atributo</label>
                                            <asp:DropDownList runat="server" ID="ddlTiposVarios" class="form-select" required="true">
                                                <asp:ListItem Text="[Seleccionar]" disabled="disabled" Selected="True"></asp:ListItem>
                                                <asp:ListItem Text="Estados de Paciente" Value="IN_EstadoPaciente"></asp:ListItem>
                                                <asp:ListItem Text="Roles" Value="IN_Rol"></asp:ListItem>
                                                <asp:ListItem Text="Tipos de Documento" Value="IN_Tipodoc"></asp:ListItem>
                                                <asp:ListItem Text="Tipos de Mensajes" Value="IN_TipoMensaje"></asp:ListItem>
                                                <asp:ListItem Text="Cargos" Value="IN_Cargo"></asp:ListItem>
                                                <asp:ListItem Text="Tipos de Seguro" Value="IN_TipoSeguro"></asp:ListItem>
                                                <asp:ListItem Text="Tipos de Traslado" Value="IN_TipoTraslado"></asp:ListItem>
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de Atributo valido.
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

                                    <asp:Button runat="server" ID="btnActualizar" CssClass="btn btn-primary glow" Text="Actualizar" OnClick="btnActualizar_Click"></asp:Button>
                                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow" NavigateUrl="/administrador/varios/lista" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>
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

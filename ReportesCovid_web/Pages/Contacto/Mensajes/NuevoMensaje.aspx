<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Contacto.Master" AutoEventWireup="true" CodeBehind="NuevoMensaje.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.Mensajes.NuevoMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Nuevo Mensaje</h3>
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
                                        <i class="bx bx-message-detail  mr-25"></i><span class="d-none d-sm-block">Datos de Mensaje</span>
                                    </a>
                                </li>
                            </ul>

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-12">
                                            <label for="txtAsunto" class="form-label">Asunto</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtAsunto" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                        <div class="col-md-12">
                                            <label for="ddlTipoMensaje" class="form-label">Tipo de Mensaje</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoMensaje" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un tipo de mensaje valido.
                                            </div>
                                        </div>

                                        <div class="col-md-12">
                                            <label for="txtMensaje" class="form-label">Mensaje</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="txtMensaje" Style="height: 120px" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">

                                    <asp:Button runat="server" ID="btnRegistrar" CssClass="btn btn-primary glow" Text="Enviar" OnClick="btnRegistrar_Click"></asp:Button>
                                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow" NavigateUrl="/contacto/mensaje/lista" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>
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

<%@ Page Title="Restaurar" Language="C#" MasterPageFile="~/MasterPages/Inicial.Master" AutoEventWireup="true" CodeBehind="RecuperarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.RestaurarCredencial" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
</asp:Content>--%>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="app-content content m-lg-5">
        <h1 class="text-center">Restaurar Credencial</h1>
        <div class="content-overlay m-4"></div>
        <div class="content-wrapper">
            <div class="content-header row">
            </div>
            <div class="content-body">
                <!-- users edit start -->
                <section class="users-edit">
                    <div class="card">
                        <div class="card-body">

                            <div class="tab-content" id="contentTab">
                                <div class="active fade show" id="paciente" aria-labelledby="paciente-tab">
                                    <div class="row g-3 my-4">

                                        <div class="col-md-6">
                                            <label for="ddlTipoDocumento" class="form-label">Tipo Documento de Paciente</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoDocumento" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de documento valido.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtNumdoc" class="form-label">Número de Documento de Paciente</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNumdoc" onkeypress="return solonumerosydecimales(event);" name="tDoc" MaxLength="10" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>



                                    </div>
                                </div>

                                <hr style="height:2px; border-width:0; color:red; background-color:gray"/>

                                <div class="ade show" id="contacto" aria-labelledby="contacto-tab">
                                    <div class="row g-3 my-4">

                                        <div class="col-md-6">
                                            <label for="ddlTipoDocumento" class="form-label">Tipo Documento de Contacto</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoDocContacto" class="form-select" required="true">
                                            </asp:DropDownList>
                                            <div class="invalid-feedback">
                                                Debe seleccionar un Tipo de documento valido.
                                            </div>
                                        </div>

                                        <div class="col-md-6">
                                            <label for="txtNumdoc" class="form-label">Número de Documento de Contacto</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtNumDocContacto" onkeypress="return solonumerosydecimales(event);" name="tNumDocContacto" MaxLength="10" runat="server" required="true"></asp:TextBox>
                                            <div class="invalid-feedback">
                                                Debe llenar este cambo.
                                            </div>
                                        </div>


                                        <div class="col-md-6">
                                            <label for="txtCorreo" class="form-label">Correo de Contacto</label>
                                            <div class="input-group has-validation">
                                                <span class="input-group-text" id="inputGroupPrepend">@</span>
                                                <asp:TextBox type="email" CssClass="form-control" ID="txtCorreoContacto" runat="server" aria-describedby="inputGroupPrepend" required="true"></asp:TextBox>
                                                <div class="invalid-feedback">
                                                    Debe ingresar un correo valido.
                                                </div>
                                            </div>
                                        </div>

                                    </div>

                                </div>
                                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">

                                    <%--<asp:Button runat="server" ID="btnRegistrarPaciente" CssClass="btn btn-primary glow" Text="Registrar Paciente" OnClick="btnRegistrarPaciente_Click"></asp:Button>--%>
                                    <asp:Button runat="server" ID="btnRestaurar" CssClass="btn btn-primary glow" Text="Restaurar" ></asp:Button>
                                </div>

                                <%-- FALTA FUNCIONAMIENTO DE BOTON --%>

                            </div>
                        </div>
                    </div>
                </section>
                <!-- users edit ends -->

            </div>
        </div>
    </div>
</asp:Content>

<%--<asp:Content ID="Content4" ContentPlaceHolderID="Foot" runat="server">
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
</asp:Content>--%>

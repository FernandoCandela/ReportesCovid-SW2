﻿<%@ Page Title="Essalud - Generar Reporte" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="GenerarReporte.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.GenerarReporte1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>REPORTE DE PACIENTE</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="app-content content">
        <div class="content-overlay"></div>
        <div class="content-wrapper">
            <div class="content-header row">
            </div>
            <div class="content-body">
                <section class="users-list-wrapper">
                    <div class="users-list-filter px-1">
                        <div class="container border rounded">
                            <div class="row py-2">
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="txtNombres" class="form-label">Nombres</label>
                                    <asp:TextBox type="text" class="form-control" ID="txtNombres" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="tApellidos" class="form-label">Apellidos</label>
                                    <asp:TextBox type="text" class="form-control" ID="txtApellidos" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="txtNumdoc" class="form-label">Número de Documento</label>
                                    <asp:TextBox type="text" class="form-control" ID="txtNumdoc" name="tDoc" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="txtDoctor" class="form-label">Medico</label>
                                    <asp:TextBox type="text" class="form-control" ID="txtMedico" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>

                            </div>
                            <div class="row mb-2">
                            </div>
                        </div>
                    </div>
                    <br />

                    <div class="users-list-table">
                        <div class="card">
                            <div class="card-body">

                                <div class="row ">
                                    <div class="col-12 col-sm-4 col-lg-4 mx-auto">
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtTemperatura" class="form-label">Temperatura <i class="fas fa-temperature-high"></i></label>
                                            <div class="input-group">
                                                <asp:TextBox type="text" class="form-control" ID="txtTemperatura" onkeypress="return solonumerosydecimales(event);" runat="server" required="true"></asp:TextBox>
                                                <span class="input-group-text" style="font-size: 1rem">°C</span>
                                            </div>
                                            <div class="invalid-feedback">
                                                Temperatura es obligatoria.
                                            </div>
                                        </div>
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtFrecuencia" class="form-label">Frecuencia cardiaca <i class="fas fa-heartbeat"></i></label>
                                            <div class="input-group">
                                                <asp:TextBox type="text" class="form-control" ID="txtFrecuencia" onkeypress="return solonumerosydecimales(event);" runat="server" required="true"></asp:TextBox>
                                                <span class="input-group-text" style="font-size: 1rem">Lat/min</span>
                                            </div>
                                            <div class="invalid-feedback">
                                                Frecuencia es obligatoria.
                                            </div>
                                        </div>
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtPresion" class="form-label">Presión arterial <i class="fas fa-stethoscope"></i></label>
                                            <div class="input-group">
                                                <asp:TextBox type="text" class="form-control" ID="txtPresion" onkeypress="return solonumerosydecimales(event);" runat="server" required="true"></asp:TextBox>
                                                <span class="input-group-text" style="font-size: 1rem">mmHg</span>
                                            </div>
                                            <div class="invalid-feedback">
                                                Presion es obligatoria.
                                            </div>
                                        </div>
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtSaturacion" class="form-label">Saturación de oxigeno <i class="fas fa-head-side-mask"></i></label>
                                            <div class="input-group">
                                                <asp:TextBox type="text" class="form-control" ID="txtSaturacion" onkeypress="return solonumerosydecimales(event);" runat="server" required="true"></asp:TextBox>
                                                <span class="input-group-text" style="font-size: 1rem">%SpO2</span>
                                            </div>
                                            <div class="invalid-feedback">
                                                Saturacion es obligatoria.
                                            </div>
                                        </div>

                                    </div>
                                    <div class="col-12 col-sm-4 col-lg-4">
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtPronostico" class="form-label">Pronóstico</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtPronostico" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                                        </div>
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtRequerimiento" class="form-label">Requerimiento de medicamentos / cuidado</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtRequerimiento" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                                        </div>
                                        <div class="col-sm-12 mb-4">
                                            <label for="txtEvolucion" class="form-label">Evolucion de Paciente</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtEvolucion" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-12 col-sm-4 col-lg-4">
                                        <div class="col-sm-12 mb-4">
                                            <div class="form-check form-switch">
                                                <input class="form-check-input" runat="server" clientidmode="Static" type="checkbox" id="cbTraslado">
                                                <label class="form-check-label" for="cbTraslado">Requiere traslado</label>
                                            </div>
                                        </div>

                                        <div class=" col-sm-12 mb-4 shadow-sm p-3 border">
                                            <div class="container">
                                                <div class="col-sm-12 mb-4">
                                                    <label for="txtFechaTraslado" class="form-label">Fecha de traslado</label>
                                                    <asp:TextBox type="text" TextMode="Date" class="form-control" ID="txtFechaTraslado" runat="server" disabled="true"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-12 mb-4">
                                                    <label for="ddlTipoTraslado" class="form-label">Tipo Traslado</label>
                                                    <asp:DropDownList runat="server" ID="ddlTipoTraslado" class="form-select" disabled="true">
                                                    </asp:DropDownList>
                                                    <div class="invalid-feedback">
                                                        Debe seleccionar un Tipo de documento valido.
                                                    </div>
                                                </div>

                                                <div class="col-sm-12 mb-4">
                                                    <label for="txtComentario" class="form-label">Detalles</label>
                                                    <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="txtComentario" Style="height: 80px" runat="server" ToolTip="Escriba aquí..." disabled="true"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">
                                            <asp:Button ID="btnRegistrar" CssClass="btn btn-primary glow mb-1 mb-sm-0 mr-0 mr-sm-1" Style="margin-left: 5px" runat="server" Text="Guardar" OnClick="btnRegistrar_Click"></asp:Button>
                                            <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow mb-1 mb-sm-0 mr-0 mr-sm-1" NavigateUrl="/medico/paciente/lista" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <!-- users list ends -->

                <br />
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Foot" runat="server">
    <script src="<%= ResolveClientUrl("~/js/Medico/jsReporte.js?1") %>"></script>
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

    </script>
</asp:Content>

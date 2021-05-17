﻿<%@ Page Language="C#" MasterPageFile="~/MasterPages/Contacto.Master" AutoEventWireup="true" CodeBehind="VisualizarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.VisualizarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="px-4 pt-5 text-center">
        <h1 class="display-5 fw-bold m-4">REPORTE DE MEDICO</h1>
    </div>
    <div class="container mw-100 m-2 col-10 shadow p-3 mb-1 bg-body rounded m-auto">
        <div class="row py-2">
            <div class="col-12 col-sm-6 mb-2 col-lg-3">
                <label for="txtNombres" class="form-label">Nombres de Paciente</label>
                <asp:TextBox type="text" class="form-control" ID="txtNombres" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-6 mb-2 col-lg-3">
                <label for="tApellidos" class="form-label">Apellidos de Paciente</label>
                <asp:TextBox type="text" class="form-control" ID="txtApellidos" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-6 mb-2 col-lg-3">
                <label for="txtNumdoc" class="form-label">Número de Documento</label>
                <asp:TextBox type="text" class="form-control" ID="txtNumdoc" name="tDoc" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-6 mb-2 col-lg-3">
                <label for="txtEstadoPaciente" class="form-label">Estado Paciente</label>
                <asp:TextBox type="text" class="form-control" ID="txtEstadoPaciente" name="tDoc" runat="server" ReadOnly="true"></asp:TextBox>
            </div>

            <div class="col-12 col-sm-6 col-lg-3">
                <label for="txtDoctor" class="form-label">Medico</label>
                <asp:TextBox type="text" class="form-control" ID="txtMedico" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-6 col-lg-3">
                <label for="txtFechaTraslado" class="form-label">Fecha de Registro</label>
                <asp:TextBox type="text" class="form-control" ID="txtFechaCreacion" runat="server" ReadOnly="true"></asp:TextBox>
            </div>

        </div>
    </div>

    <div class="container mw-100 m-2 col-10 shadow p-3 mb-5 bg-body rounded m-auto">
        <div class="row ">
            <div class="col-sm">

                <div class="col-sm-8 mb-4">
                    <label for="txtTemperatura" class="form-label">Temperatura <i class="fas fa-temperature-high"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="text" class="form-control" ID="txtTemperatura" runat="server" ReadOnly="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">°C</span>
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtFrecuencia" class="form-label">Frecuencia cardiaca <i class="fas fa-heartbeat"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="text" class="form-control" ID="txtFrecuencia" runat="server" ReadOnly="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">Lat/min</span>
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtPresion" class="form-label">Presión arterial <i class="fas fa-stethoscope"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="text" class="form-control" ID="txtPresion" runat="server" ReadOnly="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">mmHg</span>
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtSaturacion" class="form-label">Saturación de oxigeno <i class="fas fa-head-side-mask"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="text" class="form-control" ID="txtSaturacion" runat="server" ReadOnly="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">%SpO2</span>
                    </div>
                </div>

            </div>
            <div class="col-sm">
                <div class="col-sm-10 mb-4">
                    <label for="txtPronostico" class="form-label">Pronóstico</label>
                    <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtPronostico" Style="height: 85px" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="txtRequerimiento" class="form-label">Requerimiento de medicamentos / cuidado</label>
                    <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtRequerimiento" Style="height: 85px" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="txtEvolucion" class="form-label">Evolucion de Paciente</label>
                    <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtEvolucion" Style="height: 85px" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm">
                <div class="col-sm-10 mb-4">
                    <div class="form-check form-switch">
                        <input class="form-check-input" runat="server" clientidmode="Static" type="checkbox" id="cbTraslado" disabled="disabled">
                        <label class="form-check-label" for="cbTraslado">Requiere traslado</label>
                    </div>
                </div>

                <div class="traslado col-sm-10 mb-4 shadow-sm p-3">
                    <div class="container">
                        <div class="col-sm-12 mb-2">
                            <asp:Label runat="server" ID="lblTraslado" CssClass="badge rounded-pill bg-success" Text="No requiere traslado"></asp:Label>
                        </div>
                        <div class="col-sm-12 mb-4">
                            <label for="txtFechaTraslado" class="form-label">Fecha de traslado</label>
                            <asp:TextBox type="text" class="form-control" ID="txtFechaTraslado" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-sm-12 mb-4">
                            <label for="ddlTipoTraslado" class="form-label">Tipo Traslado</label>
                            <asp:DropDownList runat="server" ID="ddlTipoTraslado" class="form-select" disabled="true">
                            </asp:DropDownList>
                        </div>

                        <div class="col-sm-12 mb-4">
                            <label for="txtComentario" class="form-label">Detalles</label>
                            <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="txtComentario" Style="height: 80px" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">
                    <asp:HyperLink ID="btnSalir" CssClass="btn btn-danger glow mb-1 mb-sm-0 mr-0 mr-sm-1" NavigateUrl="/logOutContacto" Style="margin-left: 5px" runat="server" Text="Salir"></asp:HyperLink>
                </div>
            </div>

        </div>


    </div>
</asp:Content>

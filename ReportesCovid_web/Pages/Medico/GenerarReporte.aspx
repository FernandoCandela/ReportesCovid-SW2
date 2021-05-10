<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="GenerarReporte.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.GenerarReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="px-4 pt-5 text-center">
        <h1 class="display-5 fw-bold m-4">REPORTE DE PACIENTE</h1>
    </div>
    <div class="container mw-100 m-2 col-10 shadow p-3 mb-1 bg-body rounded m-auto">
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
                <asp:TextBox type="number" class="form-control" ID="txtNumdoc" name="tDoc" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-12 col-sm-6 col-lg-3">
                <label for="txtDoctor" class="form-label">Medico</label>
                <asp:TextBox type="text" class="form-control" ID="txtDoctor" runat="server" ReadOnly="true"></asp:TextBox>
            </div>

        </div>
    </div>

    <div class="container mw-100 m-2 col-10 shadow p-3 mb-5 bg-body rounded m-auto">
        <div class="row ">
            <%--            <div class="col-sm">

                    <div class="foto mb-4">
                        <img src="/img/paciente.svg" alt="paciente" class="rounded w-50 mt-4 mb-4 mx-5 img-thumbnail d-block">
                    </div>

                </div>--%>
            <div class="col-sm">

                <div class="col-sm-8 mb-4">
                    <label for="txtTemperatura" class="form-label">Temperatura <i class="fas fa-temperature-high"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="number" class="form-control" ID="txtTemperatura" runat="server" required="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">°C</span>
                    </div>
                    <div class="invalid-feedback">
                        Temperatura es obligatoria.
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtFrecuencia" class="form-label">Frecuencia cardiaca <i class="fas fa-heartbeat"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="number" class="form-control" ID="txtFrecuencia" runat="server" required="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">Lat/min</span>
                    </div>
                    <div class="invalid-feedback">
                        Frecuencia es obligatoria.
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtPresion" class="form-label">Presión arterial <i class="fas fa-stethoscope"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="number" class="form-control" ID="txtPresion" runat="server" required="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">mmHg</span>
                    </div>
                    <div class="invalid-feedback">
                        Presion es obligatoria.
                    </div>
                </div>
                <div class="col-sm-8 mb-4">
                    <label for="txtSaturacion" class="form-label">Saturación de oxigeno <i class="fas fa-head-side-mask"></i></label>
                    <div class="input-group">
                        <asp:TextBox type="number" class="form-control" ID="txtSaturacion" runat="server" required="true"></asp:TextBox>
                        <span class="input-group-text" style="font-size: 1rem">%SpO2</span>
                    </div>
                    <div class="invalid-feedback">
                        Saturacion es obligatoria.
                    </div>
                </div>

            </div>
            <div class="col-sm">
                <div class="col-sm-10 mb-4">
                    <label for="txtPronostico" class="form-label">Pronóstico</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtPronostico" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                    </div>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="txtRequerimiento" class="form-label">Requerimiento de medicamentos / cuidado</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtRequerimiento" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                    </div>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="txtEvolucion" class="form-label">Evolucion de Paciente</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtEvolucion" Style="height: 85px" runat="server" required="true" ToolTip="Escriba aquí..."></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="col-sm-10 mb-4">
                    <div class="form-check form-switch">
                        <input class="form-check-input" type="checkbox" id="flexSwitchCheckDefault">
                        <label class="form-check-label" for="flexSwitchCheckDefault">Requiere traslado</label>
                    </div>
                </div>

                <div class="traslado col-sm-10 mb-4 shadow-sm p-3">

                    <div class="container">
                        <!-- no se si se ponia fecha de traslado-->
                        <div class="col-sm-12 mb-4">
                            <label for="txtEvolucion" class="form-label">Fecha de traslado</label>
                            <div class="col-10 form-floating">
                                <asp:TextBox type="text" TextMode="Date" class="form-control-sm " ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-12 mb-4">
                            <label for="textComentario" class="form-label">Tipo de traslado</label>
                            <div class="form-check">
                                <input runat="server" class="form-check-input" type="radio" name="traslado" id="cbUci">
                                <label class="form-check-label" for="flexRadioDefault1">
                                    UCI
                                </label>
                            </div>
                            <div class="form-check">
                                <input runat="server" class="form-check-input" type="radio" name="traslado" id="cbHospital" checked>
                                <label class="form-check-label" for="flexRadioDefault2">
                                    Hospital de mayor complejidad
                                </label>
                            </div>
                        </div>

                        <div class="col-sm-12 mb-4">
                            <label for="textComentario" class="form-label">Detalles</label>
                            <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="textComentario" Style="height: 80px" runat="server" required="true" ToolTip="Escriba aquí..." ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">
                    <asp:Button ID="btnActualizar" CssClass="btn btn-primary glow mb-1 mb-sm-0 mr-0 mr-sm-1" Style="margin-left: 5px" runat="server" Text="Guardar"></asp:Button>
                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow mb-1 mb-sm-0 mr-0 mr-sm-1" Style="margin-left: 5px" runat="server" Text="Cancelar"></asp:HyperLink>
                </div>
            </div>

        </div>


    </div>


</asp:Content>

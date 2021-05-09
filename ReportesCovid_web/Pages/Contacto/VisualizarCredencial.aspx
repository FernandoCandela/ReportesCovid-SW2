<%@ Page Language="C#" MasterPageFile="~/MasterPages/Contacto.Master" AutoEventWireup="true" CodeBehind="VisualizarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.VisualizarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="px-4 py-5  text-center">
        <h1 class="display-5 fw-bold m-4">REPORTE MÉDICO</h1>
    </div>

    <div class="container mw-100 m-2 col-10 shadow p-3 mb-5 bg-body rounded m-auto">
        <div class="row ">
            <div class="col-sm">
                <div class="datos mb-4">
                    <div class="col-sm-6 mb-4">
                        <label for="txtNombres" class="form-label">Nombres</label>
                        <asp:TextBox type="text" class="form-control" ID="txtNombres" runat="server" ReadOnly="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este campo.
                        </div>
                    </div>

                    <div class="col-sm-6 mb-4">
                        <label for="tApellidos" class="form-label">Apellidos</label>
                        <asp:TextBox type="text" class="form-control" ID="txtApellidos" runat="server" ReadOnly="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este campo.
                        </div>
                    </div>

                    <div class="col-sm-6 mb-4">
                        <label for="txtNumdoc" class="form-label">Número de Documento</label>
                        <asp:TextBox type="number" class="form-control" ID="txtNumdoc" onkeypress="return solonumerosydecimales(event);" name="tDoc" MaxLength="10" runat="server" ReadOnly="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este campo.
                        </div>
                    </div>
                </div>

                <div class="foto mb-4">
                    <img src="/img/paciente.svg" alt="paciente" class="rounded w-50 mt-4 mb-4 mx-5 img-thumbnail d-block">
                </div>

                <div class="doctor">
                    <div class="col-sm-6 mb-4">
                        <label for="txtDoctor" class="form-label">Doctor</label>
                        <asp:TextBox type="text" class="form-control" ID="txtDoctor" runat="server" ReadOnly="true"></asp:TextBox>
                        <div class="invalid-feedback">
                            Debe llenar este campo.
                        </div>
                    </div>
                </div>

            </div>
            <div class="col-sm">

                <div class="col-sm-6 mb-4">
                    <label for="txtTemperatura" class="form-label">Temperatura</label>
                    <asp:TextBox type="number" class="form-control" ID="txtTemperatura" runat="server" ReadOnly="true"></asp:TextBox>
                    <div class="invalid-feedback">
                        Temperatura es obligatoria.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="txtFrecuencia" class="form-label">Frecuencia cardiaca</label>
                    <asp:TextBox type="number" class="form-control" ID="txtFrecuencia" runat="server" ReadOnly="true"></asp:TextBox>
                    <div class="invalid-feedback">
                        Frecuencia es obligatoria.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="txtPresion" class="form-label">Presión arterial</label>
                    <asp:TextBox type="number" class="form-control" ID="txtPresion" runat="server" ReadOnly="true"></asp:TextBox>
                    <div class="invalid-feedback">
                        Presion es obligatoria.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="txtSaturacion" class="form-label">Saturación de oxigeno</label>
                    <asp:TextBox type="number" class="form-control" ID="txtSaturacion" runat="server" ReadOnly="true"></asp:TextBox>
                    <div class="invalid-feedback">
                        Saturacion es obligatoria.
                    </div>
                </div>

                <div class="col-sm-10 mb-4">
                    <label for="txtPronostico" class="form-label">Pronóstico</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtPronostico" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="txtRequerimiento" class="form-label">Requerimiento de medicamentos / cuidado</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtRequerimiento" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="evolucion col-sm-10 mb-4">
                    <label for="txtEvolucion" class="form-label">Evolucion de Paciente</label>
                    <div class="col-10 form-floating">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="txtEvolucion" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>

                <div class="traslado col-sm-10 mb-4 shadow-sm p-1">
                    <label for="traslado" class="form-label m-2">Requiere traslado</label>

                    <!-- no se si se ponia fecha de traslado-->
                    <div class="evolucion col-sm-10 p-4">
                        <label for="txtEvolucion" class="form-label">Fecha de traslado</label>
                        <div class="col-10 form-floating">
                            <asp:TextBox type="text" TextMode="Date" class="form-control-sm " ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-check">
                        <asp:RadioButton ID="btnUci" runat="server" Text="UCI" GroupName="traslado" class="d-block mb-2" Enabled="false"/>
                        <asp:RadioButton ID="btnHospital" runat="server" Text="Hospital de mayor complejidad" GroupName="traslado" Enabled="false"/>
                    </div>

                    <div class="col-10 form-floating mt-3 p-3">
                        <asp:TextBox type="text" TextMode="MultiLine" class="form-control" ID="textComentario" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
                <div class="col-12">
                    <asp:Button runat="server" class="btn btn-primary btn-lg me-3 shadow-sm" Text="Salir"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

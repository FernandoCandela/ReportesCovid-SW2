<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Contacto.Master" AutoEventWireup="true" CodeBehind="VerMensaje.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.Mensajes.VerMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Ver Mensaje</h3>
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
                                        <i class="bx bx-message-detail mr-25"></i><span class="d-none d-sm-block">Datos de Mensaje</span>
                                    </a>
                                </li>
                                <li class="nav-item" runat="server" id="tabRespuesta" style="display:none">
                                    <a class="nav-link d-flex align-items-center" id="respuesta-tab" data-toggle="tab" href="#respuesta" aria-controls="respuesta" role="tab" aria-selected="true">
                                        <i class="bx bx-message-check mr-25"></i><span class="d-none d-sm-block">Respuesta</span>
                                    </a>
                                </li>
                            </ul>

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-12">
                                            <label for="txtAsunto" class="form-label">Asunto</label>
                                            <asp:TextBox type="text" class="form-control" ID="txtAsunto" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                        <div class="col-md-12">
                                            <label for="ddlTipoMensaje" class="form-label">Tipo de Mensaje</label>
                                            <asp:DropDownList runat="server" ID="ddlTipoMensaje" class="form-select" disabled="true">
                                            </asp:DropDownList>
                                        </div>

                                        <div class="col-md-12">
                                            <label for="txtMensaje" class="form-label">Mensaje</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="txtMensaje" Style="height: 120px" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="tab-pane fade show" id="respuesta" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">
                                        <div class="col-md-12">
                                            <label for="txtRespuesta" class="form-label">Respuesta</label>
                                            <asp:TextBox type="text" TextMode="MultiLine" CssClass="form-control" ID="txtRespuesta" Style="height: 200px" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">
                                    <asp:HyperLink ID="btnCancelar" CssClass="btn btn-danger glow" NavigateUrl="/contacto/mensaje/lista" runat="server" Text="volver"></asp:HyperLink>
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
        jQuery(function () {
            jQuery('#MyTab a').on('click', function () {
                $(this).tab('show');
            });
        })
    </script>

</asp:Content>

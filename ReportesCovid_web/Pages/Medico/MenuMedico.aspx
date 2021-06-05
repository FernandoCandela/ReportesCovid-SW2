<%@ Page Title="Essalud - Menu" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="MenuMedico.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.MenuMedico1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Menú Medico</h3>
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
                            <div class="tab-content">
                                <div class="tab-pane active fade show">
                                    <div class="row">
                                        <div class="row row-cols-1 row-cols-md-2 mb-3 text-center">
                                            <div class="col">
                                                <div class="card mb-4 rounded-3 shadow-sm">
                                                    <div class="card-header py-3  ">
                                                        <h3 class="my-0 fw-normal">Buscar Paciente</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="fas fa-search fa-10x d-block"></i>
                                                        <asp:HyperLink ID="lnkBuscar" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/medico/paciente/lista">Entrar</asp:HyperLink>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col">
<%--                                                <div class="card mb-4 rounded-3 shadow-sm">
                                                    <div class="card-header py-3">
                                                        <h3 class="my-0 fw-normal">Generar Reporte</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="far fa-clipboard fa-10x d-block"></i>
                                                        <asp:HyperLink ID="lnkReporte" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/GenerarReporte">Entrar</asp:HyperLink>

                                                    </div>
                                                </div>--%>
                                            </div>
                                        </div>
                                    </div>
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
</asp:Content>

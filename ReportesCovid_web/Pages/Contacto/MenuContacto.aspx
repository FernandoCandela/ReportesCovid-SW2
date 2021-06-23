<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Contacto.Master" AutoEventWireup="true" CodeBehind="MenuContacto.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.MenuContacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
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

                                        <div class="row row-cols-1 row-cols-md-3 mb-3 text-center mt-10">
                                            <div class="col">
                                                <div class="card mb-4 rounded-3 shadow-sm">
                                                    <div class="card-header py-3  ">
                                                        <h3 class="my-0 fw-normal">Ver Reportes</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="fas fa-user-plus d-block mb-3 fa-10x"></i>
                                                        <asp:HyperLink ID="lnkCrear" runat="server" class="w-75 btn btn-lg btn-primary" NavigateUrl="/contacto/reporte/lista">Entrar</asp:HyperLink>

                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col">
                                                <div class="card mb-4 rounded-3 shadow-sm">
                                                    <div class="card-header py-3  ">
                                                        <h3 class="my-0 fw-normal">Ver Mensajes</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="fas fa-user-edit d-block mb-3 fa-10x"></i>
                                                        <asp:HyperLink runat="server" ID="lnkModificar" class="w-75 btn btn-lg btn-primary">Proximamente</asp:HyperLink>
                                                    </div>
                                                </div>
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

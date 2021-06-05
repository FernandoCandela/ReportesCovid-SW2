<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="MenuEnfermeraV2.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.MenuEnfermeraV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">

    <h3>Menu Enfermera</h3>

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
                                                <div class="card mb-4 rounded-4 shadow-sm">
                                                    <div class="card-header py-3  ">
                                                        <h3 class="my-0 fw-normal">Registrar Paciente</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="fas fa-search fa-10x d-block"></i>
                                                        <asp:HyperLink ID="lnkRegistrar" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/RegistrarPaciente">Entrar</asp:HyperLink>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col">
                                                <div class="card mb-4 rounded-4 shadow-sm">
                                                    <div class="card-header py-3  ">
                                                        <h3 class="my-0 fw-normal">Lista de Paciente</h3>
                                                    </div>
                                                    <div class="card-body p-5">
                                                        <i class="far fa-list-alt fa-10x d-block"></i>
                                                        <asp:HyperLink ID="lnkModificar" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/TablaModificarPaciente">Entrar</asp:HyperLink>

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

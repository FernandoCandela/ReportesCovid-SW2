<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="MenuEnfermera.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.MenuEnfermera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container my-md-5 pt-5 rounded">
        <main>
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
        </main>

    </div>
</asp:Content>

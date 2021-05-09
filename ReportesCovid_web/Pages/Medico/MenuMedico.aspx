<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="MenuMedico.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.MenuMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
        <h1 class="display-5 fw-bold mt-5">Menú</h1>
    </div>

    <div class="container my-md-5 ">
        <main>
            <div class="row row-cols-1 row-cols-md-2 mb-3 text-center">
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Buscar Paciente</h3>
                        </div>
                        <div class="card-body p-5">
                            <i class="fas fa-search fa-10x d-block"></i>
                            <asp:HyperLink ID="lnkBuscar" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/BuscarPaciente">Entrar</asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3">
                            <h3 class="my-0 fw-normal">Generar Reporte</h3>
                        </div>
                        <div class="card-body p-5">
                            <i class="far fa-clipboard fa-10x d-block"></i>
                            <asp:HyperLink ID="lnkReporte" runat="server" class="w-50 btn btn-lg btn-primary mt-4" NavigateUrl="/GenerarReporte">Entrar</asp:HyperLink>

                        </div>
                    </div>
                </div>
            </div>
        </main>
    </div>
</asp:Content>

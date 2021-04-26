<%@ Page Language="C#" MasterPageFile="~/MasterPages/Enfermera.Master" AutoEventWireup="true" CodeBehind="MenuEnfermera.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.MenuEnfermera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container my-md-5 ">
        <main>
            <div class="row row-cols-1 row-cols-md-2 mb-3 text-center">
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Crear Paciente</h3>
                        </div>
                        <div class="card-body p-5">
                            <asp:LinkButton ID="LinkButton1" runat="server" class="w-100 btn btn-lg btn-primary" PostBackUrl="/RegistrarPaciente">Entrar</asp:LinkButton>
                            <%--<a href="12.RegistrarPaciente.html" class="w-100 btn btn-lg btn-primary">Entrar</a>--%>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card mb-4 rounded-3 shadow-sm">
                        <div class="card-header py-3  ">
                            <h3 class="my-0 fw-normal">Modificar Paciente</h3>
                        </div>
                        <div class="card-body p-5">
                            <asp:LinkButton ID="LinkButton2" runat="server" class="w-100 btn btn-lg btn-primary" PostBackUrl="/TablaModificarPaciente">Entrar</asp:LinkButton>
                            <%--<a href="13.TablaModificarPaciente.html" class="w-100 btn btn-lg btn-primary">Entrar</a>--%>

                        </div>
                    </div>
                </div>
            </div>
        </main>

        <footer class="pt-4 my-md-5 pt-md-5 border-top">
            <div class="row">
                <div class="col-12 col-md">
                    <small class="d-block mb-3 text-muted">&copy;   2021</small>
                </div>
            </div>
        </footer>

    </div>
</asp:Content>

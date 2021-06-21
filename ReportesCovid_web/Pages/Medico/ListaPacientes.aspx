<%@ Page Title="Essalud - Pacientes" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="ListaPacientes.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.ListaPacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Lista Pacientes</h3>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="app-content content">
        <div class="content-overlay"></div>
        <div class="content-wrapper">
            <div class="content-header row">
            </div>
            <div class="content-body">
                <section class="users-list-wrapper">
                    <div class="users-list-filter px-1">
                        <div class="container border rounded">
                            <div class="row py-2">
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="txtBuscar">Criterio</label>
                                    <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar"></asp:TextBox>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="ddlEstadoPaciente">Estado</label>
                                    <asp:DropDownList runat="server" ID="ddlEstadoPaciente" class="form-select">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3 d-flex align-items-end">
                                    <asp:LinkButton runat="server" ID="btnBuscar" CssClass="btn btn-outline-success end" Text="Buscar" OnClick="btnBuscar_Click"></asp:LinkButton>
                                </div>
                            </div>
                            <div class="row mb-2">
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="users-list-table">
                        <div class="card">
                            <div class="card-body">
                                <!-- datatable start -->
                                <div class="table-responsive mx-5">
                                    <div class="table table-striped table-sm table-primary">
                                        <asp:GridView runat="server" ID="gvPacientes" AutoGenerateColumns="False" AllowPaging="True"
                                            CssClass="table" PageSize="5" OnRowCommand="gvPacientes_RowCommand" OnPageIndexChanging="gvPacientes_PageIndexChanging"
                                            EmptyDataText="No se encontraron datos." GridLines="None">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Código Paciente</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIdPaciente" runat="server" Text='<% #Bind("IdPaciente")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Nombres</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNombres" runat="server" Text='<% #Bind("Nombres")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Apellidos</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblApellidos" runat="server" Text='<% #Bind("Apellidos")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Tipo Documento</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTipoDocumento" runat="server" Text='<% #Bind("NombreTipodoc")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Numero Documento</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNumDocumento" runat="server" Text='<% #Bind("Numdoc")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                   <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Tipo Seguro</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTipoSeguro" runat="server" Text='<% #Bind("NombreTipoSeguro")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Estado Paciente</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblEstadoPaciente" runat="server" Text='<% #Bind("NombreEstadoPaciente")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>


                                                <asp:TemplateField>
                                                    <HeaderStyle Width="7.5%" />
                                                    <HeaderTemplate>Generar Reporte</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <button data-toggle='dropdown' class='btn btn-primary btn-sm dropdown-toggle'>Opciones <span class='caret'></span></button>
                                                        <ul class='dropdown-menu dropdown-menu-right'>
                                                            <li>
                                                                <asp:LinkButton runat="server" ID="lnkVerReportes" CommandName="VerReportes" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="bx bx-edit-alt"></i>Ver Reportes </asp:LinkButton></li>
                                                            <hr />
                                                            <li>
                                                                <asp:LinkButton runat="server" ID="lnkGenerar" CommandName="Generar" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="bx bx-bar-chart-square"></i>Generar Reporte </asp:LinkButton></li>
                                                        </ul>

                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                            </Columns>
                                            <PagerStyle CssClass="Pager" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <!-- users list ends -->

                <br />
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Foot" runat="server">
</asp:Content>

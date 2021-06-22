<%@ Page Title="Essalud - Reportes" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="ListaReportes.aspx.cs" Inherits="ReportesCovid_web.Pages.Medico.ListaReportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Lista Reportes</h3>
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
                                    <label for="txtBuscar">Busqueda por fechas</label>
                                    <asp:Calendar runat="server" ID="calendario" SelectionMode="DayWeekMonth" OnSelectionChanged="calendario_SelectionChanged"></asp:Calendar>
                                </div>

                                <div class="col-12 col-sm-6 col-lg-3 d-flex align-items-end">
                                    <asp:LinkButton runat="server" ID="btnMostrar" CssClass="btn btn-outline-success end" Text="Mostrar todos los Reportes" OnClick="btnMostrar_Click"></asp:LinkButton>
                                </div>
                                <div class="col-12 col-sm-6 col-lg-3 d-flex align-items-end">
                                    <asp:HyperLink runat="server" ID="btnVolver" CssClass="btn btn-outline-danger end" Text="Volver" NavigateUrl="/medico/paciente/lista"></asp:HyperLink>
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
                                        <asp:GridView runat="server" ID="gvReportes" AutoGenerateColumns="False" AllowPaging="True"
                                            CssClass="table" PageSize="5" OnRowCommand="gvReportes_RowCommand" OnPageIndexChanging="gvReportes_PageIndexChanging"
                                            EmptyDataText="No se encontraron datos." GridLines="None">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Código Reporte</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIdHistoria" runat="server" Text='<% #Bind("IdHistorial")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Fecha Registro</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblFechaCreacion" runat="server" Text='<% #Bind("FechaCreacion")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Traslado</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIB_Traslado" runat="server" Text='<% #Bind("IB_Traslado")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="7.5%" />
                                                    <HeaderTemplate>Ver Reporte</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lnkVerReporte" CommandName="VerReporte" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="bx bx-edit-alt"></i>Ver Reporte </asp:LinkButton></li>                                              
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


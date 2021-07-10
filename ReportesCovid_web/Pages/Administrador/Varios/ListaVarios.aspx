<%@ Page Title="Essauld - Varios" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="ListaVarios.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.Varios.ListaVarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Lista Varios</h3>
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
                                    <label for="cbActivado">Criterio</label>
                                    <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar"></asp:TextBox>
                                </div>

                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="ddlTiposVarios">Tipos</label>
                                    <asp:DropDownList runat="server" ID="ddlTiposVarios" class="form-select">
                                        <asp:ListItem Text="Todos" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Estados de Paciente" Value="IN_EstadoPaciente"></asp:ListItem>
                                        <asp:ListItem Text="Roles" Value="IN_Rol"></asp:ListItem>
                                        <asp:ListItem Text="Tipos de Documento" Value="IN_Tipodoc"></asp:ListItem>
                                        <asp:ListItem Text="Tipos de Mensajes" Value="IN_TipoMensaje"></asp:ListItem>
                                        <asp:ListItem Text="Cargos" Value="IN_Cargo"></asp:ListItem>
                                        <asp:ListItem Text="Tipos de Seguro" Value="IN_TipoSeguro"></asp:ListItem>
                                        <asp:ListItem Text="Tipos de Traslado" Value="IN_TipoTraslado"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <div class="col-12 col-sm-6 col-lg-3">
                                    <label for="ddlEstado">Estado</label>
                                    <asp:DropDownList runat="server" ID="ddlEstado" class="form-select">
                                        <asp:ListItem Text="Activo" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Desactivado" Value="0"></asp:ListItem>
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
                                        <asp:GridView runat="server" ID="gvVarios" AutoGenerateColumns="False" AllowPaging="True"
                                            CssClass="table" PageSize="10" OnRowCommand="gvVarios_RowCommand" OnRowDataBound="gvVarios_RowDataBound" OnPageIndexChanging="gvVarios_PageIndexChanging"
                                            EmptyDataText="No se encontraron datos." GridLines="None">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderStyle Width="9%" />
                                                    <HeaderTemplate>Id Tablas varios</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIdTab" runat="server" Text='<% #Bind("IdTabVarios")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="3%" />
                                                    <HeaderTemplate>Valor</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblValor" runat="server" Text='<% #Bind("Valor")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Descripcion</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDescripcion" runat="server" Text='<% #Bind("Descripcion")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Tipo atributo</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblAtributo" runat="server" Text='<% #Bind("TipoAtributo")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Entidad Tabla</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblEntidad" runat="server" Text='<% #Bind("EntidadTabla")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="3%" />
                                                    <HeaderTemplate>Estado</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Literal runat="server" ID="ltlEstados"></asp:Literal>
                                                        <asp:Label ID="lblIB_Estado" runat="server" Text='' Style="visibility: hidden;" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                                    <HeaderStyle Width="5%" />
                                                    <HeaderTemplate>Editar</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lnkEditar" CommandName="Editar" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="bx bx-edit-alt"></i>Editar </asp:LinkButton>
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

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.Usuarios.ListaUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3>Lista Usuarios</h3>
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
                                    <label for="ddlRol">Rol</label>
                                    <asp:DropDownList runat="server" ID="ddlRol" class="form-select">
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
                                        <asp:GridView runat="server" ID="gvUsuarios" AutoGenerateColumns="False" AllowPaging="True"
                                            CssClass="table" PageSize="5" OnRowCommand="gvUsuarios_RowCommand" OnRowDataBound="gvUsuarios_RowDataBound" OnPageIndexChanging="gvUsuarios_PageIndexChanging"
                                            EmptyDataText="No se encontraron datos." GridLines="None">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Código Usuario</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIdUsuario" runat="server" Text='<% #Bind("IdUsuario")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Usuario</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblUsuario" runat="server" Text='<% #Bind("Usuario")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Nombre Completo</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNombreCompleto" runat="server" Text='<%# string.Concat(Eval("PrimerNombre")," ", Eval("SegundoNombre")," ", Eval("ApellidoPaterno")," ", Eval("ApellidoMaterno"))%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Numero de documento</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNumDoc" runat="server" Text='<%# string.Concat(Eval("NombreTipoDoc"), " - ", Eval("Numdoc"))%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Telefono</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTelefono" runat="server" Text='<% #Bind("Telefono")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                <asp:TemplateField>
                                                    <HeaderStyle Width="11%" />
                                                    <HeaderTemplate>Rol</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNombreRol" runat="server" Text='<% #Bind("NombreRol")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>


                                                <%--                                                <asp:TemplateField>
                                                     <HeaderStyle Width="3%" />
                                                    <HeaderTemplate>Cargo</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNombreCargo" runat="server" Text='<% #Bind("NombreCargo")%>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>--%>

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
                                                    <HeaderTemplate>Editar Usuario</HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:LinkButton runat="server" ID="lnkEditar" CssClass="" Text="" CommandName="Editar" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="bx bx-edit-alt"></i>Editar </asp:LinkButton>
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

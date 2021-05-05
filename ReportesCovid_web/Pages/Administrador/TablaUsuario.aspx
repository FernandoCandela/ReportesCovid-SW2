<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="TablaUsuario.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.TablaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
        <h1 class="display-5 fw-bold">MODIFICAR CUENTA</h1>
    </div>

    <div class="navbar mx-5">
        <%--<input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">--%>
        <asp:TextBox runat="server" ID="txtBuscar" class="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar"></asp:TextBox>
        <asp:Button runat="server" class="btn btn-success mt-3" type="submit" Text="Buscar"></asp:Button>
    </div>

    <div class="foto">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-fluid img-thumbnail">
    </div>

    <h2>Cuentas</h2>
    <div class="table-responsive mx-5">
        <div class="table table-striped table-sm table-primary">
            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                CssClass="table" PageSize="20"
                EmptyDataText="No se encontraron datos." GridLines="None">
                <Columns>
                    <asp:TemplateField Visible="false">
                        <%--<HeaderStyle Width="11%" />--%>
                        <HeaderTemplate>Código Usuario</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIdUsuario" runat="server" Text='<% #Bind("IdUsuario")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Primer Nombre</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblPrimerNombre" runat="server" Text='<% #Bind("PrimerNombre")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Segundo Nombre</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSegundoNombre" runat="server" Text='<% #Bind("SegundoNombre")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%-- <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Apellido Paterno</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblApellidoPaterno" runat="server" Text='<% #Bind("ApellidoPaterno")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%-- <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Apellido Materno</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblApellidoMaterno" runat="server" Text='<% #Bind("ApellidoMaterno")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--  <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Tipo de documento</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTipoDoc" runat="server" Text='<% #Bind("IN_Tipodoc")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--  <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Telefono</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTelefono" runat="server" Text='<% #Bind("Telefono")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--  <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Numero de documento</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNumDoc" runat="server" Text='<% #Bind("Numdoc")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--  <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Cargo</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNombreCargo" runat="server" Text='<% #Bind("NombreCargo")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField>
                        <%--      <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Rol</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNombreRol" runat="server" Text='<% #Bind("NombreRol")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                        <HeaderStyle Width="5%" />
                        <HeaderTemplate>Editar Usuario</HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="lnkEditar" CssClass="" Text="" CommandName="Editar" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="fa fa-edit " style="color:black"> Editar </i> </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <PagerStyle CssClass="GridPager" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>

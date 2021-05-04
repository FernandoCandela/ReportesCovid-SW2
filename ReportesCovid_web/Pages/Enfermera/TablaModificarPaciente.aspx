<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="TablaModificarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.TablaModificarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1 class="display-5 fw-bold">LISTA DE PACIENTES</h1>
    </div>

    <div class="navbar container-fluid mx-5">
        <div class="d-flex">
            <asp:TextBox runat="server" ID="txtBuscar" class="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar"></asp:TextBox>
            <asp:Button runat="server" class="btn btn-outline-success" type="submit" Text="Buscar"></asp:Button>
        </div>
    </div>

    <div class="foto">
        <img src="/img/paciente.svg" alt="paciente" class="rounded float-start w-25 mx-5 img-fluid img-thumbnail">
    </div>

    <h2>Pacientes</h2>
    <div class="table-responsive mx-5">
        <div class="table table-striped table-sm table-primary">
            <asp:GridView runat="server" ID="gvPacientes" AutoGenerateColumns="False" AllowPaging="True"
                CssClass="table" PageSize="20"
                EmptyDataText="No se encontraron datos." GridLines="None">
                <Columns>
                    <asp:TemplateField Visible="false">
                        <%--<HeaderStyle Width="11%" />--%>
                        <HeaderTemplate>Código Paciente</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblIdPaciente" runat="server" Text='<% #Bind("IdPaciente")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Nombres</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNombres" runat="server" Text='<% #Bind("Nombres")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--      <HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Apellidos</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblApellidos" runat="server" Text='<% #Bind("Apellidos")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Tipo Documento</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTipoDocumento" runat="server" Text='<% #Bind("IN_Tipodoc")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Numero Documento</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTipoDocumento" runat="server" Text='<% #Bind("Numdoc")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Tipo Seguro</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTipoSeguro" runat="server" Text='<% #Bind("IN_TipoSeguro")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <%--<HeaderStyle Width="3%" />--%>
                        <HeaderTemplate>Estado Paciente</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEstadoPaciente" runat="server" Text='<% #Bind("IN_EstadoPaciente")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                        <HeaderStyle Width="5%" />
                        <HeaderTemplate>Editar Paciente</HeaderTemplate>
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


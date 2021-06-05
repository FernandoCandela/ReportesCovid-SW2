<%@ Page Language="C#" MasterPageFile="~/MasterPages/Usuario.Master" AutoEventWireup="true" CodeBehind="TablaModificarPaciente.aspx.cs" Inherits="ReportesCovid_web.Pages.Enfermera.TablaModificarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .Pager span {
            border-top-left-radius: .2rem;
            border-bottom-left-radius: .2rem;
            z-index: 3;
            color: #fff;
            background-color: #0d6efd;
            border-color: #0d6efd;
            text-align: center;
            display: inline-block;
            padding: .25rem .5rem;
            font-size: .875rem;
            margin-right: 3px;
            line-height: 150%;
            border: 1px solid #dee2e6;
            transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
            text-decoration: none;
            position: relative;
            display: block;
        }

        .Pager a {
            border-top-left-radius: .2rem;
            border-bottom-left-radius: .2rem;
            z-index: 3;
            color: #0d6efd;
            background-color: #fff;
            border-color: #0d6efd;
            text-align: center;
            display: inline-block;
            padding: .25rem .5rem;
            font-size: .875rem;
            margin-right: 3px;
            line-height: 150%;
            border: 1px solid #dee2e6;
            transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
            text-decoration: none;
            position: relative;
            display: block;
        }
    </style>
    <div class="text-center">
        <h1 class="display-5 fw-bold my-5 p-3 mb-0">LISTA DE PACIENTES</h1>
    </div>
    <div class="container">
        <div class="container mw-100 m-2 p-3 mb-1 bg-body rounded m-auto">
            <div class="row justify-content-end">
                <div class="col-12 col-sm-6 col-lg-3">
                    <label for="cbActivado">NumeroDocumento/Nombres/Apellidos</label>
                    <asp:TextBox runat="server" ID="txtBuscar" CssClass="form-control me-2" type="search" placeholder="Buscar" aria-label="buscar"></asp:TextBox>
                </div>
                <div class="col-12 col-sm-6 col-lg-3">
                    <label for="cbActivado">Estado</label>
                    <asp:DropDownList runat="server" ID="ddlEstadoPaciente" class="form-select">
                    </asp:DropDownList>
                </div>
                <div class="col-12 col-sm-6 col-lg-3 d-flex align-items-end">
                    <asp:LinkButton runat="server" ID="btnBuscar" CssClass="btn btn-outline-success end" Text="Buscar" OnClick="btnBuscar_Click"></asp:LinkButton>
                </div>

            </div>
        </div>

        <div class="row">
            <div class="col-3">
                <img src="/img/paciente.svg" alt="paciente" class="img-fluid">
            </div>
            <div class="col-9">
                <div class="table-responsive mx-5">
                    <div class="table table-striped table-sm table-primary">
                        <asp:GridView runat="server" ID="gvPacientes" AutoGenerateColumns="False" AllowPaging="True"
                            CssClass="table" PageSize="5" OnRowCommand="gvPacientes_RowCommand" OnPageIndexChanging="gvPacientes_PageIndexChanging"
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
                                        <asp:Label ID="lblTipoDocumento" runat="server" Text='<% #Bind("NombreTipodoc")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <%--<HeaderStyle Width="3%" />--%>
                                    <HeaderTemplate>Numero Documento</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblNumDocumento" runat="server" Text='<% #Bind("Numdoc")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <%--<HeaderStyle Width="3%" />--%>
                                    <HeaderTemplate>Tipo Seguro</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblTipoSeguro" runat="server" Text='<% #Bind("NombreTipoSeguro")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <%--<HeaderStyle Width="3%" />--%>
                                    <HeaderTemplate>Estado Paciente</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblEstadoPaciente" runat="server" Text='<% #Bind("NombreEstadoPaciente")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                    <HeaderStyle Width="5%" />
                                    <HeaderTemplate>Editar Paciente</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="lnkEditar" CssClass="" Text="" CommandName="Editar" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'><i class="fa fa-edit "></i> Editar </asp:LinkButton>
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
</asp:Content>


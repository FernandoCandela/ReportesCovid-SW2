<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Web_Usuarios.Master" AutoEventWireup="true" CodeBehind="ResponderMensaje.aspx.cs" Inherits="ReportesCovid_web.Pages.Administrador.Mensajes.ResponderMensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentTitle" runat="server">
    <h3 class="m-3">Responder Mensajes</h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="app-content content">
        <div class="content-overplay"></div>
        <div class="content-wrapper">
            <div class="content-header row"></div>
            <div class="content-body">

                <section class="users-edit">
                    <div class="card">
                        <div class="card-body">

                            <div class="tab-content" id="contentTab">
                                <div class="tab-pane active fade show" id="paciente" aria-labelledby="paciente-tab" role="tabpanel">
                                    <div class="row g-3 my-4">

                                        <div class="col-md-5 me-5">
                                            <label for="nombre" class="form-label">Nombre</label>
                                            <div>
                                                <asp:TextBox runat="server" class="form-control" ID="nombre" ReadOnly="true"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-md-5 me-5">
                                            <label for="correo" class="form-label">Correo</label>
                                            <div>
                                                <asp:TextBox runat="server" class="form-control" ID="correo" ReadOnly="true"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-md-5 me-5">
                                            <label for="asunto" class="form-label">Asunto</label>
                                            <div>
                                                <asp:TextBox runat="server" class="form-control" ID="asunto" ReadOnly="true"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div></div>
                                        <div class="col-md-5 me-5">
                                            <label for="mensaje" class="form-label">Mensaje</label>
                                            <div>
                                                <asp:TextBox runat="server" class="form-control" TextMode="MultiLine" Wrap="true" ID="mensaje" ReadOnly="true"></asp:TextBox>
                                            </div>
                                        </div>
                                        <hr class=""/>
                                        <div class="col-md-5">
                                            <label for="respuesta" class="form-label">Respuesta</label>
                                            <div class="input-group has-validation">
                                                <asp:TextBox type="text" CssClass="form-control" TextMode="MultiLine" Wrap="true" Rows="3" ID="respuesta" runat="server" aria-describedby="inputGroupPrepend" required="true"></asp:TextBox>
                                                <div class="invalid-feedback">
                                                    Debe ingresar una respuesta.
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-12 d-flex flex-sm-row flex-column justify-content-end mt-1">
                                        <asp:Button runat="server" type="submit" CssClass="btn btn-lg btn-primary glow" ID="enviar" Text="Enviar"></asp:Button>
                                    </div>
                                </div>


                            </div>

                        </div>
                    </div>
                </section>

            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="Foot" runat="server">
</asp:Content>

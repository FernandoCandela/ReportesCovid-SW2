<%@ Page Language="C#" MasterPageFile="~/MasterPages/Contacto.Master" AutoEventWireup="true" CodeBehind="VisualizarCredencial.aspx.cs" Inherits="ReportesCovid_web.Pages.Contacto.VisualizarCredencial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="px-4 py-5  text-center">
        <h1 class="display-5 fw-bold">SEGUIMIENTO</h1>
    </div>


    <div class="container mw-100 m-5 col-10 shadow p-3 mb-5 bg-body rounded m-auto">
        <div class="row ">
            <div class="col-sm">
                <div class="datos mb-4">
                    <div class="col-sm-6 mb-4">
                        <label for="firstName" class="form-label">Nombres</label>
                        <input type="text" class="form-control" id="firstName" placeholder="" value="" disabled>
                        <div class="invalid-feedback">
                            Valid first name is required.
                        </div>
                    </div>

                    <div class="col-sm-6 mb-4">
                        <label for="lastName" class="form-label">Apellidos</label>
                        <input type="text" class="form-control" id="lastName" placeholder="" value="" disabled>
                        <div class="invalid-feedback">
                            Valid last name is required.
                        </div>
                    </div>

                    <div class="col-sm-6 mb-4">
                        <label for="dni" class="form-label">DNI</label>
                        <input type="text" class="form-control" id="dni" placeholder="12345678" disabled>
                        <div class="invalid-feedback">
                            Please enter your DNI.
                        </div>
                    </div>
                </div>

                <div class="foto mb-4">
                    <img src="/img/paciente.svg" alt="paciente" class="rounded w-50 mt-4 mb-4 mx-5 img-thumbnail d-block">
                </div>

                <div class="doctor">
                    <div class="col-sm-6 mb-4">
                        <label for="doctor" class="form-label">Doctor</label>
                        <input type="text" class="form-control" id="doctor" placeholder="" value="" disabled>
                        <div class="invalid-feedback">
                            Doctor is required.
                        </div>
                    </div>
                    <div class="col-sm-6 mb-4">
                        <label for="firma" class="form-label">Firma</label>
                        <input type="text" class="form-control" id="firma" placeholder="" value="" disabled>
                        <div class="invalid-feedback">
                            Firma is required.
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm">

                <div class="col-sm-6 mb-4">
                    <label for="temperatura" class="form-label">Temperatura</label>
                    <input type="text" class="form-control" id="temperatura" placeholder="" value="" disabled>
                    <div class="invalid-feedback">
                        Temperatura is required.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="frecuencia" class="form-label">Frecuencia cardiaca</label>
                    <input type="text" class="form-control" id="frecuencia" placeholder="" value="" disabled>
                    <div class="invalid-feedback">
                        frecuencia is required.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="presion" class="form-label">Presión arterial</label>
                    <input type="text" class="form-control" id="presion" placeholder="" value="" disabled>
                    <div class="invalid-feedback">
                        presion is required.
                    </div>
                </div>
                <div class="col-sm-6 mb-4">
                    <label for="saturacion" class="form-label">Saturacion de oxigeno</label>
                    <input type="text" class="form-control" id="saturacion" placeholder="" value="" disabled>
                    <div class="invalid-feedback">
                        saturacion is required.
                    </div>
                </div>

                <div class="col-sm-10 mb-4">
                    <label for="pronostico" class="form-label">Pronostico</label>
                    <div class="col-10 form-floating">
                        <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea1" style="height: 100px" disabled></textarea>
                    </div>
                </div>
                <div class="col-sm-10 mb-4">
                    <label for="requerimiento" class="form-label">Requerimiento de medicamentos / cuidado</label>
                    <div class="col-10 form-floating">
                        <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea2" style="height: 100px" disabled></textarea>
                    </div>
                </div>
            </div>
            <div class="col-sm">

                <div class="contenedorCalendar col-sm-10 mb-4">
                    <input type="date" name="calendario" id="calendar">
                </div>
                <div class="evolucion col-sm-10 mb-4">
                    <label for="evolucion" class="form-label">Evolucion de Paciente</label>
                    <div class="col-10 form-floating">
                        <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea3" style="height: 100px" disabled></textarea>
                    </div>
                </div>

                <div class="traslado col-sm-10 mb-4">
                    <label for="traslado" class="form-label">Requiere traslado</label>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault" disabled>
                        <label class="form-check-label" for="flexCheckDefault">
                            UCI
                        </label>
                    </div>

                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="" id="flexCheckChecked" disabled>
                        <label class="form-check-label" for="flexCheckChecked">
                            Hospital de mayor complejidad
                        </label>

                        <div class="col-10 form-floating">
                            <textarea class="form-control" placeholder="Leave a comment here" id="floatingTextarea4" style="height: 100px" disabled></textarea>
                        </div>

                    </div>

                </div>

            </div>

        </div>
    </div>
</asp:Content>

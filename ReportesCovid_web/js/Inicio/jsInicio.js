var validarLogin = function (tUsuario, tContrasenia) {
    var msj = "";
    var usuario = $('#' + tUsuario).val();
    var contraseña = $('#' + tContrasenia).val();

    if (!usuario) msj += '<li>Debe completar su usuario.</li>';
    if (!contraseña) msj += '<li>Debe completar su contraseña.</li>';
    if (msj.length > 0) {
        Swal.fire({
            title: "Advertencia",
            icon: "warning",
            html: '<ul style="text-align: left; font-size: 0.95rem;">' + msj + '</ul>'
        });
        return false;
    } else return true;
}

var validarCredencial= function (tCrendecial) {
    var msj = "";
    var credencial = $('#' + tCrendecial).val();

    if (!credencial) msj += '<li>Debe ingresar una credencial.</li>';
    if (msj.length > 0) {
        Swal.fire({
            title: "Advertencia",
            icon: "warning",
            html: '<ul style="text-align: left; font-size: 0.95rem;">' + msj + '</ul>'
        });
        return false;
    } else return true;
}
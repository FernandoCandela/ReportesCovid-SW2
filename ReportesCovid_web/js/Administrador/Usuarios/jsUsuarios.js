var GenerarUsuario = function (tprimerNombre, tsegundoNombre, tapellidoPaterno, tapellidoMaterno, txt) {

    if (ValidadGenerarUsuario(tprimerNombre, tapellidoPaterno, tapellidoMaterno)) {
        var primerNombre = $("#" + tprimerNombre).val();
        var segundoNombre = $("#" + tsegundoNombre).val();
        var apellidoPaterno = $("#" + tapellidoPaterno).val();
        var apellidoMaterno = $("#" + tapellidoMaterno).val();

        var usuario = primerNombre.trim().charAt(0) + (segundoNombre.trim().charAt(0) != '-' ? segundoNombre.trim().charAt(0) : "") + "." + apellidoPaterno.trim() + apellidoMaterno.trim().charAt(0);

        $("#" + txt).val(usuario.toLowerCase());


    }
    return false;

}


var ValidadGenerarUsuario = function (tprimerNombre, tapellidoPaterno, tapellidoMaterno) {
    var msj = "";
    var primerNombre = $("#" + tprimerNombre).val();
    var apellidoPaterno = $("#" + tapellidoPaterno).val();
    var apellidoMaterno = $("#" + tapellidoMaterno).val();

    if (!primerNombre) msj += '<li>Debe ingresar un nombre.</li>';
    if (!apellidoPaterno) msj += '<li>Debe ingresar un apellido paterno.</li>';
    if (!apellidoMaterno) msj += '<li>Debe ingresar un apellido materno.</li>'
    if (msj.length > 0) {
        Swal.fire({
            title: "Advertencia",
            icon: "warning",
            html: '<ul style="text-align: left; font-size: 0.95rem;">' + msj + '</ul>'
        });
        return false;
    } else return true;
}
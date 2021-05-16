var changeTraslado = function (check, tfecha, ddlTipoTraslado, textComentario) {
    $("#" + tfecha).val("");
    $("#" + ddlTipoTraslado).val("");
    $("#" + textComentario).val("");

    if ($('#' + check).prop('checked')) {

        $("#" + tfecha).prop('disabled', false);
        $("#" + ddlTipoTraslado).prop('disabled', false);
        $("#" + textComentario).prop('disabled', false);

    } else {
        $("#" + tfecha).prop('disabled', true);
        $("#" + ddlTipoTraslado).prop('disabled', true);
        $("#" + textComentario).prop('disabled', true);
    }
}

var validarTraslado = function (check, tfecha, ddlTipoTraslado, textComentario) {
    try {
        var msj = "";
        if ($('#' + check).prop('checked')) {
            var fecha = $("#" + tfecha).val();
            var Ttraslado = $("#" + ddlTipoTraslado).val();
            var comentario = $("#" + textComentario).val();

            if (!fecha) msj += '<li>Debe ingresar una fecha de traslado.</li>';
            if (Ttraslado == "" || Ttraslado == null) msj += '<li>Debe seleccionar un tipo de traslado valido.</li>';
            if (!comentario) msj += '<li>Debe ingresar un Comentario.</li>'
        }

        if (msj.length > 0) {
            Swal.fire({
                title: "Advertencia",
                icon: "warning",
                html: '<ul style="text-align: left; font-size: 0.95rem;">' + msj + '</ul>'
            });
            return false;
        } else return true;
    }
    catch (e) {
        console.log(e);
    }
}
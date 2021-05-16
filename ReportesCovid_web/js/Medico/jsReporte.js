var changeTraslado = function (check, tfecha, ddlTipoTraslado, textComentario) {
    $("#" + tfecha).val("");
    $("#" + ddlTipoTraslado).val("");
    $("#" + textComentario).val("");

    if ($('#' + check).prop('checked')) {

        $("#" + tfecha).prop('disabled', true);
        $("#" + ddlTipoTraslado).prop('disabled', true);
        $("#" + textComentario).prop('disabled', true);

    } else {
        $("#" + tfecha).prop('disabled', false);
        $("#" + ddlTipoTraslado).prop('disabled', false);
        $("#" + textComentario).prop('disabled', false);
    }
}
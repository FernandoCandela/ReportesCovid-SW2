
function solonumerosydecimales(e) {
    var key;
    if (window.event) // IE
    {
        key = e.keyCode;
    }
    else if (e.which) // Netscape/Firefox/Opera
    {
        key = e.which;
    }
    if (key < 48 || key > 57) {
        if (key == 46) {
            return true;
        } else {
            return false;
        }
    }
    return true;


}
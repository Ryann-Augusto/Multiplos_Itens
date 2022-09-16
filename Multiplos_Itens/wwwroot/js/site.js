
var controleCampo = 1;
function adicionarCampo() {

    //var todos = document.getElementsByClassName("form-control").value();

    document.querySelector("#moreItens").insertAdjacentHTML('beforeend',
        ' <div class="form-group mt-2">'
        + '<label class="control-label" for="Produtos_' + controleCampo + '__Nome">Nome</label>'
        + '<input class="form-control field" type="text" data-val="true" data-val-required="The Nome field is required." id="Produtos_' + controleCampo + '__Nome" name="Produtos[' + controleCampo + '].Nome" value="" onblur="validaForm()">'
        + '<span class="text-danger" id="valida_nome' + controleCampo + '"></span>'
        + '</div>')
    controleCampo++;
}

function validaForm() {
    var positionList = []
    for (i = 0; i < controleCampo; i++) {
        var input = $('#Produtos_' + i + '__Nome')
        var result = null_or_empty('Produtos_' + i + '__Nome', i)
        positionList.push(result);
        if (result == "Vazio" + i) {
            input.addClass('--has-error')
        } else {
            input.removeClass('--has-error')
        }
        console.log(positionList)
    }
}

function null_or_empty(str, contador) {
    var v = document.getElementById(str).value;
    if (v == null || v.trim() == "") {
        return "Vazio" + contador;
    }
    else {
        return "Com valores" + contador;
    }
}

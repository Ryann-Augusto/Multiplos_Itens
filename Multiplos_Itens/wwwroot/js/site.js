
var controleCampo = 1;
function adicionarCampo() {

    document.querySelector("#moreItens").insertAdjacentHTML('beforeend',
        ' <div class="form-group mt-2" id="div' + controleCampo + '">'
        + '<label class="control-label" for="Produtos_' + controleCampo + '__Nome">Nome</label>'
        + '<input class="form-control field" type="text" data-val="true" data-val-required="The Nome field is required." id="Produtos_' + controleCampo + '__Nome" name="Produtos[' + controleCampo + '].Nome" value="" onkeyup="validaForm()"> </input>'
        + '<span class="text-danger" id="valida_nome' + controleCampo + '"></span>'
        + '</div>')
    controleCampo++;
    validaForm();
}

function validaForm() {
    var positionList = []
    for (i = 0; i < controleCampo; i++) {
        try {
            var input = $('#Produtos_' + i + '__Nome')
            var result = null_or_empty('Produtos_' + i + '__Nome', i)
            positionList.push(result.substring(0,5));
            if (result == "Vazio" + i) {
                input.addClass('--has-error')
            } else {
                input.removeClass('--has-error')
            }
        }
        catch {
            input.removeClass('--has-error')
        }
    }
    var valid = positionList.some((x) => x == "Vazio")
    var button = $('#buttonCreate')

    if (valid == true) {
        button.ariaDisabled = false;
        button.addClass('disabled')
    }
    else {
        document.getElementById("buttonCreate").ariaDisabled = true;
        button.removeClass('disabled')
    }
    console.log(positionList)
    console.log("Funcao Some " + valid)
}

function checkValue(x) {
    return x == "Vazio";
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

function removerCampo() {
    try {
        controleCampo = controleCampo - 1
        var result = document.querySelector("#div" + controleCampo)
        console.log(result)
        result.remove();
    }
    catch {
        controleCampo = controleCampo + 1
    }
    validaForm();    
}


function valorTotal(idCampo) {

    var valor1 = document.querySelector("#valor" + idCampo).value;
    var quantidade = document.querySelector("#quantidade" + idCampo).value;

    if (valor1 == 0 || quantidade == 0) {
        document.querySelector("#total" + idCampo).innerHTML = 0;
    }
    else {
        var total = parseFloat(valor1) * parseInt(quantidade);
        document.querySelector("#total" + idCampo).value = parseFloat(total);
    }
}


var controleCampo = 1;
function adicionarCampo() {
    controleCampo++;
    //var todos = document.getElementsByClassName("form-control").value();

    document.querySelector("#moreItens").insertAdjacentHTML('beforeend',
        ' <div class="form-group mt-2">'
        + '<label class="control-label" for="Produtos_' + controleCampo + '__Nome">Nome</label>'
        + '<input class="form-control" type="text" data-val="true" data-val-required="The Nome field is required." id="Produtos_' + controleCampo + '__Nome" name="Produtos[' + controleCampo + '].Nome" value="">'
        + '<span class="text-danger field-validation-valid" data-valmsg-for="Produtos[' + controleCampo + '].Nome" data-valmsg-replace="true"></span>'
        + '</div>')

}

function validaForm() {
    for (i = 1; i <= controleCampo; i++) {
        var result = null_or_empty('Produtos_' + i + '__Nome', i);
        console.log(result);
    }

    console.log(result);
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

function ListarCampos() {
    var todos = document.getElementsByClassName("form-control").length;
    console.log(todos);
    return todos;
}


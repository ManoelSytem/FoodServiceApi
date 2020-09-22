function CreateListCardapio() {
    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get'
    }).done(function (data) {
        $("#modal-body").html(data);
    }).fail(function () {
        alert("Ocorreu um erro tente novamente");
    });;
}

function SalveCacheList() {

    var titulo = $('#tituloMenu').val();
    var descricao = $('#descricao').val();
    var SelectProdutos = $('#SelectProduto').val();
  
    $.ajax({
        url: "/Cardapio/MenuListCardapioPost",
        type: 'post',
        data: { titulo: titulo, descricao: descricao, produtos: SelectProdutos },
    }).done(function (data) {
        $("#modal-body").html(data);
    }).fail(function (data) {
        alert("Ocorreu um erro: " + data['responseText'] );
    });;
}


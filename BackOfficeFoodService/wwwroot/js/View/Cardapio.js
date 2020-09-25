function CreateListCardapio(idcardapio, tituloCardapio) {

    var idCaradpio = idcardapio;
    var tituloCardapio = tituloCardapio;

    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get'
    }).done(function (data) {
        $("#modal-body").html(data);
        $("#MenuCadapio").text("Cadápio Selecionado : " + tituloCardapio);
        $("#custId").val(idCaradpio);

    }).fail(function () {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}

function SalveMenuListCardapio() {

    var idcardapio = $("#custId").val();
    var titulo = $('#tituloMenu').val();
    var descricao = $('#descricao').val();
    var SelectProdutos = $('#SelectProduto').val();

    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'post',
        data: { idCardapio: idcardapio, titulo: titulo, descricao: descricao, produtos: SelectProdutos },
    }).done(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['description']);
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}

function buscaListaCardapio(idcardapio) {

    $.ajax({
        url: "/Cardapio/BuscarMenuListaCardapio",
        type: 'get',
        data: { idCardapio: idcardapio },
    }).done(function (data) {
       
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;

}


function ObjetoHtmlMenuList(cardapio, tituloMenu, ListProduto) {

    var listProdud = null;
    for (var i = 0; i < ListProduto.length; i++) {
        listProdu += '<a class="dropdown-item" href="#">'+ListProduto[i]+'</a>'; 
    }

    var html = '<h4 id="MenuCadapi">' + cardapio + '</h4>' +
        '<div class="card">' +
        '<h5 id="TituloMenu" class="card-header" style="background-color:#ff6a00;">' +
        tituloMenu +
        '</h5>' +
        '<div class="card-body">' +
        '<div class="dropdown show">' +
        '<a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
          'Produtos'+
        '</a>' +
        '<div class="dropdown-Produto" aria-labelledby="dropdownMenuLink">' +
          listProdud
        '</div>' +
        '</div>' +
        '</div>' +
        '</div>';

    return html;
}


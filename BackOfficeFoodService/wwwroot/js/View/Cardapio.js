function CreateListCardapio(idcardapio, tituloCardapio) {

    var idCaradpio = idcardapio;
    var tituloCardapio = tituloCardapio;

    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get',
        cache: false,
        async: true,
    }).done(function (data) {
        $("#modal-body").html(data);
        $("#custId").val(idCaradpio);
        buscaListaCardapio(idcardapio, tituloCardapio);
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
        cache: false,
        async: true,
    }).done(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['description']);
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}

function buscaListaCardapio(idcardapio, tituloCardapio) {

    $.ajax({
        url: "/Cardapio/BuscarMenuListaCardapio",
        type: 'get',
        data: { idCardapio: idcardapio },
        cache: false,
        async: true,
    }).done(function (data) {
        var ListaMenuHtml = ObjetoHtmlMenuList(data);
        $("#ListMenu").html(ListaMenuHtml);
        $("#MenuCadapio").text("Cadápio Selecionado : " + tituloCardapio);
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;

}


function ObjetoHtmlMenuList(cardapio) {
    var listProdud = '';
    var html = '';

    for (var i = 0; i < cardapio['listMenu'].length; i++) {
        for (var j = 0; j < cardapio['listMenu'][i]['listProduto'].length; j++) {
           listProdud += '<a class="dropdown-item" href="#">' + cardapio['listMenu'][i]['listProduto'][j].nome + '</a>';
        }


        html += '<h4 id="MenuCadapio"></h4>' +
            '<div class="card">' +
            '<h5 id="TituloMenu" class="card-header" style="background-color:#ff6a00;">' +
            cardapio['listMenu'][i].titulo +
            '</h5>' +
            '<div class="card-body">' +
            '<p class="card-text">'+cardapio['listMenu'][i].descricao+'</p>'+
            '<div class="dropdown show">' +
            '<a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
            'Produtos' +
            '</a>' +
            '<div class="dropdown-menu" aria-labelledby="dropdownMenuLink">' +
            listProdud +
            '</div>' +
            '</div>' +
            '</div>' +
            '</div>';

    }



    return html;
}


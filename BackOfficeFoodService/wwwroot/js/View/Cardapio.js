var TituloGlobalSalvar = '';

function CreateListCardapio(idcardapio, tituloCardapio) {
    TituloGlobalSalvar = '';
    var idCaradpio = idcardapio;
    var tituloCardapio = tituloCardapio;
    TituloGlobalSalvar = tituloCardapio;

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
        buscaListaCardapio(idcardapio, "");
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
        $("#Menu").html(ListaMenuHtml);
        $("#MenuCadapio").text("Cardápio Selecionado : " + TituloGlobalSalvar);
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;

}


function ExcluirMenuLista(codMenuSeq) {

    $.ajax({
        url: "/Cardapio/DeleteMenuListaCardapio",
        type: 'delete',
        data: { codMenuSeq: codMenuSeq },
        cache: false,
        async: true,
    }).done(function (data) {
        var ListaMenuHtml = ObjetoHtmlMenuList(data);
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
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


        html +=
            '<div class="card">' +
            '<h5 id="TituloMenu" class="card-header" style="background-color:#ff6a00;">' +
            cardapio['listMenu'][i].titulo +
            '</h5>' +
            '<div class="card-body">' +
            '<p class="card-text">' + cardapio['listMenu'][i].descricao + '</p>' +
            '<div class="row">' +
            '<div class="col">' +
            '<div class="dropdown show">' +
            '<a class="btn btn-secondary dropdown-toggle" href="#" role="button" id="dropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
            'Produtos' +
            '</a>' +
            '<div class="dropdown-menu" aria-labelledby="dropdownMenuLink">' +
            listProdud +
            '</div>' +
            '</div>' +
            '</div>' +
            '<div class="col-md-2">' +
            '<button type="button" class="btn btn-primary">Alterar</button>' +
            '</div>' +
            '<div class="col col-lg-2">' +
            '<button type="button" onclick="ExcluirMenuLista('+cardapio['listMenu'][i].codMenuSeq+')" class="btn btn-danger">Excluir</button>' +
            '</div>' +
            '</div>' +
            '</div>' +
            '</div>';

        listProdud = '';

    }



    return html;
}


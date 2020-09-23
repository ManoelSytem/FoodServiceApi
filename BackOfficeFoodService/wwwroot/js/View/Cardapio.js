function CreateListCardapio(idcardapio, tituloCardapio) {

    var idCaradpio = idcardapio;
    var tituloCardapio = tituloCardapio;

    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get'
    }).done(function (data) {
        $("#modal-body").html(data);
        $("#MenuCadapio").text("Cadápio Selecionado : "+tituloCardapio);
    }).fail(function () {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}

function SalveMenuListCardapio() {
    var titulo = $('#tituloMenu').val();
    var descricao = $('#descricao').val();
    var SelectProdutos = $('#SelectProduto').val();
  
    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'post',
        data: { titulo: titulo, descricao: descricao, produtos: SelectProdutos },
    }).done(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['description']);
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}


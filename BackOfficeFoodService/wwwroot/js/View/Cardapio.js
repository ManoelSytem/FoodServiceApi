function CreateListCardapio() {
    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get'
    }).done(function (data) {
        $("#modal-body").html(data);
    });
}

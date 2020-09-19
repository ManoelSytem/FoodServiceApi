function CreateListCardapio() {
    alert("Teste");
    $.ajax({
        url: "/Cardapio/MenuListCardapio",
        type: 'get'
    }).done(function (data) {
        $("#modal-body").html(data);
    });
}

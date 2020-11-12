function BuscarConta() {

    var seqAbreMesa = $("#seqAbreMesa").val();

    $.ajax({
        url: "/Caixa/ObterContaPendente",
        type: 'Get',
        data: { seqAbreMesa: seqAbreMesa },
        cache: false,
        async: true,
    }).done(function (data) {
        var today = new Date();
        if (data != undefined) {
            $("#CupomFiscal").html("");
            $('#seqAbreMesa').val(data['seqAbreMesa']);
            $('#total').val(formatarValorReal(data['total']));
            $('#totalReal').val(data['total']);
            $('#numeroMesa').text("Mesa Número: " + data['seqAbreMesa']);
            $('#DataAbertura').text("Data Hora abertura mesa: " + today.toLocaleString("pt-BR",data['dataAbertura']));
            $('#DataFehamento').text("Data Hora Fechamento mesa: " + today.toLocaleString("pt-BR", data['DataFechamento']));
            $('#CupomFiscal').append(
                '<button onclick="ObterCupomFiscalNovaGuia('+data['seqAbreMesa']+')" type = "button" class= "btn btn-dark" > Cupom Não fiscal</button'
            )

        } else {
            $("#ModalGenric").modal();
            $("#ModalGenric .modal-body").text("Pedido: " + seqAbreMesa + " não encontrado.");
            $("#ModalGenric").on('hide.bs.modal', function () {
                window.location = '/Caixa/ContaAReceber';
            });
        }

    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['responseText']);
    });;
}

function ObterCupomFiscalNovaGuia(seqAbreMesa) {
    window.open('/Caixa/CupomNaoFiscal?seqAbreMesa=' + seqAbreMesa, '_blank');
}

$("#SelectFormaPagamento").change(function () {
    var formaPagamento =  $('#SelectFormaPagamento option:selected').text();

    if (formaPagamento == "Dinheiro") {
        $("#valorEntrada").prop('disabled', false);
    } else {
        $("#valorEntrada").prop('disabled', true);
    }
});

$("#valorEntrada").keyup(function () {

   s if ($("#valorEntrada").val().match(regra) != null && $("#total").val().match(regra) != null) {
        var total = $('#total').val();
        var entrada = $('#valorEntrada').val();
        troco = formatNumber(total) - formatNumber(entrada);
        $('#totalTroco').val(troco);
    } else {
        $('#totalTroco').val("");
    }
});

function formatarValorReal(valor) {
   
    const currencyBRL = (valor) => {
        const formattedValue = valor.toLocaleString(
            'pt-BR',
            { style: 'currency', currency: 'BRL' }
        );

        return formattedValue;
    };

    return currencyBRL;
}

function formatNumber(value) {
    value = convertToFloatNumber(value);
    return value.formatMoney(2, '.', '');
}
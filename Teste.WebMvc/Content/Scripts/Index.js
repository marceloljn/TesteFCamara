$(document).ready(function () {
    if ($("#ExpirationDate").val() != "") {
        start();
    }

    if ($("#ErrorMessage").val() != "") {
        alert($("#ErrorMessage").val());
        $("#ErrorMessage").val("");
    }

    $("#lblToken").text($("#Token").val());

    $('#generateToken').click(function () {
        $.getJSON(Url.GetToken, function (res, status) {
            if (status == "success") {
                $("#lblToken").text(res.Value);
                $("#Token").val(res.Value);
                $("#ExpirationDate").val(new Date(parseInt(res.ExpirationDate.replace('/Date(', ''))));

                start();
            } else {
                alert("Erro ao obter Token");
            }
        });
    });

    jQuery.support.cors = true;

    $('#getProductsAjax').click(function () {
        if ($("#lblExpiracao").text() == "Token Expirado!") {
            alert("Token Expirado, favor requisitar novo Token.");
            return;
        }
        else if ($("#lblExpiracao").text() == "") {
            alert("É necessário requisitar um Token antes.");
            return;
        }

        $.ajax({
            url: Url.GetProductsApi,
            crossDomain: true,
            data: { token: $("#Token").val() },
            dataType: 'json',
            success: function (data) {
                FillTable(data);
            },
            error: function (e) {
                alert("Token Inválido");
            },
            type: 'GET'
        });
    });

    var timer = null;

    function tick() {
        timer = getTimer();
        if (timer < 0) {
            $("#lblExpiracao").text("Token Expirado!");
            stop();
        }
        else
            $("#lblExpiracao").text(timer);
        start();        // restart the timer
    };

    function start() {  // use a one-off timer
        timer = setTimeout(tick, 1000);
    };

    function stop() {
        clearTimeout(timer);
    };

});

function FillTable(obj) {
    $("tbody").children().remove();
    var thtml = '<tbody>';

    $.each(obj, function (key, item) {
        thtml += '<tr>';
        thtml += '  <td>' + item.id_produto + '</td>';
        thtml += '  <td>' + item.nm_produto + '</td>';
        thtml += '  <td>' + item.ds_produto + '</td>';
        thtml += '  <td>' + item.vl_produto.toFixed(2) + '</td>';
        thtml += '</tr>';
    });

    thtml += '</tbody>';

    $(thtml).appendTo($('#table'));
}

function getTimer() {
    var fromTime = new Date(new Date().toISOString());
    var differenceTravel = new Date(new Date($("#ExpirationDate").val()).toISOString()).getTime() - fromTime.getTime();
    var diff = Math.floor((differenceTravel) / (1000));

    return diff;
}
jQuery(function ($){

    $('#DatePicker').datepicker({
        format: "dd/mm/yyyy"
    });

    $("#Placa").mask('aaa-9999');
});

function validarPessoa(tipoPessoa) {
    if (tipoPessoa == "pf") {
        $('#div-cpf').css('display', 'block')
        $('#div-cnpj').css('display', 'none')
    } else {
        $('#div-cnpj').css('display', 'block');
        $('#div-cpf').css('display', 'none');
    }
}

function TestaCPF(strCPF) {
    var Soma;
    var Resto;
    Soma = 0;
    if (strCPF == "00000000000") {
        mostrarErroCpf();
        return;
    };

    for (i = 1; i <= 9; i++) Soma = Soma + parseInt(strCPF.substring(i - 1, i)) * (11 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(strCPF.substring(9, 10))) {
        mostrarErroCpf();
        return;
    }

    Soma = 0;
    for (i = 1; i <= 10; i++) Soma = Soma + parseInt(strCPF.substring(i - 1, i)) * (12 - i);
    Resto = (Soma * 10) % 11;

    if ((Resto == 10) || (Resto == 11)) Resto = 0;
    if (Resto != parseInt(strCPF.substring(10, 11))) {
        mostrarErroCpf();
        return;
    }
    esconderErroCpf();
    return;
}

function mostrarErroCpf() {
    $("#ErroCpf").css("display", "block");
}


function esconderErroCpf() {
    $("#ErroCpf").css("display", "none");
}


$(function () {

    if ($(".lista_modelo option").length <= 1) {
        $(".lista_modelo").parent().parent().hide();
    }

    $(".onChange_Marca_Carro").on("change", function () {
        var id = $(".select_marca option:selected").val();

        if (id > 0) {
            get("http://localhost:56825/api/modelocarro/v1/obterlista/" + id, setSelectOption);
        } else {
            $(".lista_modelo").empty();
            $(".lista_modelo").parent().parent().hide();
        }
    });

});

function setSelectOption(data) {

    $(".lista_modelo").empty();

    $(".lista_modelo").append($('<option>', {
        value: "",
        text: "--Selecione--"
    }));

    if (data.length > 0) {
        $(".lista_modelo").parent().parent().show();
        for (var i = 0; i < data.length; i++) {
            $(".lista_modelo").append($('<option>', {
                value: data[i].Id,
                text: data[i].Nome
            }));
        }
    }
}
$(document).ready(() => {
    console.log('JQuery is loaded.');

    $('#btn-login').click((e) => {
        $('#modalLogin').modal('toggle');
    });

    // Carregar página
    $("#intro-jquery").click((e) => {
        $.ajax({
            url: "introducao-jquery.html",
            context: document.body,
            success: (data, textStatus, xhr) => {
                $("#conteudo").html(data);
            }
        });
    });
});
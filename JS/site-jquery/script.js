$(document).ready(() => {
    $("#btn-next-page").click((e) => {
        $.ajax({
            url: "content.html",
            context: document.body,
            success: (data, textStatus, xhr) => {
                $("#conteudo").html(data);
            }
        });
    });
});
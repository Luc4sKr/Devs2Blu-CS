$(document).ready(() => {
    $("#btn-search").click(() => {
        let input = $("#input-search").val();

        window.location.href = `/results/search/${input}`;


        /*
        $.ajax({
            url: `/results/search/${input}`,
            dataType: "html",
            success: (htmlPartialView) => {
                $('#content-list').html(htmlPartialView);
            }
        });
        */
    });
});
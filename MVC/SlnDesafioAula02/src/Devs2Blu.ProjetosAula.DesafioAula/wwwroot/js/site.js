$(document).ready(() => {

    $("#btn-search").click(() => {
        let input = $("#input-search").val();

        window.location.href = `/results/search/${input}`;
    });

    $(".page-item").click((e) => {
        console.log(e.target.outerText)
        window.location.href = `/results/characters/page/${e.target.outerText}`;
    });
});
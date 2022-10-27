function $(querrySelector) {
    return document.querySelector(querrySelector);
}

addEventListener("load", (e) => {
    $("#item-list-aba1").addEventListener("click", (e) => {
        $("#aba1").style.display = "block";
        $("#aba2").style.display = "none";
        $("#aba3").style.display = "none";
        $("#aba4").style.display = "none";
    });

    $("#item-list-aba2").addEventListener("click", (e) => {
        $("#aba2").style.display = "block";
        $("#aba1").style.display = "none";
        $("#aba3").style.display = "none";
        $("#aba4").style.display = "none";
    });

    $("#item-list-aba3").addEventListener("click", (e) => {
        $("#aba3").style.display = "block";
        $("#aba2").style.display = "none";
        $("#aba1").style.display = "none";
        $("#aba4").style.display = "none";
    });

    $("#item-list-aba4").addEventListener("click", (e) => {
        $("#aba4").style.display = "block";
        $("#aba2").style.display = "none";
        $("#aba3").style.display = "none";
        $("#aba1").style.display = "none";
    });
    
    
});


const URL_API = "https://rickandmortyapi.com/api/character";

$(document).ready((e) => {
    getCharacter();
});


// URL: https://rickandmortyapi.com/api/character
const getCharacter = () => {
    $.ajax({
        url: URL_API,
        dataType: "json",
        success: (data) => {
            let listCharacter = document.createElement("div");
            $(listCharacter).addClass("row");
            $("#getCharacter").html(listCharacter);

            data.results.forEach((character, i) => {
                console.log(character);

                let list = document.createElement("div");
                let card = document.createElement("div");
                let cardHeader = document.createElement("div");
                let cardBody = document.createElement("div");

                $(list).addClass("col-3");

                $(card).addClass("card");
                $(cardHeader).addClass("card-header");
                $(cardBody).addClass("card-body");

                $(cardHeader).attr("id", `character-${i}`);
                $(cardBody).html(`<h1>${character.name}</h1>`)

                $(card).append(cardHeader)
                    .append(cardBody);
                
                $(list).append(card);
                $(listCharacter).append(list);

                getImg(character.url, `#character-${i}`)
            });
        }
    });
} 

const getImg = (url, target) => {
    return $.ajax({
        url: url,
        dataType: "json",
        success: (data) => {
            let dataHtml = document.createElement("img");

            $(dataHtml).addClass("card-img-top");
            $(dataHtml).attr("src", data.image);
            $(dataHtml).css({
                width: "256px"
            });
            $(target).append(dataHtml);
        }
    });
}
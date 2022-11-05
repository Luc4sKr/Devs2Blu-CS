const URL_API = "https://rickandmortyapi.com/api/character";

$(document).ready((e) => {
    getCharacter();
});


const getCharacter = () => {
    $.ajax({
        url: URL_API,
        dataType: "json",
        success: (data) => {

            let listCharacter = document.createElement("div");
            $(listCharacter).addClass("row d-flex justify-content-center align-items-center");
            $("#getCharacter").html(listCharacter);

            data.results.forEach((character, i) => {
                let card = document.createElement("div");
                let row = document.createElement("div");
                let columnImg = document.createElement("div");

                $(card).addClass("card m-2 p-0");
                $(card).css({
                    maxWidth: "540px"
                })

                $(row).addClass("row g-0");
                $(columnImg).addClass("col-md-4");
                $(columnImg).attr("id", `character-${i}`);
                getImg(character.url, `#character-${i}`);
                $(row).append(columnImg);

                let columnBody = document.createElement("div");
                $(columnBody).addClass("col-md-8");

                let cardBody = document.createElement("div");
                $(cardBody).addClass("card-body p-4 pb-2 pt-3");
                $(columnBody).append(cardBody);

                let title = document.createElement("h5");
                $(title).addClass("card-title");
                $(title).html(`${character.name}`);


                let status = document.createElement("p");
                let species = document.createElement("p");
                let origin = document.createElement("p");

                $(status).html(`Status: ${character.status}`);
                $(species).html(`Species: ${character.species}`);
                $(origin).html(`Origin: ${character.origin.name}`)

                $(cardBody).append(title)
                    .append(status)
                    .append(species)
                    .append(origin);

                $(row).append(columnBody);
                $(card).append(row);
                $(listCharacter).append(card);
            });
        }
    });
}

// URL: https://rickandmortyapi.com/api/character
// const getCharacter = () => {
//     $.ajax({
//         url: URL_API,
//         dataType: "json",
//         success: (data) => {
//             let listCharacter = document.createElement("div");
//             $(listCharacter).addClass("row");
//             $("#getCharacter").html(listCharacter);

//             data.results.forEach((character, i) => {
//                 console.log(character);

//                 let list = document.createElement("div");
//                 let card = document.createElement("div");
//                 let cardHeader = document.createElement("div");
//                 let cardBody = document.createElement("div");

//                 $(list).addClass("col-3");

//                 $(card).addClass("card");
//                 $(cardHeader).addClass("card-header");
//                 $(cardBody).addClass("card-body");

//                 $(cardHeader).attr("id", `character-${i}`);
//                 $(cardBody).html(`<h1>${character.name}</h1>`)

//                 $(card).append(cardHeader)
//                     .append(cardBody);

//                 $(list).append(card);
//                 $(listCharacter).append(list);

//                 getImg(character.url, `#character-${i}`)
//             });
//         }
//     });
// } 

const getImg = (url, target) => {
    return $.ajax({
        url: url,
        dataType: "json",
        success: (data) => {
            let dataHtml = document.createElement("img");

            $(dataHtml).addClass("img-fluid rounded-start");
            $(dataHtml).attr("src", data.image);
            $(dataHtml).css({
                width: "256px"
            });
            $(target).append(dataHtml);
        }
    });
}
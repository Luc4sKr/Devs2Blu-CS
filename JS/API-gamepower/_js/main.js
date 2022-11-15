var listaGames = new Array();

addEventListener("load", function() {
    getAPI(URL_API, listGames);
});

function listGames(data) {
    let main = getElement("main");
    listGames = new Array();

    data.forEach(game => {
        console.log(game);

        let card = document.createElement("div");
        let img = document.createElement("img");
        let cardBody = document.createElement("div");
        let title = document.createElement("h5");
        
        card.classList.add("card", "m-2");
        card.style.width = "18rem";

        img.classList.add("card-img-top");
        img.src = game.image;

        cardBody.classList.add("card-body");

        title.classList.add("card-title", "text-center");
        title.innerText = game.title;

        cardBody.appendChild(title);

        card.appendChild(img);
        card.appendChild(cardBody);

        main.appendChild(card);
    });
}
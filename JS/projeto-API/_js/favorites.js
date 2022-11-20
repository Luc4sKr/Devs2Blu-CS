var listGames = new Array();

addEventListener("load", function () {
    if (!getJsonItem("lista")) {
        getAPI(URL_API, getListGames);
        this.window.location.reload(true);
    }

    listGames = getJsonItem("lista");

    getAPI(getItem("url"), listOfFavs);
});

function listOfFavs(data) {
    data.forEach(game => {
        listGames.forEach(listElement => {
            if (game.id == listElement.id) {
                if (listElement.fav) {

                    let card = document.createElement("div");
                    let img = document.createElement("img");
                    let cardBody = document.createElement("div");
                    let title = document.createElement("h5");
                    let fav = document.createElement("i");

                    card.classList.add("card", "game-card", "m-2", "p-0");
                    card.style.width = "18rem";
                    card.addEventListener("click", function () {
                        showDetails(game);
                    });

                    img.classList.add("card-img-top");
                    img.src = game.thumbnail;

                    cardBody.classList.add("card-body");

                    title.classList.add("card-title", "text-center");
                    title.innerText = game.title;

                    listGames.forEach(listFavElement => {
                        if (game.id == listFavElement.id) {
                            if (listFavElement.fav) {
                                fav.classList.add("fav", "fa-solid", "fa-heart");
                            } else {
                                fav.classList.add("fav", "fa-regular", "fa-heart");
                            }
                        }
                    });

                    fav.addEventListener("click", function () {
                        let i = 0;
                        listGames.forEach(listFavElement => {
                            if (game.id == listFavElement.id) {
                                if (listFavElement.fav) {
                                    listGames[i].fav = false;
                                    fav.className = "";
                                    fav.classList.add("fav", "fa-regular", "fa-heart");
                                } else {
                                    listGames[i].fav = true;
                                    fav.className = "";
                                    fav.classList.add("fav", "fa-solid", "fa-heart");
                                }
                            }
                            i++;
                            setJsonItem("lista", listGames);
                        });
                    });

                    cardBody.appendChild(title);
                    cardBody.appendChild(fav)

                    card.appendChild(img);
                    card.appendChild(cardBody);

                    getElement("main").appendChild(card);
                }
            }
        });
    });
}
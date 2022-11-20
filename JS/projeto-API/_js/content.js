var listGames = new Array();

addEventListener("load", function () {
    getAPI(getItem("url"), listOfGames);

    if (!getJsonItem("lista")) {
        getAPI(URL_API, getListGames);
        this.window.location.reload(true);
    }

    listGames = getJsonItem("lista");
});

// Lista os jogos no HTML
function listOfGames(data) {
    let main = getElement("main");

    data.forEach(game => {
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

        listGames.forEach(listElement => {
            if (game.id == listElement.id) {
                if (listElement.fav) {
                    fav.classList.add("fav", "fa-solid", "fa-heart");
                } else {
                    fav.classList.add("fav", "fa-regular", "fa-heart");
                }
            }
        });

        fav.addEventListener("click", function () {
            let i = 0;
            listGames.forEach(listElement => {
                if (game.id == listElement.id) {
                    if (listElement.fav) {
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

        main.appendChild(card);
    });
}

function listComments(id) {
    let html = "";
    getJsonItem("lista").forEach(element => {
        if (element.id == id) {
            element.comments.forEach(comment => {
                let CardComment = `
                    <div class="card m-4 mt-0">
                        <div class="content m-3">
                            <p class="content-text">
                                ${comment}
                            </p>
                        </div>
                    </div>
                `;

                html += CardComment;
            });

            getElement("#comments").innerHTML = html;

            return;
        }
    });
}

// Guarda no localstorage uma lista com todos os jogos
function getListGames(element) {
    let tempList = [];

    element.forEach(game => {
        tempList.push({ "id": game.id, "game": game.title, "fav": false, "comments": [] });
    });

    setJsonItem("lista", tempList);
}
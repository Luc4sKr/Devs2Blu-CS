var listCommentGames = new Array();

addEventListener("load", function () {
    getAPI(getItem("url"), listOfGames);

    if (!getJsonItem("lista")) {
        getAPI(URL_API, getListGames);
        this.window.location.reload(true);
    }

    listCommentGames = getJsonItem("lista");
});

function listOfGames(data) {
    let main = getElement("main");

    data.forEach(game => {
        // console.log(game);

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

        fav.classList.add("fav", "fa-regular", "fa-heart");

        cardBody.appendChild(title);
        cardBody.appendChild(fav)

        card.appendChild(img);
        card.appendChild(cardBody);

        main.appendChild(card);
    });
}

function showDetails(element) {
    getElement("#modal-body").innerHTML = "";

    let cardBody = `
        <div id="c-${element.id}" class="card col-12 my-4">
            <div id="" class="card-header bg-white">
                <img class="card-img-top" src="${element.thumbnail}" alt="${element.title} Image">
            </div>
            <div class="card-body">
                <h1 class="text-center">${element.title}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item text-center">${element.short_description}</li>
                        <li class="list-group-item ">Genre: ${element.genre}</li>
                        <li class="list-group-item ">Publisher: ${element.publisher}</li>
                        <li class="list-group-item ">Developer: ${element.developer}</li>
                        <li class="list-group-item ">Relase Date: ${element.relase_date}</li>
                    </ul>
                </article>
            </div>
        </div>
    `;

    getElement("#modal-body").innerHTML = cardBody;
    $("#gameModal").modal("show");

    // Lista os comentários
    listComments(onlyNumbers(getElement(`#c-${element.id}`).id))

    getElement("#btn-comment").addEventListener("click", function(e) {
        e.preventDefault();

        let i = 0;
        listCommentGames.forEach(comment => {
            if (comment.id == onlyNumbers(getElement(`#c-${element.id}`).id)) {
                comment.comments.push(getElement("#text-area-comment").value);
                getElement("#text-area-comment").value = "";

                listCommentGames[i].comments = comment.comments
                setJsonItem("lista", listCommentGames);
                listComments(comment.id);
            }

            i++;
        });
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
        tempList.push({ "id": game.id, "game": game.title, "fav": false, "comments": []});
    });

    setJsonItem("lista", tempList);
}
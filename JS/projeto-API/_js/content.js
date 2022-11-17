addEventListener("load", function() {
    getAPI(getItem("url"), listGames)
});

function listGames(data) {
    let main = getElement("main");
    listGames = new Array();

    data.forEach(game => {
        // console.log(game);

        let card = document.createElement("div");
        let img = document.createElement("img");
        let cardBody = document.createElement("div");
        let title = document.createElement("h5");
        
        card.classList.add("card", "game-card", "m-2", "p-0");
        card.style.width = "18rem";
        card.addEventListener("click", function() {
            showDetails(game);
        });

        img.classList.add("card-img-top");
        img.src = game.thumbnail;

        cardBody.classList.add("card-body");

        title.classList.add("card-title", "text-center");
        title.innerText = game.title;

        cardBody.appendChild(title);

        card.appendChild(img);
        card.appendChild(cardBody);

        main.appendChild(card);
    });
}

function showDetails(element) {
    getElement("#modal-body").innerHTML = "";

    let cardBody = `
        <div class="card col-12 my-4">
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
        </div>`;

        getElement("#modal-body").innerHTML = cardBody ;
        $("#gameModal").modal("show");
}
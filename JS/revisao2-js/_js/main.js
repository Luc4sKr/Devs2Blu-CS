var listCharacter = new Array();

addEventListener("load", function () {
    getAPI(URL_API_CHARACTER, criaListaCharacter);
});

const criaListaCharacter = (data) => {
    let main = getElement("main");
    listCharacter = new Array();

    data.results.forEach(character => {
        let html = document.createElement("div");
        html.classList.add("character-card", "card", "col-3", "my-4");
        html.addEventListener("click", () => {
            showDetailsCharacter(character);
        });

        let htmlBody = `
            <div id="" class="card-header bg-white">
                <img class="card-img-top" src="${character.image}" alt="${character.name} Image">
            </div>
            <div class="card-body">
                <h1 class="text-center">${character.name}</h1>
            </div>
                        `;

        html.innerHTML = htmlBody;
        main.appendChild(html);
        listCharacter.push(character);
    });
}

const newElement = (tag, contentValue = null, id = null, className = null) => {
    return `
        <${tag} id="${id}" class="${className}">${contentValue}</${tag}>
    `;
}

const showDetailsCharacter = (character) => {
    let div = document.createElement("div");
    getElement("#modal-body").innerHTML = "";
    div.classList.add("card", "cold-12", "my-4");

    let cardBody = `
        <div class="card col-12 my-4">
            <div id="" class="card-header bg-white">
                <img class="card-img-top" src="${character.image}" alt="${character.name} Image">
            </div>
            <div class="card-body">
                <h1 class="text-center">${character.name}</h1>
                <article>
                    <ul class="list-group">
                        <li class="list-group-item">Status: ${character.status}</li>
                        <li class="list-group-item">Species: ${character.species}</li>
                        <li class="list-group-item">Type: ${character.type}</li>
                        <li class="list-group-item">Gender ${character.gender}</li>
                        <li class="list-group-item">Origin: ${character.origin.name}</li>
                        <li class="list-group-item">Location: ${character.location.name}</li>
                        <li class="list-group-item">Url: ${character.url}</li>
                        <li class="list-group-item">Created: ${character.created}</li>
                    </ul>
                </article>
            </div>
        </div>`;

        div.innerHTML = cardBody;
        getElement("#modal-body").appendChild(div);
        $("#characterModal").modal("show");
}
addEventListener("load", function () {
    getInfo();
});

function getInfo() {
    let url = `${URL_API_BY_ID}/${getJsonItem("game")}`;

    getAPI(url, createCard);
}

function createCard(game) {
    console.log(game);

    let html = document.createElement("div");
    let title = document.createElement("h1");
    let figure = document.createElement("figure");
    let img = document.createElement("img");
    let cardBody = document.createElement("div");
    let description = document.createElement("p");
    let gameInformations = document.createElement("div")
    let genre = document.createElement("p");
    let publisher = document.createElement("p");
    let developer = document.createElement("p");
    let relaseDate = document.createElement("p");
    let msrContainer = document.createElement("div"); // Minimum system requirements container
    let msrFlex = document.createElement("div");
    let colapse = document.createElement("div");
    let colapseCard = document.createElement("div");
    let os = document.createElement("p");
    let processor = document.createElement("p");
    let memory = document.createElement("p");
    let graphics = document.createElement("p");
    let storage = document.createElement("p");
    let images = document.createElement("div");
    let imageTitle = document.createElement("h2");
    let imageRow = document.createElement("row");
    game.screenshots.forEach(image => {
        console.log(image);
        img = document.createElement("img");
        img.src = image.image;
        img.style.width = "28rem";
        img.classList.add("m-2")
        imageRow.appendChild(img)
    });

    html.classList.add("card", "card-desc");

    title.classList.add("text-center");
    title.innerText = game.title;

    figure.classList.add("d-flex", "justify-content-center");
    img.src = game.thumbnail;
    img.alt = `${game.title} tumbnail`;

    cardBody.classList.add("card-body");

    description.classList.add("description");
    description.innerText = game.description;

    gameInformations.classList.add("game-informations");
    genre.innerText = `Genre: ${game.genre}`;
    publisher.innerText = `Publisher: ${game.publisher}`;
    developer.innerText = `Developer: ${game.developer}`;
    relaseDate.innerText = `Relase date: ${game.relate_date}`;

    msrContainer.classList.add("msr-container");
    msrFlex.classList.add("d-flex", "justify-content-center", "m-2");
    msrFlex.innerHTML = `
    <button class="btn btn-primary" type="button" data-bs-toggle="collapse"
        data-bs-target="#requirements" aria-expanded="false" aria-controls="requirements">
        Minimum system requirements
    </button>
    `;
    colapse.id = "requirements";
    colapse.classList.add("collapse");

    colapseCard.id = "msr-card";
    colapseCard.classList.add("card");
    os.innerText = `OS: ${game.minimum_system_requirements.os}`;
    processor.innerText = `Processor: ${game.minimum_system_requirements.processor}`;
    memory.innerText = `Memory: ${game.minimum_system_requirements.memory}`;
    graphics.innerText = `Graphics: ${game.minimum_system_requirements.graphics}`;
    storage.innerText = `Storage: ${game.minimum_system_requirements.storage}`;

    images.id = "images";

    imageTitle.innerText = "Images";
    imageTitle.classList.add("text-center", "p-2");

    imageRow.classList.add("row", "justify-content-center");

    

    // Juntando os elementos
    figure.appendChild(img);

    gameInformations.appendChild(genre);
    gameInformations.appendChild(publisher);
    gameInformations.appendChild(developer);
    gameInformations.appendChild(relaseDate);

    msrContainer.appendChild(msrFlex);
    msrContainer.appendChild(colapse);
    colapse.appendChild(colapseCard);
    colapseCard.appendChild(os);
    colapseCard.appendChild(processor);
    colapseCard.appendChild(memory);
    colapseCard.appendChild(graphics);
    colapseCard.appendChild(storage);

    cardBody.appendChild(description);
    cardBody.appendChild(gameInformations);
    cardBody.appendChild(msrContainer);

    images.appendChild(imageTitle);
    images.appendChild(imageRow);

    html.appendChild(title);
    html.appendChild(figure);
    html.appendChild(cardBody);

    getElement("#info").appendChild(html);
    getElement("#main-info").appendChild(images);
}
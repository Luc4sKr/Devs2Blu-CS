// Configs
const URL_API = "https://free-to-play-games-database.p.rapidapi.com/api/games";

const options = {
    method: 'GET',
    headers: {
        'X-RapidAPI-Key': '82f54b1863msha3da5df08279e2cp1e6b1djsn5664b20ca509',
        'X-RapidAPI-Host': 'free-to-play-games-database.p.rapidapi.com'
    }
}

// Functions
function getElement(element) {
    return document.querySelector(element);
}

function getAPI(url, functionCallback) {
    fetch(url, options).then(
        response => response.json(),
        error => console.log(error)
    ).then(
        dataJson => functionCallback(dataJson),
        error => console.log(error)
    );
}

function setGameId(gameId) {
    setJsonItem("game", gameId);
    window.location.href = "details.html";
}

function onlyNumbers(string) {
    var numsStr = string.replace(/[^0-9]/g, '');
    return parseInt(numsStr);
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

    getElement("#btn-comment").addEventListener("click", function (e) {
        e.preventDefault();

        let i = 0;
        listGames.forEach(comment => {
            if (comment.id == onlyNumbers(getElement(`#c-${element.id}`).id)) {
                comment.comments.push(getElement("#text-area-comment").value);
                getElement("#text-area-comment").value = "";

                listGames[i].comments = comment.comments
                setJsonItem("lista", listGames);
                listComments(comment.id);
            }

            i++;
        });
    });
}
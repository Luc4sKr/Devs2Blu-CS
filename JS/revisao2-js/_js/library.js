// Configs
const URL_API_CHARACTER = "https://rickandmortyapi.com/api/character/";

// Functions
function getElement(q) {
    return document.querySelector(q);
}

function getAPI(url, functionCallback) {
    fetch(url).then(response => response.json(), // resolve (retorno OK)
        (error) => console.log(error)            // reject (erro retorno)
        ).then(
            dataJson => functionCallback(dataJson),  // resolve (retorno OK)
            erro => console.log(erro));              // reject (erro retorno)
}

function getLista() {

}

// Services

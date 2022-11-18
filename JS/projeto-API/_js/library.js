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
    var numsStr = string.replace(/[^0-9]/g,'');
    return parseInt(numsStr);
}
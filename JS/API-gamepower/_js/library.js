// Configs
const URL_API = "https://gamerpower.p.rapidapi.com/api/giveaways";


const options = {
    method: "GET",
    headers: {
        'X-RapidAPI-Key': '82f54b1863msha3da5df08279e2cp1e6b1djsn5664b20ca509',
        'X-RapidAPI-Host': 'gamerpower.p.rapidapi.com'
    }
};

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


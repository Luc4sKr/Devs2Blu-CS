/*
 * LocalStorage
*/

const KEY_LISTA_PKMN = "LISTA_POKEMON";
const KEY_POKEMON_FAVORITO = "POKEMON_FAVORITO";
const KEY_MEUS_POKEMONS = "MEUS_POKEMONS";

const stg = {
    set: (key, value) => {
        localStorage.setItem(key, value);
    },
    get: (key) => {
        return localStorage.getItem(key);
    },
    setJosn: (key, value) => {
        let objStr = JSON.stringify(value);
        localStorage.setItem(key, objStr);
    },
    getJson: (key) => {
        return JSON.parse(localStorage.getItem(key));
    },
    del: (key) => {
        localStorage.removeItem(key);
    }
}


/**
 * Services APIs
 */

const URL_API_PKMN = 'https://pokeapi.co/api/v2/pokemon/';

const getAPI = (url, fnCallBack) => {
    $.ajax({
        url: url,
        dataType: 'json',
        success: (data) => fnCallBack(data)
    });
}

const getInfoAPIPromise = async (url) => {
    return fetch(url)
        .then(resp => resp.json());
}

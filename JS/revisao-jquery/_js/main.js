$(document).ready(() => {
    // Inicializa parâmetros do sistema
    init();
});

const init = () => {
    // Carregar Views
    getView('home', '#root');

    // Carregar Servicos
    initializeServices();

    // Carregar Eventos
    initializeEvents();
}

const initializeEvents = () => {
    // # Meus Pokemons
    $('#pag-meus-pokemons').click(() => getView('meus-pokemons', '#root'));

    // Botao Pesquisar
    $('#btn-pesquisa').click((e) => {
        e.preventDefault();
        let valorPesquisa = $('#input-pesquisa').val();
        //realizar pesquisa
    });
}

const initializeServices = () => {
    // Carregar/armazenar pokemons da API
    atualizarListaPKMNStorage();
    
    // * Destaques
    getAPI(URL_API_PKMN, fillDestaques);
}
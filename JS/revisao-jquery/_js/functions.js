/*
 * Functions de apoio
*/

var listaPokemons = new Array();

const getView = (viewName, target) => {
    let ajaxConfig = {
        url: `_views/${viewName}.html`,
        dataType: 'html',
        success: (response) => {
            $(target).html(response);
        }
    };

    $.ajax(ajaxConfig);
}

const fillDestaques = (data) => {
    data.results.forEach((p, i) => {
        if (i > 3)
            return;

        let item = document.createElement('div');
        item.classList.add('col-3');
        $(item).html(`
            <div class="card">
                <div class="card-header bg-danger">
                    <h3 class="text-white text-center">${p.name}</h3>
                </div>
                <div class="card-body">
                    <p class="text-center">
                        <a href="${p.url}">URL do ${p.name}</a>
                    </p>
                </div>
            </div>
        `);
        $('#destaque').append(item);
    });
}

const atualizarListaPKMNStorage = (force=false) => {
    if (!VerificarAtualizacaoLista() && !force) {
        return;
    }

    listaPokemons = new Array();
    getAPI(URL_API_PKMN, (data) => {
        // Percorre a lista de pokemons n propriedade results
        data.results.forEach((p) => {
            getInfoAPIPromise(p.url).then((objPokemon) => {
                let pkmn = {
                    id: objPokemon.id,
                    name: objPokemon.name,
                    url: p.url,
                    img: objPokemon.sprites.front_default
                }

                listaPokemons.push(pkmn);

                // Atualiza lista no localStorage
                stg.setJosn(KEY_LISTA_PKMN, listaPokemons);
            });
        });
    });
}

const VerificarAtualizacaoLista = () => {
    let listaPkmn = stg.getJson(KEY_LISTA_PKMN);
    if (listaPkmn && listaPkmn.lenght > 0) {
        return true;
    } else {
        return false;
    }
}
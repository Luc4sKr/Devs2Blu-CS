$(document).ready((e => {
    listarFilmes();
    atualizaValorNota();

    $("#btn-enviar").click((e) => {
        if (getJsonItem(LISTA_FILMES) || getJsonItem(LISTA_FILMES) <= 0) {
            listaFilmes = getJsonItem(LISTA_FILMES);
        }

        listaFilmes = new Array();
        listaFilmes.push(getFilme())
        setJsonItem(LISTA_FILMES, listaFilmes)

        listarFilmes();
    });
}));


function atualizaValorNota() {
    $("#nota").html(
        $("#input-nota").val()
    );
    $("#input-nota").change(() => {
        $("#nota").html(
            $("#input-nota").val()
        );
    });
}

function getFilme() {
    let tamLista = getJsonItem(LISTA_FILMES) == null ? 0 : getJsonItem(LISTA_FILMES).length;
    let idInsert = tamLista + 1;
    return new Filme(idInsert, $("#input-titulo").val(), $("#input-nota").val(), $("#input-descricao").val());
}

function listarFilmes() {
    let listHTML = $("#lista-filmes");
    listHTML.html("");

    console.log(getJsonItem(LISTA_FILMES))

    if (getJsonItem(LISTA_FILMES) == null ||
        getJsonItem(LISTA_FILMES).length <= 0) {
        return false;
    }
    
    getJsonItem(LISTA_FILMES).forEach((filme) => {
        let row = document.createElement("tr");
        var colID = document.createElement("td");
        var colTitulo = document.createElement("td");
        var ColNota = document.createElement("td");
        var ColActions = document.createElement("td");
        $(ColActions).html(
            `<div class="d-flex">
                    <button onclick="removeItemList(${filme.id})" class="btn btn-sm btn-danger">&times;</button>
                </div>`
        );

        $(colID).html(filme.id);
        $(colTitulo).html(filme.titulo);
        $(ColNota).html(filme.nota);
        $(row).append(colID)
            .append(colTitulo)
            .append(ColNota)
            .append(ColActions);
        listHTML.append(row);
    });
}

function removeItemList(id) {
    let i = getJsonItem(LISTA_FILMES).findIndex((filme) => filme.id === id);
    listaFilmes = getJsonItem(LISTA_FILMES);
    listaFilmes.splice(i, 1);

    setJsonItem(LISTA_FILMES, listaFilmes);
    console.log()
    listarFilmes();
}
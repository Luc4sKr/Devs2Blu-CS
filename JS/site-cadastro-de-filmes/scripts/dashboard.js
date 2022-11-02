var listaFilmes = getListaFilmes(USER_LOGADO);

$(document).ready((e => {
    listarFilmes();
    atualizaValorNota();

    $("#btn-enviar").click((e) => {
        if (getListaFilmes(USER_LOGADO) ||
            getListaFilmes(USER_LOGADO) <= 0) {
            listaFilmes = getListaFilmes(USER_LOGADO);
        }

        listaFilmes.push(getFilme())
        var usuario = getJsonItem(USER_LOGADO);
        usuario.listaFilmes = listaFilmes;
        setJsonItem(USER_LOGADO, usuario);

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
    let tamLista = getJsonItem(USER_LOGADO).listaFilmes == null ? 0 : getJsonItem(USER_LOGADO).listaFilmes.length;
    let idInsert = tamLista + 1;
    return new Filme(idInsert, $("#input-titulo").val(), $("#input-nota").val(), $("#input-descricao").val());
}

function listarFilmes() {
    let listHTML = $("#lista-filmes");
    listHTML.html("");

    if (getListaFilmes(USER_LOGADO) == null ||
        getListaFilmes(USER_LOGADO) <= 0) {
        return false;
    }

    getListaFilmes(USER_LOGADO).forEach((filme) => {
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
    let i = getListaFilmes(USER_LOGADO).findIndex((filme) => filme.id === id);
    listaFilmes = getListaFilmes(USER_LOGADO);
    listaFilmes.splice(i, 1);

    var usuario = getJsonItem(USER_LOGADO);
    usuario.listaFilmes = listaFilmes;
    setJsonItem(USER_LOGADO, usuario);
    listarFilmes();
}
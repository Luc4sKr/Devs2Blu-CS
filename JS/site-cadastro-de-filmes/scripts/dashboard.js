

$(document).ready((e => {
    console.log(getJsonItem(USER_LOGADO))
    if (!getJsonItem(USER_LOGADO)) {
        window.location.href = "../index.html"
    }

    var listaFilmes = getListaFilmes(USER_LOGADO);

    listarFilmes();
    atualizaValorNota();

    $("#btn-enviar").click((e) => {
        if (getListaFilmes(USER_LOGADO) ||
            getListaFilmes(USER_LOGADO) <= 0) {
            listaFilmes = getListaFilmes(USER_LOGADO);
        }

        try {
            listaFilmes.filmes.push(getFilme());
        } catch {
            listaFilmes.push(getFilme());
        }

        var usuario = getJsonItem(USER_LOGADO);
        usuario.listaFilmes = listaFilmes;
        setJsonItem(USER_LOGADO, usuario);

        listarFilmes();
        updateUsuarios(LISTA_USUARIOS, usuario);
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
    console.log(getListaFilmes(USER_LOGADO).filmes.length)
    // let tamLista = getListaFilmes(USER_LOGADO).filmes.length == 0 ? 0 : getJsonItem(USER_LOGADO).listaFilmes.length;
    
    let idInsert = getListaFilmes(USER_LOGADO).filmes.length + 1;
    return new Filme(idInsert, $("#input-titulo").val(), $("#input-nota").val(), $("#input-descricao").val());
}

function listarFilmes() {
    let listHTML = $("#lista-filmes");
    listHTML.html("");

    if (getListaFilmes(USER_LOGADO) == null ||
        getListaFilmes(USER_LOGADO) <= 0) {
        return false;
    }

    console.log(getListaFilmes(USER_LOGADO).filmes)
    getListaFilmes(USER_LOGADO).filmes.forEach((filme) => {
        let row = document.createElement("tr");
        var colID = document.createElement("td");
        var colTitulo = document.createElement("td");
        var colNota = document.createElement("td");
        var colDesc = document.createElement("td");
        var colActions = document.createElement("td");

        $(colActions).html(
            `<div class="d-flex">
                    <button onclick="removeItemList(${filme.id})" class="btn btn-sm btn-danger">&times;</button>
                </div>`
        );

        $(colID).html(filme.id);
        $(colTitulo).html(filme.titulo);
        $(colNota).html(filme.nota);
        $(colDesc).html(filme.descricao);
        $(row).append(colID)
            .append(colTitulo)
            .append(colNota)
            .append(colDesc)
            .append(colActions);
        listHTML.append(row);
    });
}

function removeItemList(id) {
    let i = getListaFilmes(USER_LOGADO).filmes.findIndex((filme) => filme.id === id);
    listaFilmes = getListaFilmes(USER_LOGADO);
    listaFilmes.filmes.splice(i, 1);

    var usuario = getJsonItem(USER_LOGADO);
    usuario.listaFilmes = listaFilmes;
    setJsonItem(USER_LOGADO, usuario);
    listarFilmes();
}
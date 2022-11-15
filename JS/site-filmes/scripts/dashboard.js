$(document).ready((e => {
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
    let idInsert = getListaFilmes(USER_LOGADO).filmes.length + 1;
    return new Filme(idInsert, $("#input-titulo").val(), $("#input-image"), $("#input-nota").val(), $("#input-descricao").val());
}

function listarFilmes() {
    let listHTML = $("#lista-filmes");
    listHTML.html("");

    if (getListaFilmes(USER_LOGADO) == null ||
        getListaFilmes(USER_LOGADO) <= 0) {
        return false;
    }

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

    updateEventClick();
}

function removeItemList(id) {
    let i = getListaFilmes(USER_LOGADO).filmes.findIndex((filme) => filme.id === id);
    listaFilmes = getListaFilmes(USER_LOGADO);
    listaFilmes.filmes.splice(i, 1);

    var usuario = getJsonItem(USER_LOGADO);
    usuario.listaFilmes = listaFilmes;
    setJsonItem(USER_LOGADO, usuario);
    listarFilmes();
    updateUsuarios(LISTA_USUARIOS, usuario);
}

function updateEventClick() {
    $("tr").click((e) => {
        let tr = $(e.target.parentElement);
        let regLinha = tr.find("td");

        $("#id").val($(regLinha[0]).html());
        $("#input-titulo").val($(regLinha[1]).html());
        $("#input-nota").val($(regLinha[2]).html());
        $("#input-descricao").val($(regLinha[3]).html());
    });
}
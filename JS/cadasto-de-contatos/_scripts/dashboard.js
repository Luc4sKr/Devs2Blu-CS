var listaContatos = new ListaContatos()

$(document).ready(() => {
    if (!verificaLogin()) {
        window.location.href = "../index.html";
    }

    if (getListaContatos()) {
        listarContatos();
    }

    $("#btn-cadastrar").click((e) => {
        addContato();
        listarContatos();
    });

    $("#btn-logof").click((e) => {
        realizaLogoff();
    });
});

// Functions
const listarContatos = () => {
    $("#lista-contatos").children().remove();
    JSON.parse(getListaContatos()).contatos.forEach((contato) => {
        var linha = document.createElement('tr');
        var colNome = document.createElement('td');
        var colEmail = document.createElement('td');

        $(colNome).html(contato.nome);
        $(colEmail).html(contato.email);
        $(linha).append(colNome).append(colEmail);
        $("#lista-contatos").append(linha);
    });
}

function addContato() {
    var contato = new Contato(
        $("#input-nome").val(), $("#input-email").val()
    );

    if (getListaContatos()) {
        listaContatos.contatos = JSON.parse(getListaContatos()).contatos;
    }

    listaContatos.contatos.push(contato);
    localStorage.setItem("listaContatos", JSON.stringify(listaContatos));
}

function getListaContatos() {
    return localStorage.getItem("listaContatos");
}
const listaContatos = [];
listaContatos.push({nome: "Lucas", email:"lucas@gmail.com"})

const listarContatos = () => {
    listaContatos.forEach((c) => {
        var linha = document.createElement('tr');
        var colNome = document.createElement('td');
        var colEmail = document.createElement('td');

        $(colNome).html(c.nome);
        $(colEmail).html(c.email);
        $(linha).append(colNome).append(colEmail);
        $('#lista-contatos').append(linha);
    });
}

$(document).ready(() => {
    if (!verificaLogin()) {
        window.location.href = "../index.html";
    }

    listarContatos();
});
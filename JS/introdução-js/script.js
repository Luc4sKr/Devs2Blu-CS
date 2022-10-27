// Variáveis
const URL_VIACEP = "https://viacep.com.br/ws/@CEP/json/";

// Carregar a página
addEventListener("load", (e) => {
    console.log("Sistema carregado...");

    // Regista evento
    $("#cep").addEventListener("blur", (e) => {
        var valorCampo = e.target.value;
        console.log(`Valor: ${valorCampo}`);

        if (valorCampo.length >= 8) {
            $("#endereco").style.display = 'block';
            var urlCep = URL_VIACEP.replace("@CEP", valorCampo);
            getJson(urlCep).then((resp) => {
                console.log(resp);
                $("#rua").value = resp.logradouro;
                $("#bairro").value = resp.bairro;
                $("#cidade").value = resp.localidade;
                $("#uf").value = resp.uf;

                $("#numero").focus();
            });
        }
    });

    $("#btn-salvar").addEventListener("click", (e) => {
        console.log("click");
    });
});

const validaFormulario = () => {
    if ($("nome").value === "") {
        return false;
    }
}

function getJson(url) {
    return fetch(url).then((resposta) => resposta.json());
}

function $(querrySelector) {
    return document.querySelector(querrySelector);
}


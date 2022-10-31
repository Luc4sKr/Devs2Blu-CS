const LOGADO = "userLogado";
const USER = "user";

$(document).ready(() => {
    // <Modal>
    $(".btn-login").click((e) => {
        $("#modal-login").modal("toggle");
    });

    $(".btn-cadastro").click((e) => {
        $("#modal-cadastro").modal("toggle");
    });

    $(".bclose").click((e) => {
        $(".modal").modal("hide");
    });
    // </Modal>

    // <Login>
    $("#btn-logar").click((e) => {
        const usuario = new Usuario("", $("#email-login-input").val(), $("#senha-login-input").val());
        console.log( $("#email-login-input").val())
        realizaLogin(usuario);
    });
    // </Login>

    // <Cadastro>
    $("#btn-cadastrar").click((e) => {
        const usuario = new Usuario(
        $("#nome-cadastro-input").val(),
        $("#email-cadastro-input").val(),
        $("#senha-cadastro-input").val());

        insertRegistroStorage(USER, usuario);
        $("#modal-cadastro").modal("hide");
    });
    // </Cadastro>

});

// Functions
const realizaLogin = (user) => {
    localStorage.getItem(USER);

    if ((user.email === JSON.parse(localStorage.getItem(USER)).email) ||
        (user.senha === JSON.parse(localStorage.getItem(USER)).senha)) {
            localStorage.setItem(LOGADO, "true");
            window.location.href = "_html/dashboard.html";
    } 
}

const realizaLogoff = () => {
    localStorage.removeItem(LOGADO);
    window.location.href = "../index.html";
    // localStorage.removeItem(USER);
}

const verificaLogin = () => {
    if (localStorage.getItem(LOGADO) == "true") {
        return true;
    } else {
        return false;
    }
}

const getRegistroStorage = (key) => {
    return localStorage.getItem(key);
}

const insertRegistroStorage = (key, value) => {
    localStorage.setItem(key, JSON.stringify(value));
}
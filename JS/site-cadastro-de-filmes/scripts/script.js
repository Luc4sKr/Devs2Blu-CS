var lista_usuarios = new ListaUsuarios();

$(document).ready((e) => {

    // Index
    $("#index-btn-login").click((e) => {
        window.location.href = "./_views/login.html";
    });

    // Logoff
    $(".btn-logoff").click((e) => {
        removeItem(USER_LOGADO);
        window.location.href = "../index.html";
    });

    // Modal
    $(".btn-login").click((e) => {
        $("#modal-login").modal("toggle");
    });

    $(".btn-cadastro").click((e) => {
        $("#modal-cadastro").modal("toggle");
    });

    $(".bclose").click((e) => {
        $(".modal").modal("hide");
    });

    // Cadastro
    $("#btn-cadastrar").click((e) => {
        if (getJsonItem(LISTA_USUARIOS)) {
            lista_usuarios = getJsonItem(LISTA_USUARIOS);
        }

        let tamLista = lista_usuarios == null ? 0 : lista_usuarios.usuarios.length;
        let idInsert = tamLista + 1;

        let usuario = new Usuario(
            idInsert,
            $("#nome-cadastro-input").val(),
            $("#email-cadastro-input").val(),
            $("#senha-cadastro-input").val()
        );
        

        try {
            lista_usuarios.usuarios.push(usuario);
        } catch {
            lista_usuarios.push(usuario);
        }

        setJsonItem(LISTA_USUARIOS, lista_usuarios);
    });

    // Login
    $("#btn-logar").click((e) => {
        if (getJsonItem(LISTA_USUARIOS)) {
            getJsonItem(LISTA_USUARIOS).usuarios.forEach(user => {
                if ($("#email-login-input").val() === user.email &&
                    $("#senha-login-input").val() === user.senha) {
                    console.log($("#email-login-input"))
                    let usuario_logado = new Usuario(
                        user.id,
                        user.nome,
                        user.email,
                        user.senha
                    );
                    setJsonItem(USER_LOGADO, usuario_logado);
                    $("#modal-login").modal("hide");
                    window.location.href = "../_views/dashboard.html";
                }
            });
        }
    });
});
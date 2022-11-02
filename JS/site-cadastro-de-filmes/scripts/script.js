var lista_usuarios = new ListaUsuarios();

$(document).ready((e) => {





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
            lista_usuarios.usuarios = getJsonItem(LISTA_USUARIOS);
        }

        let tamLista = lista_usuarios == null ? 0 : lista_usuarios.usuarios.length;
        let idInsert = tamLista + 1;

        let usuario = new Usuario(
            idInsert,
            $("#nome-cadastro-input").val(),
            $("#email-cadastro-input").val(),
            $("#senha-cadastro-input").val()
        );



        console.log(lista_usuarios.usuarios)
        lista_usuarios.usuarios.push(usuario);

        setJsonItem(LISTA_USUARIOS, lista_usuarios.usuarios);
    });

    // Login
    $("#btn-logar").click((e) => {
        if (getJsonItem(LISTA_USUARIOS)) {
            getJsonItem(LISTA_USUARIOS).forEach(user => {
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
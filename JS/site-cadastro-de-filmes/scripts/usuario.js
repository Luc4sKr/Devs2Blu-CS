export class Usuario {
    constructor(id, nome, email, senha) {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.senha = senha;
    }
}

export class ListaUsuarios {
    constructor() {
        this.usuarios = new Array();
    }
}
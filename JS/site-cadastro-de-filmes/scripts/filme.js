const LISTA_FILMES = "lista_filmes";

class Filme {
    constructor(id, titulo, nota, descricao) {
        this.id = id;
        this.titulo = titulo;
        this.nota = nota;
        this.descricao = descricao;
    }
}

class ListaFilmes {
    constructor() {
        this.filmes = [];
    }
}
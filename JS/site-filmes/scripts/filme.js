const LISTA_FILMES = "lista_filmes";

class Filme {
    constructor(id, titulo, imagem, nota, descricao) {
        this.id = id;
        this.titulo = titulo;
        this.imagem = imagem;
        this.nota = nota;
        this.descricao = descricao;
    }
}

class ListaFilmes {
    constructor() {
        this.filmes = [];
    }
}
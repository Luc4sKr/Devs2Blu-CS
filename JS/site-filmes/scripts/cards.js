$(document).ready((e) => {
    let i = 4;

    getJsonItem(LISTA_USUARIOS).usuarios.forEach(autor => {
        autor.listaFilmes.filmes.forEach(filme => {

            if (i === 4) {
                sectionCards = document.createElement("section");
                $(sectionCards).addClass("d-flex");
                i = 0;
            }

            $(sectionCards).append(`
                <div class="card-filme card m-1"> 
                    <div class="card-body">
                        <h5>${filme.titulo}</h5>
                        <p>
                            Nota: ${filme.nota}
                        </p>
                        <p>
                            ${filme.descricao}
                        </p>
                        <p>
                            Autor: ${autor.nome}
                        </p>
                    </div>
                </div>
            `);

            $("#index-main").append(sectionCards);
            i++;
        });
    });
});
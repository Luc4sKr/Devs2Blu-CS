const btnInicialElement = document.querySelector("#btn-iniciar");
const btnPausarElement = document.querySelector("#btn-pausar");
const btnResetarElement = document.querySelector("#btn-resetar");

var segundos = 0;
var minutos = 0;
var horas = 0;
var cronometro;

btnInicialElement.addEventListener("click", () => {
    iniciar();
});

btnPausarElement.addEventListener("click", () => {
    pausar();
});

btnResetarElement.addEventListener("click", () => {
    resetar();
})

function iniciar() {
    cronometro = setInterval(() => { timer(); }, 1000)
}

function pausar() {
    clearInterval(cronometro);
}

function resetar() {
    clearInterval(cronometro);
    horas = 0;
    minutos = 0;
    segundos = 0;

    document.querySelector("#time").innerText = "00:00:00";
}


function timer() {
    segundos++;

    if (segundos == 60) {
        segundos = 0;
        minutos++;
        
        if (minutos == 60) {
            minutos = 0;
            horas++;
        }
    }

    var format = `${horas < 10 ? "0" +horas : horas}:${minutos < 10 ? "0"+minutos : minutos}:${segundos < 10 ? "0"+segundos : segundos}`;

    document.querySelector("#time").innerHTML = format;
}





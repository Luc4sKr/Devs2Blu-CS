$(document).ready((e) => {
    console.log("JQuery loaded...");

    $("#nome").val("Lucas");

    $("#btn-salvar").click((e) => {
        e.preventDefault();
        console.log(`Nome ${$("#nome").val()}`);
    });

    $("#email").on("change", (e) => {
        // e.target == $(this);
        //console.log($(this).val());
        var email = e.target.value;
        var valid = String(email)
        .toLowerCase()
        .match();

        if (valid) {
            console.log("Email válido");
        } else {
            console.log("Email inválido");
        }
    });
});
$(document).ready((e) => {
    $("#btn-submit").click((e) => {
        e.preventDefault();

        validateName($("#first-name"));
        validateName($("#last-name"));
        validateEmail($("#email"));
        validatePassword($("#password"));

        
    });
});

function validateName(fname) {
    if (fname.val() === "") {
        fname.addClass("border-error");
    } else {
        fname.removeClass("border-error");
    }
}

function validateEmail(email) {
    var validEmail = String(email.val())
    .toLowerCase()
    .match(
        /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    );
    
    if (!validEmail) {
        email.addClass("border-error");
    } else {
        email.removeClass("border-error");
    }
}

function validatePassword(password) {
    if (password.val().length < 5) {
        password.addClass("border-error");
    } else {
        password.removeClass("border-error");
    }
}
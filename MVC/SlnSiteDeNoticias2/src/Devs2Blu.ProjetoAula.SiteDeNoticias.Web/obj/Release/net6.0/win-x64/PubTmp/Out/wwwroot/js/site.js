$(document).ready(() => {
    console.log("CMS Site");
});

liveToastMessage = (message, origin) => {
    $("#toast-origin").html(origin);
    $("#toast-body").html(message)
    $("#toast-time").html(new Date().toLocaleDateString("pt-BR",
        {
            hour12: false,
            hour: "numeric",
            minute: "numeric"
        }
    ));

    const toastLiveMessages = $("#live-toast");
    const toast = new bootstrap.Toast(toastLiveMessages);

    toast.show();
}
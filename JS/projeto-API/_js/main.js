addEventListener("load", function() {
    getElement("#btn-all").addEventListener("click", function() {
        setItem("url", URL_API);
        window.location.href = "content.html";
    });

    getElement("#btn-mmorpg").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=mmorpg`);
        window.location.href = "content.html";
    });

    getElement("#btn-shooter").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=shooter`);
        window.location.href = "content.html";
    });

    getElement("#btn-strategy").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=strategy`);
        window.location.href = "content.html";
    });

    getElement("#btn-3d").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=3d`);
        window.location.href = "content.html";
    });

    getElement("#btn-2d").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=2d`);
        window.location.href = "content.html";
    });

    getElement("#btn-racing").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=racing`);
        window.location.href = "content.html";
    });

    getElement("#btn-sci-fi").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=sci-fi`);
        window.location.href = "content.html";
    });

    getElement("#btn-actions").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=actions`);
        window.location.href = "content.html";
    });

    getElement("#btn-horror").addEventListener("click", function() {
        setItem("url", `${URL_API}?category=horror`);
        window.location.href = "content.html";
    });
});
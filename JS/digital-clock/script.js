$(document).ready((e) => {
    const clock = setInterval( function time() {
        let date = new Date;

        console.log(date.getSeconds())
        let hour = date.getHours();
        let minutes = date.getMinutes();
        let seconds = date.getSeconds();

        if (hour < 10) {
            hour = "0" + hour;
        }
        if (minutes < 10) {
            minutes = "0" + minutes;
        }
        if (seconds < 10) {
            seconds = "0" + seconds;
        }

        $("#hour").html(hour);
        $("#minutes").html(minutes);
        $("#seconds").html(seconds);
    });
});
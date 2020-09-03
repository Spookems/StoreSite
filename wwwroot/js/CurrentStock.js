
// Currently only works with first button, dive into earlier work required 

$(document).ready(function () {

    $('#expandDetailsButton').click(function () {
               

        $(this.parentElement).css("transition-duration", "0.5s");
        $(this.parentElement).css("height", "500px");


        alert(this.parentElement.id);
    });

});


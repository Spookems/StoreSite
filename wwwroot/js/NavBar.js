window.onscroll = function () { myFunction() };

var navbar = document.getElementById("navbar");
var main = document.getElementById("Main");
var sticky = navbar.offsetTop;

function myFunction() {
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky");
        main.classList.add("stickyMain");
    }
    else {
        navbar.classList.remove("sticky");
    }
}


var TIMEOUT = 12000;

var interval = setInterval(handleNext, TIMEOUT);

function handleNext() {

    var $radios = $('input[class*="slide-radio"]');
    var $activeRadio = $('input[class*="slide-radio"]:checked');

    var currentIndex = $activeRadio.index();
    var radiosLength = $radios.length;

    $radios
        .attr('checked', false);


    if (currentIndex >= radiosLength - 1) {

        $radios
            .first()
            .attr('checked', true);

    } else {

        $activeRadio
            .next('input[class*="slide-radio"]')
            .attr('checked', true);

    }
}
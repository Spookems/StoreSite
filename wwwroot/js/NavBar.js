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
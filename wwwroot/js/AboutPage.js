
$(document).ready(function () {

});

$('#CloseButton').click(function () {
    alert("IN");

    $('#learnMoreJumbo').css("height", "100px");
    $('#learnMorePara').css("visibility", "hidden");

    $(this).toggle();
});


$('#learnMoreButton').click(function ()
{
    $('#learnMoreJumbo').css("height", "302px");
    $('#learnMoreJumbo').css("transition-duration", "0.5s");
    $('#learnMoreJumbo').css("height", "400px");



    $('#learnMorePara').css("visibility", "visible");
    $('#learnMorePara').css("height", "150px;");

    $(this).toggle();
}); 


    //if (toggle === undefined) {
    //    alert('initial');
    //    toggle = 1;
    //}

    //if (toggle = 1)
    //{

    //    $('#learnMoreJumbo').css("height", "400px");

    //    $('#learnMoreButton').css("float", "left");

    //    $('#learnMorePara').css("visibility", "visible");

    //    alert('1');

    //    toggle = 2;
    //}
    //else if (toggle = 2)
    //{

    //    $('#learnMoreJumbo').css("height", "200px");

    //    $('#learnMoreButton').css("float", "left");

    //    $('#learnMorePara').css("visibility", "hidden");

    //    alert('2');

    //    toggle = 1;
    //}
    
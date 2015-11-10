$().ready(function(){
    $("#body_color").change(function () {
        $(this).css("background-color", $(this).val());        
    });

    $("option").css("background-color", function () { return $(this).val() });

});



$(document).ready(function () {
    alert('ad');
    // add in a action result for the buttons
    $('body').on('click', '.ajax-link', function () {
        //get the url.action for this button
        var url = $(this).data('url');
        
        // do the ajax get request
        $.get(url, function (data) {
            //made the rewuest, do something with that
            $('.content').html(data);
        })
    });

});
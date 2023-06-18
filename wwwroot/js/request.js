$(document).ready(function () {
    var skipCourse = 3;

    $(document).on('click', '#loadCourse', function () {
        console.log('salam')
        var courseCount = $('#courseCount').val()
        $.ajax({
            url: "/course/loadcourses?skip=" + skipCourse,
            type: "GET",

            success: function (response) {
                $('#courseRow').append(response)
                skipCourse += 3;

                if (skipCourse >= courseCount)
                    $('#loadCourse').remove()
            },

            error: function (xhr) {

            }
        });
    })
});


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

/*Search*/

$(documnet).on('keyup', '#input-search', function () {

    var searchedCourseTitle = $(this).val()

    $.ajax({
        url: '/Course/search?searchedCourseTitle=${searchedCourseTitle}',
        type: "GET",

        success: function (response) {
            console.log("hgj");
            $('#searchedCourseTitle').slice(1);
            $('#searchedCourseTitle').append(response);
        },

        error: function (xhr) {

        }
    })
})


/*Search*/

$(documnet).on('keyup', '#input-search', function () {

    var searchedTeacherName = $(this).val()

    $.ajax({
        url: '/Course/search?searchedTeacherName=${searchedTeacherName}',
        type: "GET",

        success: function (response) {
            console.log("hgj");
            $('#searchedTeacherName').slice(1);
            $('#searchedTeacherName').append(response);
        },

        error: function (xhr) {

        }
    })

    $(document).on('keyup', '#searchTeachers', function () {
        var searchedTeacherName = $(this).val()

        $.ajax({
            url: `/teacher/search?searchedTeacherFullname=${searchedTeacherName}`,
            type: "GET",

            success: function (response) {
                $('#searchedTeacher').slice(1)
                $('#searchedTeacher').append(response)
            },

            error: function (xhr) {

            }
        });
    })
})
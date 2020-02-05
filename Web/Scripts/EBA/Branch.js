function PostBranch() {
    var student = {
        ID: 0,
        StudentName: $('#txtCode').val().trim(),
        StudentGrade: $('#txtName').val().trim(),
        Code: $('#txtSEQNo').val().trim()
    }
    //var UserData = { "name": "test" }

    $.ajax({               
        url: 'http://localhost:16921/api/Student/CreateStudent',
        data: JSON.stringify(student),
        type: 'POST',
        traditional: true,
        contentType: 'application/json',
        success: function (data) {
            alert('Save Successfully');
        },
        error: function () {
            alert('Error on Saving');
        }
    });
}


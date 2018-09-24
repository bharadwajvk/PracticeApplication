// JavaScript Document
$(document).ready(function () {
    $("#userregistrationlink").on("click", function () {
        $.ajax({
            url: '/User/UserRegistrationAjax',
            type: 'GET',
            data: '',
            success: function (data) {
               
            }
        });
    });
});
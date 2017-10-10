$(document).ready(function () {
    $("#submit").click(function () {
        if ($("#numberform").valid()) {
            var name = $("#inputName").val();
            var numb = $("#inputNumber").val();

            $.ajax({
                url: "/api/utility",
                type: "Get",
                data: { numbers: numb },

                contentType: 'application/json; charset=utf-8',
                success: function (data) { $("#result").html(name + '<br />' + data); },
                error: function () { alert('error'); }
            });
            return false;
        }
    });
});
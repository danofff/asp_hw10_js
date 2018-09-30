$(document).ready(function () {

    var table = $("#main_table").DataTable({
        ajax: {
            url: "/Home/JsonData",
            dataSrc: ""
        },
        columns: [
            {
                data: "Id"
            },
            {
                data: "Name"
            },
            {
                data: "Employment.Name"

            },
            {
                data: "Age"
            },
            {
                data: "Date"
            },
            {
                data: "Id",
                render: function (data) {
                    return "<button class='btn btn-danger btn-sml js-delete' data-customer-id=" + data + "><b>&#10006<b></button>";
                }
            }
        ]
    });

    $("#main_table").on("click", ".js-delete",
        function () {
            var rowIndex = this.parentNode.parentNode.rowIndex;
            document.getElementById("main_table").deleteRow(rowIndex);
            var count = document.getElementById("count").textContent;
            var parcedCount = parseInt(count, 10);
            document.getElementById("count").textContent = --parcedCount;

        });



    $(".delete").on("click",
        function () {
            var customerId = $("#customer_id").val();

            if (tryParseInt(customerId, 0) === 0) {

                $('#myModal').modal('show');

            } else {
                var button = $(this);
                $(button).attr("data-customer-id", customerId);
                console.log($(button).attr("data-customer-id"));
                bootbox.confirm("are you sure you want to delete customer?",

                    function (result) {
                        if (result) {
                            $.ajax({
                                url: "/Home/Delete/" + button.attr("data-customer-id"),
                                method: "GET",
                                success: function () {
                                    table.row(button.parents("tr")).remove().draw();
                                }
                            });
                        }
                    });
            }

        });

    function tryParseInt(str, defaultValue) {
        var retValue = defaultValue;
        if (str !== null) {
            if (str.length > 0) {
                if (!isNaN(str)) {
                    retValue = parseInt(str);
                }
            }
        }
        return retValue;
    }
});
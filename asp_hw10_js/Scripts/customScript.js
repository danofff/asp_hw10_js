$(document).ready(function () {
    $('#main_table').DataTable();

    $('.delete').click(function () {
        var rowIndex = this.parentNode.parentNode.rowIndex;
        document.getElementById()("main_table").deleteRow(rowIndex);
        var count = document.getElementById("count").textContent;
        var parcedCount = parseInt(count,10);
        document.getElementById("count").textContent = --parcedCount;

    });
} );
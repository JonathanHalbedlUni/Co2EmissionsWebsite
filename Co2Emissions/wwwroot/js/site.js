// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// JavaScript für Filterfunktion
document.getElementById('filter').addEventListener('input', function () {
    var filterValue = this.value.toLowerCase();
    var rows = document.querySelectorAll('#data-table tbody tr');

    Array.prototype.forEach.call(rows, function (row) {
        var country = row.cells[0].textContent.toLowerCase();
        var company = row.cells[1].textContent.toLowerCase();

        if (country.indexOf(filterValue) !== -1 || company.indexOf(filterValue) !== -1) {
            row.style.display = '';
        } else {
            row.style.display = 'none';
        }
    });
});


(function() {
    var table = document.getElementById('myTable').getElementsByTagName('tbody')[0];
    var pagination = document.getElementById('pagination');
    var rowsPerPage = 10;
    var currentPage = 1;
    var rows = Array.prototype.slice.call(table.getElementsByTagName('tr'));

    function displayPage(page) {
        var start = (page - 1) * rowsPerPage;
        var end = start + rowsPerPage;
        table.innerHTML = '';

        for (var i = start; i < end && i < rows.length; i++) {
            table.appendChild(rows[i]);
        }
        updatePagination();
    }

    function updatePagination() {
        pagination.innerHTML = '';

        var totalPages = Math.ceil(rows.length / rowsPerPage);

        for (var i = 1; i <= totalPages; i++) {
            var button = document.createElement('button');
            button.innerHTML = i;
            button.setAttribute('data-page', i);
            button.onclick = function() {
                currentPage = parseInt(this.getAttribute('data-page'), 10);
                displayPage(currentPage);
            };
            pagination.appendChild(button);
        }
    }

    function init() {
        displayPage(1);
    }

    init();
})();

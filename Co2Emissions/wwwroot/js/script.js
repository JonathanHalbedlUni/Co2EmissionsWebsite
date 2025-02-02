$(document).ready(function () {
    // Stelle sicher, dass die Tabelle korrekt initialisiert wird
    var table = $('#data-table').DataTable({
        "paging": false,   // Deaktiviert Pagination (alle Zeilen sichtbar)
        "ordering": true,  // Aktiviert Sortieren durch Klicken auf Spaltenköpfe
        "info": false,     // Entfernt "X Einträge angezeigt"
        "searching": true, // Behält die Suchfunktion bei
        "language": {
            "search": "Suchen:",  // Anpassung der Beschriftung für Mehrsprachigkeit
            "zeroRecords": "Keine passenden Einträge gefunden",
            "infoEmpty": "Keine Daten verfügbar"
        }
    });

    // Standard-Suchleiste von DataTables verstecken
    $('.dataTables_filter').hide();

    //Eigene Suchleiste mit der DataTables-Suche verknüpfen
    $('#filter').on('keyup', function () {
        table.search(this.value).draw();
    });
});

$(function () {
    $("#formGetEmployee").submit(function (event) {
        searchEmployee(event)
    });
});

function searchEmployee(event) {
    event.preventDefault();
    console.log($(this).serialize());
}

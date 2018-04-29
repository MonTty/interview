var url_post = "./Home/";
$(function () {
    $("#loading").hide();
    $("#formGetEmployee").submit(function (event) {
        searchEmployee(event);
    });
});

function searchEmployee(event) {
    event.preventDefault();
    $("#loading").show();
    var employeeId = ($("#employeeId").val()).replace(/\s/g, '');
    $.ajax({ url: url_post + "GetEmployeeInfo", dataType: "json", method: "POST", cache: false, data: { employeeId: employeeId } })
        .fail(function (XMLHttpRequest, textStatus, errorThrown) { console.log("Status: " + textStatus + " Error: " + errorThrown); })
        .done(function (response) {
            $("#loading").hide();
            var table = '';
            if (response) {
                if (response instanceof Array) {
                    response.forEach(function (key) {
                       table += `<tr>
                        <td>`+ key["Name"] + `</td>
                        <td>`+ key["ContractTypeName"] + `</td>
                        <td>`+ key["RoleName"] + `</td>
                        <td>`+ key["HourlySalary"] + `</td>
                        <td>`+ key["MonthlySalary"] + `</td>
                        <td>`+ key["AnnualSalary"] + `</td>
                    </tr >`;
                    });
                } else {
                    table += `<tr>
                        <td>`+ response["Name"] + `</td>
                        <td>`+ response["ContractTypeName"] + `</td>
                        <td>`+ response["RoleName"] + `</td>
                        <td>`+ response["HourlySalary"] + `</td>
                        <td>`+ response["MonthlySalary"] + `</td>
                        <td>`+ response["AnnualSalary"] + `</td>
                    </tr >`;
                }
                $("#tableInfo").html(table);
            } else {
                alert("Employee id not found");
            }
        });
}


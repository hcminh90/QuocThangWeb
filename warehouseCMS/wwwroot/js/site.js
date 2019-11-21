// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function createrowdata(){
    var product = document.getElementById("ProductID");
    var Amount = document.getElementById("Amount");
    var Price = document.getElementById("Price");
    var Pay = document.getElementById("Pay");
    var prodName = product.options[product.selectedIndex].text;

    var table = document.getElementById("tbl_data");
    var stt = table.rows.length;
    var row = table.insertRow(table.rows.length);
    row.insertCell(0).innerHTML = stt;
    row.insertCell(1).innerHTML = prodName;
    row.insertCell(2).innerHTML = Amount.value;
    row.insertCell(3).innerHTML = Price.value;
    row.insertCell(4).innerHTML = Pay.value;
    row.insertCell(5).innerHTML = '';

    var dt = stt + '~' + product.value.split("-")[0] + '~' + Amount.value + '~' + Price.value + '~' + Pay.value;
    var OrderInfo = document.getElementById("OrderInfo");
    var ordVal = OrderInfo.value;
    if (ordVal == null ||  ordVal == undefined ||  ordVal.length == 0) { 
        OrderInfo.value =  dt;
    }
    else{
        OrderInfo.value = ordVal + ';' + dt;
    }
    
    
}

function CalcPrice(){
    var product = document.getElementById("ProductID");
    var prodPrice = product.value.split("-")[1];
    var Amount = document.getElementById("Amount");
    var Price = document.getElementById("Price");
    Price.value = prodPrice*Amount.value;
}

function AddRow(tblid, data) {
    var table = document.getElementById(tblid);
    var row = table.insertRow(table.rows.length);

    for (i = 0; i < data.length; i++) {
        row.insertCell(i).innerHTML = data[i];
    }
}
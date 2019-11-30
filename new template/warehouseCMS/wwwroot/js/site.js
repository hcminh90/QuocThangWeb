// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function createrowdata(){
    var product = document.getElementById("ProductID");
    var Amount = document.getElementById("Amount");
    var Price = document.getElementById("Price");
    var Pay = document.getElementById("Pay");
    var pri = document.getElementById("pri");
    var prodName = product.options[product.selectedIndex].text;

    var table = document.getElementById("tbl_data");
    var stt = table.rows.length;
    /*
    var row = table.insertRow(table.rows.length);
    row.insertCell(0).innerHTML = stt;
    row.insertCell(1).innerHTML = prodName;
    row.insertCell(2).innerHTML = Amount.value;
    row.insertCell(3).innerHTML = Price.value;
    row.insertCell(4).innerHTML = Pay.value;
    row.insertCell(5).innerHTML = '';*/
    var nRow = "<tr><td>"+stt+"</td><td>"+prodName+"</td><td>"+Amount.value+"</td><td>"+Price.value+"</td><td>"+Pay.value+"</td><td style='text-align:center;''><a class='qtbuttonDel' id='row"+stt+"' onclick='deleteOrder("+stt+");'>Xóa</a></td></tr>";
    $("#tbl_data").append(nRow);

    var dt = stt + '~' + product.value.split("-")[0] + '~' 
        + Amount.value.replace(/,/g, "") + '~' + Price.value.replace(/,/g, "") + '~' 
        + Pay.value.replace(/,/g, "") + '~' + pri.value.replace(/,/g, "");
    var OrderInfo = document.getElementById("OrderInfo");
    var ordVal = OrderInfo.value;
    if (ordVal == null ||  ordVal == undefined ||  ordVal.length == 0) { 
        OrderInfo.value =  dt;
    }
    else{
        OrderInfo.value = ordVal + ';' + dt;
    }
}

function deleteOrder(el){
   // $(this).parents("tr").remove();
   //$("#"+el).parents("tr").remove();
   var table = document.getElementById("tbl_data");
    var stt = table.rows.length;
    table.deleteRow(el);
}

function prod_change(){
    var product = document.getElementById("ProductID");
    var prodPrice = product.value.split("-")[1];
    var Price = document.getElementById("Price");
    Price.value = prodPrice;
    var pri = document.getElementById("pri");
    pri.value= prodPrice;
    var unit = document.getElementById("unit");
    unit.value=product.value.split("-")[2];
}

function showCus(){
    var cus = document.getElementById("CusID");
    var cuid = cus.value.split("-")[0];
    var cuname = cus.value.split("-")[1];
    var cutax = cus.value.split("-")[2];
    var cuphone = cus.value.split("-")[3];
    var cuadress = cus.value.split("-")[4];
    var cuemail = cus.value.split("-")[5];
    var iddiv = document.getElementById("CusInfoID");iddiv.innerHTML = cuid;
    var namediv = document.getElementById("CusInfoName");namediv.innerHTML = cuname;
    var taxdiv = document.getElementById("CusInfoTax");taxdiv.innerHTML = cutax;
    var phonediv = document.getElementById("CusInfoPhone");phonediv.innerHTML = cuphone;
    var adressdiv = document.getElementById("CusInfoAdress");adressdiv.innerHTML = cuadress;
    var emaildiv = document.getElementById("CusInfoEmail");emaildiv.innerHTML = cuemail;
    $("#showcusInfo").removeClass();
    /*jQuery('#showcusInfo').addClass("hidden").viewportChecker({
        classToAdd: 'visible', // Class to add to the elements when they are visible
        offset: 100    
    });*/
    animateCSS("showcusInfo","fadeInDown");
}

function animateCSS(element, animationName, callback) {
    const node =  document.getElementById(element);//document.querySelector(element)
    node.classList.add('animated', animationName)

    function handleAnimationEnd() {
        node.classList.remove('animated', animationName)
        node.removeEventListener('animationend', handleAnimationEnd)

        if (typeof callback === 'function') callback()
    }

    node.addEventListener('animationend', handleAnimationEnd)
}

function CalcPrice(){
    var amt = document.getElementById("Amt");
    var Amount = document.getElementById("Amount");
    var Price = document.getElementById("Price");
    var Pay = document.getElementById("Pay");
    amt.value = Amount.value.replace(/,/g, "")*Price.value.replace(/,/g, "");
    if(Pay.value == "" || Pay.value == null || Pay.value.replace(/,/g, "") == 0){
        Pay.value = Amount.value.replace(/,/g, "")*Price.value.replace(/,/g, "");
    }
}

function AddRow(tblid, data) {
    var table = document.getElementById(tblid);
    var row = table.insertRow(table.rows.length);

    for (i = 0; i < data.length; i++) {
        row.insertCell(i).innerHTML = data[i];
    }
}
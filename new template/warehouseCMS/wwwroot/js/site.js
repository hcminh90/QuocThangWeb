// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function createrowdata(){
    var custo = document.getElementById("CusID");
    if(custo.value == null || custo.value == undefined ||  custo.value.length == 0){
        alert("Vui lòng lựa chọn Khách hàng!");
        return;
    }
    var product = document.getElementById("ProductID");
    if(product.value == null || product.value == undefined ||  product.value.length == 0){
        alert("Vui lòng lựa chọn loại hàng!");
        return;
    }
    var Amount = document.getElementById("Amount");
    if(Amount.value == null || Amount.value == undefined ||  Amount.value.length == 0 || Amount.value.replace(/,/g, "") == 0){
        alert("Vui lòng nhập số lượng!");
        return;
    }
    var Price = document.getElementById("Price");
    var Pay = document.getElementById("Pay");
    var pri = document.getElementById("pri");
    var pre_Amount = document.getElementById("pre_Amount");
    var preee = "";
    if(pre_Amount != null || pre_Amount != undefined){
        preee = pre_Amount.value.replace(/,/g, "");
    }
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
    var nRow = "<tr><td style='text-align:center'>"+stt+"</td><td>"+prodName+"</td><td>"+Amount.value+"</td><td>"+Price.value+"</td><td>"+Pay.value+"</td><td style='text-align:center;''><a class='qtbuttonDel' id='row"+stt+"' onclick='deleteOrder("+stt+");'>Xóa</a></td></tr>";
    $("#tbl_data").append(nRow);

    var dt = stt + '~' + product.value.split("-")[0] + '~' 
        + Amount.value.replace(/,/g, "") + '~' + Price.value.replace(/,/g, "") + '~' 
        + Pay.value.replace(/,/g, "") + '~' + pri.value.replace(/,/g, "") + '~' + preee;
    var OrderInfo = document.getElementById("OrderInfo");
    var ordVal = OrderInfo.value;
    if (ordVal == null ||  ordVal == undefined ||  ordVal.length == 0) { 
        OrderInfo.value =  dt;
    }
    else{
        OrderInfo.value = ordVal + ';' + dt;
    }
    reset();

    var ordVal = OrderInfo.value;
    var ordArr = ordVal.split(";");
    var tongtien = 0;
    for(var i = 0; i< ordArr.length; i++){
        var ttien = ordArr[i].split("~")[4];
        tongtien = tongtien + parseInt(ttien);
    }
    var togg = number_format(tongtien+"");
    var tienchu = DocTienBangChu(tongtien);
    document.getElementById("tonghop").innerHTML = "Tổng tiền: <b>" + togg + "</b><br/>"+tienchu;
}

function reset(){
    var product = document.getElementById("ProductID");
    var Amount = document.getElementById("Amount");
    var Price = document.getElementById("Price");
    var Pay = document.getElementById("Pay");
    var pri = document.getElementById("pri");
    var unit = document.getElementById("unit");
    var pre_Amount = document.getElementById("pre_Amount");
    var amt = document.getElementById("Amt");
    if(pre_Amount != null ||  pre_Amount != undefined){
        pre_Amount.value=0;
    }
    pri.value="";
    unit.value = "";
    Pay.value = 0;
    Price.value = 0;
    Amount.value = 0;
    amt.value = 0;
    product.selectedIndex = "0";
}

function validatePro(){
    var proN = document.getElementById("ProdName");
    if(proN.value == null || proN.value == undefined ||  proN.value.length == 0){
        alert("Vui lòng nhập Tên sản phẩm!");
        return false;
    }
    var priceTmp = document.getElementById("ProdPricetmp");
    if(priceTmp.value == null || priceTmp.value == undefined ||  priceTmp.value.length == 0 || priceTmp.value.replace(/,/g, "") == 0){
        alert("Vui lòng nhập giá tiền!");
        return false;
    }
    var price = document.getElementById("ProdPrice");
    price.value = priceTmp.value.replace(/,/g, "");
    return true;
}

function validateCus(){
    var cusN = document.getElementById("CusName");
    if(cusN.value == null || cusN.value == undefined ||  cusN.value.length == 0){
        alert("Vui lòng nhập Tên Khách hàng!");
        return false;
    }
    var addr = document.getElementById("CusAddr");
    if(addr.value == null || addr.value == undefined ||  addr.value.length == 0){
        alert("Vui lòng nhập địa chỉ!");
        return false;
    }
    var phone = document.getElementById("CusPhone");
    if(phone.value == null || phone.value == undefined ||  phone.value.length == 0){
        alert("Vui lòng nhập số điện thoại!");
        return false;
    }
    return true;
}

function deleteOrder(el){
   // $(this).parents("tr").remove();
   //$("#"+el).parents("tr").remove();
   var table = document.getElementById("tbl_data");
    var stt = table.rows.length;
    table.deleteRow(el);
    var OrderInfo = document.getElementById("OrderInfo");
    var ordVal = OrderInfo.value;
    if (ordVal.length > 0) { 
        var ordArr = ordVal.split(";");
        var reprocessdt = "";
        for(var i = 0; i< ordArr.length; i++){
            if(ordArr[i].split("~")[0] != el){
                if(i==0){
                    reprocessdt = ordArr[i];
                }
                else{
                    reprocessdt = reprocessdt + ';' + ordArr[i];
                }
            }
        }
        OrderInfo.value = reprocessdt;
    }
}

function prod_change(){
    var product = document.getElementById("ProductID");
    var unit = document.getElementById("unit");
    var pri = document.getElementById("pri");
    var Price = document.getElementById("Price");
    if(product.value == null || product.value == undefined ||  product.value.length == 0){
        /*document.getElementById("proDesc").innerHTML = 
        "<div style='height:24px;padding-top:5px;' id='proshow'><i>Vui lòng lựa chọn mặt hàng để giao dịch!</i></div>";
        */
        Price.value = 0;
        pri.value= "";
        unit.value= "";
    }
    else{
        var prodPrice = product.value.split("-")[1];
        Price.value = number_format(prodPrice);
        pri.value= number_format(prodPrice);
        unit.value=product.value.split("-")[2];
        /*document.getElementById("proDesc").innerHTML = 
        "<div style='height:24px;padding-top:5px;' id='proshow'>" + product.value.split("-")[3] + "-" + product.value.split("-")[4] + "</div>";
        animateCSS("proshow","fadeInDown");
        document.getElementById("prolabel").innerHTML = 
        "<div style='height:24px;padding-top:5px;' id='proshowlabel'>Thông tin mặt hàng: </div>";
        */
    }
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
    amt.value = number_format(amt.value);
    if(Pay.value == "" || Pay.value == null || Pay.value.replace(/,/g, "") == 0){
        Pay.value = Amount.value.replace(/,/g, "")*Price.value.replace(/,/g, "");
        Pay.value = number_format(Pay.value);
    }
}

function AddRow(tblid, data) {
    var table = document.getElementById(tblid);
    var row = table.insertRow(table.rows.length);

    for (i = 0; i < data.length; i++) {
        row.insertCell(i).innerHTML = data[i];
    }
}
function number_format(data){
    var rstring = "";
    var dt = data;
    var nxt = true;
    while (nxt) {
        if(dt.length > 3){
            if(rstring == "" || rstring == null){
                rstring = dt.substring(dt.length-3);
            }
            else{
                rstring = dt.substring(dt.length-3) + "," + rstring;
            }
            dt = dt.substring(0,dt.length-3);
        }
        else{
            if(rstring == "" || rstring == null){
                rstring = dt;
            }
            else{
                rstring = dt + "," + rstring;
            }
            nxt = false;
        }
    }
    return rstring;
}

var ChuSo=new Array(" không "," một "," hai "," ba "," bốn "," năm "," sáu "," bảy "," tám "," chín ");
var Tien=new Array( "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ");

//1. Hàm đọc số có ba chữ số;
function DocSo3ChuSo(baso)
{
    var tram;
    var chuc;
    var donvi;
    var KetQua="";
    tram=parseInt(baso/100);
    chuc=parseInt((baso%100)/10);
    donvi=baso%10;
    if(tram==0 && chuc==0 && donvi==0) return "";
    if(tram!=0)
    {
        KetQua += ChuSo[tram] + " trăm ";
        if ((chuc == 0) && (donvi != 0)) KetQua += " linh ";
    }
    if ((chuc != 0) && (chuc != 1))
    {
            KetQua += ChuSo[chuc] + " mươi";
            if ((chuc == 0) && (donvi != 0)) KetQua = KetQua + " linh ";
    }
    if (chuc == 1) KetQua += " mười ";
    switch (donvi)
    {
        case 1:
            if ((chuc != 0) && (chuc != 1))
            {
                KetQua += " mốt ";
            }
            else
            {
                KetQua += ChuSo[donvi];
            }
            break;
        case 5:
            if (chuc == 0)
            {
                KetQua += ChuSo[donvi];
            }
            else
            {
                KetQua += " lăm ";
            }
            break;
        default:
            if (donvi != 0)
            {
                KetQua += ChuSo[donvi];
            }
            break;
        }
    return KetQua;
}

//2. Hàm đọc số thành chữ (Sử dụng hàm đọc số có ba chữ số)

function DocTienBangChu(SoTien)
{
    var lan=0;
    var i=0;
    var so=0;
    var KetQua="";
    var tmp="";
    var ViTri = new Array();
    if(SoTien<0) return "Số tiền âm !";
    if(SoTien==0) return "Không đồng !";
    if(SoTien>0)
    {
        so=SoTien;
    }
    else
    {
        so = -SoTien;
    }
    if (SoTien > 8999999999999999)
    {
        //SoTien = 0;
        return "Số quá lớn!";
    }
    ViTri[5] = Math.floor(so / 1000000000000000);
    if(isNaN(ViTri[5]))
        ViTri[5] = "0";
    so = so - parseFloat(ViTri[5].toString()) * 1000000000000000;
    ViTri[4] = Math.floor(so / 1000000000000);
     if(isNaN(ViTri[4]))
        ViTri[4] = "0";
    so = so - parseFloat(ViTri[4].toString()) * 1000000000000;
    ViTri[3] = Math.floor(so / 1000000000);
     if(isNaN(ViTri[3]))
        ViTri[3] = "0";
    so = so - parseFloat(ViTri[3].toString()) * 1000000000;
    ViTri[2] = parseInt(so / 1000000);
     if(isNaN(ViTri[2]))
        ViTri[2] = "0";
    ViTri[1] = parseInt((so % 1000000) / 1000);
     if(isNaN(ViTri[1]))
        ViTri[1] = "0";
    ViTri[0] = parseInt(so % 1000);
  if(isNaN(ViTri[0]))
        ViTri[0] = "0";
    if (ViTri[5] > 0)
    {
        lan = 5;
    }
    else if (ViTri[4] > 0)
    {
        lan = 4;
    }
    else if (ViTri[3] > 0)
    {
        lan = 3;
    }
    else if (ViTri[2] > 0)
    {
        lan = 2;
    }
    else if (ViTri[1] > 0)
    {
        lan = 1;
    }
    else
    {
        lan = 0;
    }
    for (i = lan; i >= 0; i--)
    {
       tmp = DocSo3ChuSo(ViTri[i]);
       KetQua += tmp;
       if (ViTri[i] > 0) KetQua += Tien[i];
       if ((i > 0) && (tmp.length > 0)) KetQua += ',';//&& (!string.IsNullOrEmpty(tmp))
    }
   if (KetQua.substring(KetQua.length - 1) == ',')
   {
        KetQua = KetQua.substring(0, KetQua.length - 1);
   }
   KetQua = KetQua.substring(1,2).toUpperCase()+ KetQua.substring(2);
   return KetQua;//.substring(0, 1);//.toUpperCase();// + KetQua.substring(1);
}
#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9827b7dd625d7c4877d1cd6861b22f80f366fc08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\_ViewImports.cshtml"
using warehouseCMS;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\_ViewImports.cshtml"
using warehouseCMS.Models;

#line default
#line hidden
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
using warehouseCMS.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9827b7dd625d7c4877d1cd6861b22f80f366fc08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 4847, true);
            WriteLiteral(@"
<div class=""qtContaint"">
    <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
        <tr>
            <td style=""padding-right: 10px;"">
                <div class=""qtContaintCT"">
                    <div id=""chart_wrap"" class=""chart_wrap"">
                    <div id=""chart_div"" class=""chart""></div> 
                    </div>
                    <script type=""text/javascript"">  
                    
                        google.charts.load('current', {  
                            packages: ['corechart', 'bar']  
                        });  
                        google.charts.setOnLoadCallback(LoadData);  
                    
                        function LoadData() {  
                            $.ajax({  
                    
                                url: 'WareHouse/PopulationChart',  
                                dataType: ""json"",  
                                type: ""GET"",  
                                error: function(xhr, status");
            WriteLiteral(@", error) {  
                                    var err = eval(""("" + xhr.responseText + "")"");  
                                    alert(err.message);
                                    toastr.error(err.message);  
                                },  
                                success: function(data) {  
                                    PopulationChart(data);  
                                    //alert(JSON.stringify(data));
                                    return false;  
                                }  
                            });  
                            return false;  
                        }  
                    
                        function PopulationChart(data) {  
                            var dataArray = [  
                                ['Các tháng giao dịch', 'Xuất kho', 'Nhập kho']  
                            ];  
                            $.each(data, function(i, item) {  
                                
                            ");
            WriteLiteral(@"    dataArray.push([item.month, item.ouput, item.input]);  
                            });  
                            var data = google.visualization.arrayToDataTable(dataArray);  
                            var options = {  
                                colors: ['#b0120a', '#7b1fa2']
                            };  
                            //var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));  
                            var chart = new google.charts.Bar(document.getElementById('chart_div'));  
                            chart.draw(data, options);  
                            var chartdiv = document.getElementById('chart_div');
                            document.getElementById('chart_wrap').style.paddingBottom = chartdiv.offsetHeight + ""px"";
                            return false;  
                        }
                        $(window).resize(function(){
                            LoadData();
                        });  
         ");
            WriteLiteral(@"           </script> 
                    <div class=""obj01 qtBoxNew animated zoomIn"">
                        <div class=""qtTitle2"">Thống kê từ ngày 1/9/2019 đến ngày 30/11/2019</div>
                        <div>
                            <table border=0 width=""100%"">
                                <tr><td colspan=4 style=""height:20px;font-weight: bold;"">Nhập kho</td></tr>
                                <tr><td style=""height:20px;"">Hóa đơn: 100</td><td>Đã thanh toán: 50.000.000 <i>VND</i></td><td>Nợ: 15.000.000 <i>VND</i></td><td><a href=""#"">Chi tiết</a></td></tr>
                                <tr><td colspan=4 style=""height:20px;font-weight: bold;"">Xuất kho</td></tr>
                                <tr><td style=""height:20px;"">Hóa đơn: 80</td><td>Đã thanh toán: 40.000.000 <i>VND</i></td><td>Nợ: 10.000.000 <i>VND</i></td><td><a href=""#"">Chi tiết</a></td></tr>
                            </table>
                            <div style=""font-weight: bold;"">&nbsp;</div>
                       ");
            WriteLiteral(@"     <table border=0 width=""100%"">
                                <tr><td style=""font-weight: bold;width:80px;height:20px;"">Doanh thu:</td><td style=""font-weight: bold;"">10.000.000 <i>VND</i></td><td></td></tr>
                                <tr><td style=""font-weight: bold;height:20px;"">Công nợ:</td><td style=""font-weight: bold;"">5.000.000 <i>VND</i></td><td></td></tr>
                            </table> 
                        </div>
                    </div>
                    
                    <div style=""margin-top:10px;animation-delay: 1s;"" class=""obj03 qtBoxNew animated zoomIn"">
                        <div class=""qtTitle2"">
                        Các giao dịch được lập gần đây nhất
                        </div>
");
            EndContext();
#line 85 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                          
                            var trans = ViewData["Transactions"] as DbFetchOutData;
                            var trandata = trans.Data;
                        

#line default
#line hidden
            BeginContext(5114, 288, true);
            WriteLiteral(@"                        <div style=""background-color:#fff;"">
                            <table border=0 width=""100%"" class=""tblshow"">
                                <tr><th>Mã hóa đơn</th><th>Sản phẩm</th><th>Khách hàng</th><th>Số lượng</th><th>Giao dịch</th><th>Thời gian</th></tr>
");
            EndContext();
#line 92 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                 foreach (var row in trandata)
                                {

#line default
#line hidden
            BeginContext(5501, 56, true);
            WriteLiteral("                                    <tr><td><a href=\"#\">");
            EndContext();
            BeginContext(5558, 13, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                   Write(row["TAX_ID"]);

#line default
#line hidden
            EndContext();
            BeginContext(5571, 13, true);
            WriteLiteral("</a></td><td>");
            EndContext();
            BeginContext(5585, 16, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                              Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(5601, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(5611, 16, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                        Write(row["CUST_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(5627, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(5637, 18, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                  Write(row["UNIT_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(5655, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(5665, 18, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                              Write(row["TRANSACTION"]);

#line default
#line hidden
            EndContext();
            BeginContext(5683, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(5693, 16, false);
#line 94 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                          Write(row["TIMESTAMP"]);

#line default
#line hidden
            EndContext();
            BeginContext(5709, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 95 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5756, 353, true);
            WriteLiteral(@"                            </table>
                        </div>
                    </div>

                    <div style=""margin-top:10px;animation-delay: 2s;"" class=""obj02 qtBoxNew animated zoomIn"">
                        <div class=""qtTitle2"">
                        Danh sách khach hàng phát sinh nợ/có
                        </div>
");
            EndContext();
#line 104 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                          
                            var cust = ViewData["Customers"] as DbFetchOutData;
                            var custdata = cust.Data;
                        

#line default
#line hidden
            BeginContext(6300, 265, true);
            WriteLiteral(@"                        <div style=""background-color:#fff;"">
                            <table border=0 width=""100%""  class=""tblshow"">
                                <tr><th>Tên Khách Hàng</th><th>Mã số thuế</th><th>Nợ</th><th>Thiếu</th><th>Chi tiết</th></tr>
");
            EndContext();
#line 111 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                 foreach (var row in custdata)
                                {

#line default
#line hidden
            BeginContext(6664, 44, true);
            WriteLiteral("                                    <tr><td>");
            EndContext();
            BeginContext(6709, 16, false);
#line 113 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                       Write(row["CUST_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(6725, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(6735, 15, false);
#line 113 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                 Write(row["CUST_TAX"]);

#line default
#line hidden
            EndContext();
            BeginContext(6750, 65, true);
            WriteLiteral("</td><td>0</td><td>0</td><td><a href=\"#\">Chi tiết</a></td></tr>\r\n");
            EndContext();
#line 114 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6850, 374, true);
            WriteLiteral(@"                                
                            </table>
                        </div>
                    </div>
                </div>
            </td>
            <td style=""width:300px;"">
                <div class=""tonkho qtBox rigthcol"">
                    <div class=""qtBoxTitle"">
                        Tồn kho
                    </div>
");
            EndContext();
#line 126 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                      
                        var prod = ViewData["Products"] as DbFetchOutData;
                        var proDT = prod.Data;
                        int i = 0;
                    

#line default
#line hidden
            BeginContext(7431, 131, true);
            WriteLiteral("                    <div class=\"qtBoxContent\">\r\n                        <table border=0 width=\"100%\" cellpadding=0 cellspacing=0>\r\n");
            EndContext();
#line 133 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                         foreach (var row in proDT)
                        {
                            

#line default
#line hidden
#line 135 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                             if(i == 0){

#line default
#line hidden
            BeginContext(7684, 188, true);
            WriteLiteral("                                <tr><td style=\"padding-left:3px;border-top:1px solid #bebebe;border-left:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\">");
            EndContext();
            BeginContext(7873, 16, false);
#line 136 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                       Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(7889, 187, true);
            WriteLiteral("</td><td style=\"border-top:1px solid #bebebe;border-right:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\"><span style=\"font-weight: bold;color:#9c0000\">");
            EndContext();
            BeginContext(8077, 18, false);
#line 136 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                   Write(row["PROD_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(8095, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(8104, 16, false);
#line 136 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(row["PROD_UNIT"]);

#line default
#line hidden
            EndContext();
            BeginContext(8120, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 137 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                            }
                            else{

#line default
#line hidden
            BeginContext(8198, 159, true);
            WriteLiteral("                                <tr><td style=\"padding-left:3px;border-left:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\">");
            EndContext();
            BeginContext(8358, 16, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                          Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(8374, 158, true);
            WriteLiteral("</td><td style=\"border-right:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\"><span style=\"font-weight: bold;color:#9c0000\">");
            EndContext();
            BeginContext(8533, 18, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                         Write(row["PROD_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(8551, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(8560, 16, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                    Write(row["PROD_UNIT"]);

#line default
#line hidden
            EndContext();
            BeginContext(8576, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 140 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#line 140 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                             
                            i = i + 1;
                        }

#line default
#line hidden
            BeginContext(8686, 1115, true);
            WriteLiteral(@"                        </table>
                    </div> 
                </div>
            </td>
        </tr>
    </table>
</div>
 
<script type=""text/javascript"">
    jQuery(document).ready(function() {
        /*jQuery('.obj01').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        }); */
        /*jQuery('.obj02').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        }); */
        /*jQuery('.obj03').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        });*/
        jQuery('.rigthcol').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated fadeInLeft', // Class to add to the elements when");
            WriteLiteral(" they are visible\r\n            offset: 100    \r\n        });\r\n    });            \r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

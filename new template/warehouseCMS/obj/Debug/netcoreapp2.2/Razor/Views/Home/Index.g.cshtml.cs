#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7268aecea846c0e548cbf02458042994b8714b4c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7268aecea846c0e548cbf02458042994b8714b4c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viewportchecker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 4233, true);
            WriteLiteral(@"
<div class=""text-center"">
    <div style=""float:left; width:70%"">
        <div style=""float:left;width:49%;text-align:left;margin-right:5px;padding:2px;"" class=""obj01 backbox"">
            <span style=""font-weight: bold;"">Công ty Quốc Thắng (từ ngày ... đến ngày ...)</span>
            <div style=""background-color:#fff; padding:2px;"">
                <div style=""font-weight: bold;"">Nhập kho</div>
                <table border=0 width=""100%"">
                    <tr><td>Hóa đơn: 100</td><td>Đã thanh toán: 50.000.000</td><td>Nợ: 15.000.000</td><td><a>Chi tiết</a></td></tr>
                </table>
                <div style=""font-weight: bold;"">Xuất kho</div>
                <table border=0 width=""100%"">
                    <tr><td>Hóa đơn: 80</td><td>Đã thanh toán: 40.000.000</td><td>Nợ: 10.000.000</td><td><a>Chi tiết</a></td></tr>
                </table>
                <div style=""font-weight: bold;"">&nbsp;</div>
                <table border=0 width=""100%"">
                    <tr><td styl");
            WriteLiteral(@"e=""font-weight: bold;"">Doanh thu:</td><td style=""font-weight: bold;background-color:#8bc36a"">10.000.000</td><td style=""font-weight: bold;"">Công nợ:</td><td style=""font-weight: bold;background-color:#dc3545;color:#fff;"">5.000.000</td></tr>
                </table> 
            </div>
        </div>
        <div style=""float:left;width:50%""><!--Tỷ lệ giao dịch theo tháng -->
            <div id=""chart_div"" ></div>  
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
                        error: function(xhr, status, error) {  
                            var err =");
            WriteLiteral(@" eval(""("" + xhr.responseText + "")"");  
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
                        ['Month', 'abc', 'abc2']  
                    ];  
                    $.each(data, function(i, item) {  
                        
                        dataArray.push([item.month, item.ouput, item.input]);  
                    });  
                    var data = google.visualization.arrayToDataTable(dataArray);  
                    var options = {  
                       ");
            WriteLiteral(@" title: 'Tỷ lệ giao dịch phát sinh qua từng tháng',  
                        chartArea: {  
                            width: '100%'  
                        },  
                        colors: ['#b0120a', '#7b1fa2'],  
                        hAxis: {  
                            title: 'Month',  
                            minValue: 0  
                        },  
                        vAxis: {  
                            title: 'Số lượng giao dịch'  
                        }  
                    };  
                    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));  
            
                    chart.draw(data, options);  
                    return false;  
                }  
            </script>  
        </div><!-- biểu đồ cột theo tháng, mỗi tháng có 2 cột nhập/xuất -->
        <div style=""clear:left;text-align:left;height: 1px;"">&nbsp;</div>
        <div style=""clear:left;text-align:left;margin-top:10px;padding:2px;"" cl");
            WriteLiteral("ass=\"obj03 backbox\">\r\n            <div style=\"font-weight: bold;\">\r\n            Các giao dịch được lập gần đây nhất\r\n            </div>\r\n");
            EndContext();
#line 89 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
              
                var trans = ViewData["Transactions"] as DbFetchOutData;
                var trandata = trans.Data;
            

#line default
#line hidden
            BeginContext(4452, 269, true);
            WriteLiteral(@"            <div style=""background-color:#fff; padding:2px;"">
                <table border=1 width=""100%"" id=""hieghtlighttbl"">
                    <tr><th>Mã hóa đơn</th><th>Sản phẩm</th><th>Khách hàng</th><th>Số lượng</th><th>Giao dịch</th><th>Thời gian</th></tr>
");
            EndContext();
#line 96 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                     foreach (var row in trandata)
                    {

#line default
#line hidden
            BeginContext(4796, 35, true);
            WriteLiteral("                        <tr><td><a>");
            EndContext();
            BeginContext(4832, 13, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                              Write(row["TAX_ID"]);

#line default
#line hidden
            EndContext();
            BeginContext(4845, 13, true);
            WriteLiteral("</a></td><td>");
            EndContext();
            BeginContext(4859, 16, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                         Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(4875, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(4885, 16, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                   Write(row["CUST_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(4901, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(4911, 18, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                             Write(row["UNIT_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(4929, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(4939, 18, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                         Write(row["TRANSACTION"]);

#line default
#line hidden
            EndContext();
            BeginContext(4957, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(4967, 16, false);
#line 98 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                     Write(row["TIMESTAMP"]);

#line default
#line hidden
            EndContext();
            BeginContext(4983, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 99 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5018, 303, true);
            WriteLiteral(@"                    
                </table>
            </div>
        </div>

        <div style=""clear:left;text-align:left;margin-top:10px;padding:2px;"" class=""obj02 backbox"">
            <div style=""font-weight: bold;"">
            Danh sách khach hàng phát sinh nợ/có
            </div>
");
            EndContext();
#line 109 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
              
                var cust = ViewData["Customers"] as DbFetchOutData;
                var custdata = cust.Data;
            

#line default
#line hidden
            BeginContext(5464, 246, true);
            WriteLiteral("            <div style=\"background-color:#fff; padding:2px;\">\r\n                <table border=1 width=\"100%\"  id=\"hieghtlighttbl\">\r\n                    <tr><th>Tên Khách Hàng</th><th>Mã số thuế</th><th>Nợ</th><th>Thiếu</th><th>Chi tiết</th></tr>\r\n");
            EndContext();
#line 116 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                     foreach (var row in custdata)
                    {

#line default
#line hidden
            BeginContext(5785, 32, true);
            WriteLiteral("                        <tr><td>");
            EndContext();
            BeginContext(5818, 16, false);
#line 118 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                           Write(row["CUST_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(5834, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(5844, 15, false);
#line 118 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                     Write(row["CUST_TAX"]);

#line default
#line hidden
            EndContext();
            BeginContext(5859, 56, true);
            WriteLiteral("</td><td>0</td><td>0</td><td><a>Chi tiết</a></td></tr>\r\n");
            EndContext();
#line 119 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5938, 286, true);
            WriteLiteral(@"                    
                </table>
            </div>
        </div>
    </div>
    <div style=""float:left; width:29%;text-align:left;margin-left:5px;height:500px;padding:2px;"" class=""backbox"">
        <div style=""font-weight: bold;"">
        Tồn kho
        </div>
");
            EndContext();
#line 129 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
          
            var prod = ViewData["Products"] as DbFetchOutData;
            var proDT = prod.Data;
            int i = 0;
        

#line default
#line hidden
            BeginContext(6371, 143, true);
            WriteLiteral("        <div style=\"background-color:#fff; padding:2px;height:470px;\">\r\n            <table border=0 width=\"100%\" cellpadding=0 cellspacing=0>\r\n");
            EndContext();
#line 136 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
             foreach (var row in proDT)
            {
                

#line default
#line hidden
#line 138 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                 if(i == 0){

#line default
#line hidden
            BeginContext(6600, 176, true);
            WriteLiteral("                    <tr><td style=\"padding-left:3px;border-top:1px solid #bebebe;border-left:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\">");
            EndContext();
            BeginContext(6777, 16, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                           Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(6793, 187, true);
            WriteLiteral("</td><td style=\"border-top:1px solid #bebebe;border-right:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\"><span style=\"font-weight: bold;color:#9c0000\">");
            EndContext();
            BeginContext(6981, 18, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                       Write(row["PROD_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(6999, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(7008, 16, false);
#line 139 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                  Write(row["PROD_UNIT"]);

#line default
#line hidden
            EndContext();
            BeginContext(7024, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 140 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                }
                else{

#line default
#line hidden
            BeginContext(7078, 147, true);
            WriteLiteral("                    <tr><td style=\"padding-left:3px;border-left:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\">");
            EndContext();
            BeginContext(7226, 16, false);
#line 142 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                              Write(row["PROD_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(7242, 158, true);
            WriteLiteral("</td><td style=\"border-right:1px solid #bebebe;border-bottom:1px solid #bebebe;border-rigth:1px solid #bebebe;\"><span style=\"font-weight: bold;color:#9c0000\">");
            EndContext();
            BeginContext(7401, 18, false);
#line 142 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                             Write(row["PROD_AMOUNT"]);

#line default
#line hidden
            EndContext();
            BeginContext(7419, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(7428, 16, false);
#line 142 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                        Write(row["PROD_UNIT"]);

#line default
#line hidden
            EndContext();
            BeginContext(7444, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 143 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 143 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Home\Index.cshtml"
                 
                i = i + 1;
            }

#line default
#line hidden
            BeginContext(7518, 59, true);
            WriteLiteral("            </table>\r\n        </div> \r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7577, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7268aecea846c0e548cbf02458042994b8714b4c20910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7624, 756, true);
            WriteLiteral(@" 
<script type=""text/javascript"">
    jQuery(document).ready(function() {
        jQuery('.obj01').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated fadeInDown', // Class to add to the elements when they are visible
            offset: 100    
        }); 
        jQuery('.obj02').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated bounceInUp', // Class to add to the elements when they are visible
            offset: 100    
        }); 
        jQuery('.obj03').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated bounceInLeft', // Class to add to the elements when they are visible
            offset: 100    
        });
    });            
</script>");
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

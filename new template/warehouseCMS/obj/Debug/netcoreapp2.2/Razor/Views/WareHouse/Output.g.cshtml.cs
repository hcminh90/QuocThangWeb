#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WareHouse_Output), @"mvc.1.0.view", @"/Views/WareHouse/Output.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WareHouse/Output.cshtml", typeof(AspNetCore.Views_WareHouse_Output))]
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
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
using warehouseCMS.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a023", @"/Views/WareHouse/Output.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_WareHouse_Output : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WareHouse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Output", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
  
    ViewData["Title"] = "Xuất Kho";

#line default
#line hidden
            BeginContext(70, 110, true);
            WriteLiteral("\r\n<div class=\"qtBox2\">\r\n    <div class=\"qtBoxTitle\">Xuất hàng</div>\r\n    <div class=\"qtBoxContent2\">\r\n        ");
            EndContext();
            BeginContext(180, 7697, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a0235502", async() => {
                BeginContext(272, 437, true);
                WriteLiteral(@"
            <div class=""qtBoxNew obj01 animated zoomIn"">
                <div class=""qtTitle2"">Thông tin khách hàng</div>
                <div class=""qtBoxContent2"">
                    <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
                        <tr>
                            <td style=""width:200px;"">Chọn khách hàng <span class=""qtqoute"">(*)</span>:</td>
                            <td>
");
                EndContext();
#line 17 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                  
                                    var cus = ViewData["Customers"] as DbFetchOutData;
                                    var data = cus.Data;
                                

#line default
#line hidden
                BeginContext(926, 124, true);
                WriteLiteral("                                <select name=\"CusID\" id=\"CusID\" onchange=\"showCus();\">\r\n                                    ");
                EndContext();
                BeginContext(1050, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a0236926", async() => {
                    BeginContext(1067, 10, true);
                    WriteLiteral("--Lựa chọn");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1086, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                     foreach (var row in data)
                                    {

#line default
#line hidden
                BeginContext(1191, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1231, 159, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a0238783", async() => {
                    BeginContext(1365, 16, false);
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                                                                        Write(row["CUST_NAME"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                           WriteLiteral(row["CUST_ID"]);

#line default
#line hidden
                WriteLiteral("-");
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                           WriteLiteral(row["CUST_NAME"]);

#line default
#line hidden
                WriteLiteral("-");
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                             WriteLiteral(row["CUST_TAX"]);

#line default
#line hidden
                WriteLiteral("-");
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                              WriteLiteral(row["CUST_PHONE_NUMBER"]);

#line default
#line hidden
                WriteLiteral("-");
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                        WriteLiteral(row["CUST_ADDRESS"]);

#line default
#line hidden
                WriteLiteral("-");
#line 25 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                                             WriteLiteral(row["CUST_EMAIL"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1390, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1431, 2026, true);
                WriteLiteral(@"                                </select>
                            </td>
                        </tr>
                    </table>
                    <div class=""qthidden"" id=""showcusInfo"">
                        <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
                            <tr style=""display:none;"">
                                <td style=""bold;height:20px;"">Mã khách hàng: </td><td><div id=""CusInfoID""></div></td>
                            </tr>
                            <tr>
                                <td style=""bold;width:200px;height:20px;"">Tên khách hàng:</td><td><div id=""CusInfoName""></div></td>
                            </tr>
                            <tr>
                                <td style=""bold;height:20px;"">Mã số thuế:</td><td><div id=""CusInfoTax""></div></td>
                            </tr>
                            <tr>
                                <td style=""height:20px;"">Số điện thoại:</td><td><div id=""CusInfo");
                WriteLiteral(@"Phone""></div></td>
                            </tr>
                            <tr>
                                <td style=""height:20px;"">Địa chỉ liên hệ:</td><td><div id=""CusInfoAdress""></div></td>
                            </tr>
                            <tr>
                                <td style=""height:20px;"">Email:</td><td><div id=""CusInfoEmail""></div></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""qtBoxNew obj02 animated zoomIn"" style=""animation-delay: 0.5s;"">
                <div class=""qtTitle2"">Thông tin giao dịch</div>
                <div class=""qtBoxContent2"">
                    <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
                        <tr>
                            <td style=""width:200px;height:23px;"">Chọn loại hàng <span class=""qtqoute"">(*)</span>:</td>
                            <td>
");
                EndContext();
#line 62 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                  
                                    var prod = ViewData["Products"] as DbFetchOutData;
                                    var dtProd = prod.Data;
                                

#line default
#line hidden
                BeginContext(3677, 114, true);
                WriteLiteral("                                <select id=\"ProductID\" onchange=\"prod_change()\">\r\n                                ");
                EndContext();
                BeginContext(3791, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a02315467", async() => {
                    BeginContext(3808, 10, true);
                    WriteLiteral("--Lựa chọn");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3827, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 68 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                 foreach (var row in dtProd)
                                {

#line default
#line hidden
                BeginContext(3926, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(3962, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c84b9ad16ef54bda6710f96fd3c7b2b0f3e1a02317315", async() => {
                    BeginContext(4073, 16, false);
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                                             Write(row["PROD_NAME"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(4089, 3, true);
                    WriteLiteral(" - ");
                    EndContext();
                    BeginContext(4093, 16, false);
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                                                                 Write(row["PROD_DESC"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                       WriteLiteral(row["PROD_ID"]);

#line default
#line hidden
                WriteLiteral("-");
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                       WriteLiteral(row["PROD_UNIT_PRICE"]);

#line default
#line hidden
                WriteLiteral("-");
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                               WriteLiteral(row["PROD_UNIT"]);

#line default
#line hidden
                WriteLiteral("-");
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                 WriteLiteral(row["PROD_NAME"]);

#line default
#line hidden
                WriteLiteral("-");
#line 70 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                                                                                                   WriteLiteral(row["PROD_DESC"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 71 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Output.cshtml"
                                }

#line default
#line hidden
                BeginContext(4155, 3715, true);
                WriteLiteral(@"                                </select>
                            </td>
                            <td>Giá:</td><td><input type=""text"" id=""pri"" disabled></td>
                            <td>Đơn vị tính:</td><td><input type=""text"" id=""unit"" disabled></td>
                            <script type=""text/javascript"">$(""#pri"").maskMoney({thousands:',', allowZero: true, precision: 0, allowEmpty:false, suffix:""""});</script>
                        </tr>
                        <tr>
                            <td style=""height:23px;"">Số lượng <span class=""qtqoute"">(*)</span>:</td>
                            <td><input type=""text"" id=""Amount"" placeholder=""Số lượng.."" autocomplete=""off"" onblur=""CalcPrice();""></td>
                            <script type=""text/javascript"">$(""#Amount"").maskMoney({thousands:',', allowZero: true, precision: 0, allowEmpty:false, suffix:""""});</script>
                        </tr>
                        <tr>
                            <td style=""height:23px;"">Đơn giá <");
                WriteLiteral(@"span class=""qtqoute"">(*)</span>:</td>
                            <td><input type=""text"" id=""Price"" autocomplete=""off"" onblur=""CalcPrice();""></td>
                            <script type=""text/javascript"">$(""#Price"").maskMoney({thousands:',', allowZero: true, precision: 0, allowEmpty:false, suffix:""""});</script>
                        </tr>
                        <tr>
                            <td style=""height:23px;"">Thành tiền:</td>
                            <td><input type=""text"" id=""Amt"" disabled autocomplete=""off""></td>
                            <script type=""text/javascript"">$(""#Amt"").maskMoney({thousands:',', allowZero: true, precision: 0, allowEmpty:false, suffix:""""});</script>
                        </tr>
                        <tr>
                            <td style=""height:23px;"">Số tiền đã thanh toán <span class=""qtqoute"">(*)</span>:</td>
                            <td><input type=""text"" id=""Pay"" autocomplete=""off""></td>
                            <script type=""text/jav");
                WriteLiteral(@"ascript"">$(""#Pay"").maskMoney({thousands:',', allowZero: true, precision: 0, allowEmpty:false, suffix:""""});</script>
                        </tr>
                    </table>
                </div>
                <div>
                    <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
                        <tr>
                            <td></td>
                            <td style=""text-align:right;"">
                                <input type=""button"" class=""qtbutton"" style=""width:170px"" value=""Thêm vào đơn hàng"" onclick=""createrowdata();"">
                                <input type=""button"" class=""qtbutton"" value=""Xóa trắng"" onclick="""">
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            
            <div class=""qtBoxNew obj03 animated zoomIn"" style=""animation-delay: 1s;"">
                <div class=""qtTitle2"">Thông tin đơn hàng</div>
                <div class");
                WriteLiteral(@"=""frmtable"">
                    <table id=""tbl_data"" class =""qthltbl"" width=""100%"" cellpadding=0 cellspacing=0>
                        <tr><th style=""text-align:center"">Stt</th><th>Tên Hàng</th><th>Số Lượng</th><th>Số Tiền</th><th>Đã Thanh Toán</th><th style=""text-align:center;width:100px;""></th></tr>
                    </table>
                </div>
            </div>

            <input type=""hidden"" name=""OrderInfo"" id=""OrderInfo"" value="""">

            <div style=""text-align:right;margin-top:5px;"">
                <input type=""submit"" class=""qtbutton"" style=""width:170px"" value=""Xuất kho"">
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7877, 769, true);
            WriteLiteral(@"
    </div>
</div>

<script type=""text/javascript"">
    /*jQuery(document).ready(function() {
        jQuery('.obj01').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        }); 
        jQuery('.obj02').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        }); 
        jQuery('.obj03').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        });
    });    */        
</script>
");
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

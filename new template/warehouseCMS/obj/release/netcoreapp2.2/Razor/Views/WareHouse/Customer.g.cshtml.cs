#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb35b84dafa1e461d2f0d56a4a43dcf89e6f06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WareHouse_Customer), @"mvc.1.0.view", @"/Views/WareHouse/Customer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WareHouse/Customer.cshtml", typeof(AspNetCore.Views_WareHouse_Customer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb35b84dafa1e461d2f0d56a4a43dcf89e6f06b", @"/Views/WareHouse/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_WareHouse_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WareHouse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\Customer.cshtml"
  
    ViewData["Title"] = "Khách hàng";

#line default
#line hidden
            BeginContext(46, 119, true);
            WriteLiteral("\r\n<div class=\"qtBox2\">\r\n    <div class=\"qtBoxTitle\">Quản lý khách hàng</div>\r\n    <div class=\"qtBoxContent2\">\r\n        ");
            EndContext();
            BeginContext(165, 1994, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cb35b84dafa1e461d2f0d56a4a43dcf89e6f06b4953", async() => {
                BeginContext(259, 1893, true);
                WriteLiteral(@"
            <div class=""qtBoxNew obj01"">
                <div class=""qtTitle2"">Thông tin khách hàng/Nhà cung cấp</div>
                    <div class=""qtBoxContent2"">
                        <table border=0 cellpadding=0 cellspacing=0 height=""100%"" width=""100%"">
                            <tr>
                                <td style=""height:23px;width:150px;"">Tên khách hàng:</td><td><input type=""text"" id=""CusName"" name =""CusName"" placeholder=""Nhập tên khách hàng.."" autocomplete=""off""></td>
                            </tr>
                            <tr>
                                <td style=""height:23px;width:150px;"">Mã số thuế:</td><td><input type=""text"" id=""TaxID"" name =""TaxID"" placeholder=""Mã số thuế.."" autocomplete=""off""></td>
                            </tr>
                            <tr>
                                <td style=""height:23px;width:150px;"">Địa chỉ:</td><td><input type=""text"" id=""CusAddr"" name =""CusAddr"" placeholder=""Địa chỉ khách hàng.."" autocomplete=""off""></td>
                WriteLiteral(@"
                            </tr>
                            <tr>
                                <td style=""height:23px;width:150px;"">Số điện thoại:</td><td><input type=""text"" id=""CusPhone"" name =""CusPhone"" placeholder=""Số điện thoại.."" autocomplete=""off""></td>
                            </tr>
                            <tr>
                                <td style=""height:23px;width:150px;"">Email:</td><td><input type=""text"" id=""CusEmail"" name =""CusEmail"" placeholder=""Địa chỉ email.."" autocomplete=""off""></td>
                            </tr>
                        </table>
                    </div>
                    <div style=""text-align:right;"">
                        <input type=""submit"" class=""qtbutton"" value=""Lưu"" style=""width:150px;margin-top:3px;"">
                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2159, 337, true);
            WriteLiteral(@"
    </div>
</div>
<script type=""text/javascript"">
    jQuery(document).ready(function() {
        jQuery('.obj01').addClass(""hidden"").viewportChecker({
            classToAdd: 'visible animated zoomIn', // Class to add to the elements when they are visible
            offset: 100    
        });
    });          
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
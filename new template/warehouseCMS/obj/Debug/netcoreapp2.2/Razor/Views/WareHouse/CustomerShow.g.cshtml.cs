#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad12824cb123f09a2081a2d96ebc53fb1f5b469f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WareHouse_CustomerShow), @"mvc.1.0.view", @"/Views/WareHouse/CustomerShow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WareHouse/CustomerShow.cshtml", typeof(AspNetCore.Views_WareHouse_CustomerShow))]
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
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
using warehouseCMS.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad12824cb123f09a2081a2d96ebc53fb1f5b469f", @"/Views/WareHouse/CustomerShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_WareHouse_CustomerShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
  
    ViewData["Title"] = "Danh sách khách hàng";

#line default
#line hidden
#line 5 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
  
    var cust = ViewData["Customers"] as DbFetchOutData;
    var data = cust.Data;

#line default
#line hidden
            BeginContext(173, 77, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <table border=0 cellpadding=0 cellspacing=0>\r\n");
            EndContext();
#line 11 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
         foreach (var row in data)
        {

#line default
#line hidden
            BeginContext(297, 20, true);
            WriteLiteral("            <tr><td>");
            EndContext();
            BeginContext(318, 16, false);
#line 13 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
               Write(row["CUST_NAME"]);

#line default
#line hidden
            EndContext();
            BeginContext(334, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 14 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\WareHouse\CustomerShow.cshtml"
        }

#line default
#line hidden
            BeginContext(357, 32, true);
            WriteLiteral("        \r\n    </table>\r\n</div>\r\n");
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

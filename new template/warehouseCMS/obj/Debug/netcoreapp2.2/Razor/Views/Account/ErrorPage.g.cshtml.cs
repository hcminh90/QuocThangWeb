#pragma checksum "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Account\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847ad554c56b6d326478620cdb1420b404a51d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ErrorPage), @"mvc.1.0.view", @"/Views/Account/ErrorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ErrorPage.cshtml", typeof(AspNetCore.Views_Account_ErrorPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847ad554c56b6d326478620cdb1420b404a51d97", @"/Views/Account/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec766c4357532528e61ab91a439f401a2335ba75", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Account\ErrorPage.cshtml"
  
    ViewData["Title"] = "Error Page";

#line default
#line hidden
            BeginContext(46, 237, true);
            WriteLiteral("\r\n<div class = \"error-zone\">\r\n    <div class=\"error-panel\">\r\n        <div class=\"error-title\">Đã có sự cố xảy ra!</div>\r\n        <div class=\"error-content\"><i class=\"fa fa-warning\" style=\"font-size:28px;color:red;margin-right:10px;\"></i>");
            EndContext();
            BeginContext(284, 13, false);
#line 8 "C:\Users\Administrator\Documents\Visual Code\warehouseCMS\Views\Account\ErrorPage.cshtml"
                                                                                                               Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(297, 158, true);
            WriteLiteral("</div>\r\n        <div class=\"error-contact\">Hotline: 0947396939 - Huỳnh Chí Công, Zalo : 0947396939, email: huynhchicong@gmail.com </div>\r\n    </div>\r\n</div>\r\n");
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

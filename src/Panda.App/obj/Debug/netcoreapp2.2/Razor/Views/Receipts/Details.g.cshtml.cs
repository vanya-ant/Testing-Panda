#pragma checksum "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8a2a8415402bf2e1489399979dce79fbb4a126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Receipts.Views_Receipts_Details), @"mvc.1.0.view", @"/Views/Receipts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receipts/Details.cshtml", typeof(Panda.App.Views.Receipts.Views_Receipts_Details))]
namespace Panda.App.Views.Receipts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8a2a8415402bf2e1489399979dce79fbb4a126", @"/Views/Receipts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003302008ecbbd1a2318ec4c95ec61eae7b76fae", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Panda.App.Models.Receipt.ReceiptDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 208, true);
            WriteLiteral("\n<h1 class=\"text-center\">Receipt Details</h1>\n<hr class=\"hr-2 bg-panda\">\n<div class=\"mx-auto\">\n    <div class=\"receipt-id-handler d-flex justify-content-between\">\n        <h3>Receipt Number:</h3>\n        <h3>");
            EndContext();
            BeginContext(352, 8, false);
#line 13 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(360, 137, true);
            WriteLiteral("</h3>\n    </div>\n    <hr class=\"hr-2 bg-panda\">\n    <div class=\"d-flex justify-content-between\">\n        <h4>Issued On:</h4>\n        <h4>");
            EndContext();
            BeginContext(498, 14, false);
#line 18 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.IssuedOn);

#line default
#line hidden
            EndContext();
            BeginContext(512, 113, true);
            WriteLiteral("</h4>\n    </div>\n    <div class=\"d-flex justify-content-between\">\n        <h4>Delivery Address:</h4>\n        <h4>");
            EndContext();
            BeginContext(626, 21, false);
#line 22 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.DeliveryAddress);

#line default
#line hidden
            EndContext();
            BeginContext(647, 147, true);
            WriteLiteral("</h4>\n    </div>\n    <hr class=\"hr-2 bg-panda\">\n    <div class=\"d-flex justify-content-between\">\n        <h4>Package Weight (KG):</h4>\n        <h4>");
            EndContext();
            BeginContext(795, 19, false);
#line 27 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.PackageWeight);

#line default
#line hidden
            EndContext();
            BeginContext(814, 116, true);
            WriteLiteral("</h4>\n    </div>\n    <div class=\"d-flex justify-content-between\">\n        <h4>Package Description:</h4>\n        <h4>");
            EndContext();
            BeginContext(931, 24, false);
#line 31 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.PackageDescription);

#line default
#line hidden
            EndContext();
            BeginContext(955, 106, true);
            WriteLiteral("</h4>\n    </div>\n    <div class=\"d-flex justify-content-between\">\n        <h4>Recipient:</h4>\n        <h4>");
            EndContext();
            BeginContext(1062, 15, false);
#line 35 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 124, true);
            WriteLiteral("</h4>\n    </div>\n    <hr class=\"hr-2 bg-panda\">\n    <div class=\"fee-holder d-flex justify-content-end\">\n        <h3>Total: $");
            EndContext();
            BeginContext(1202, 26, false);
#line 39 "E:\C# WEB\ASP.NET Core\Testing\src\Panda.App\Views\Receipts\Details.cshtml"
               Write(Model.Total.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 23, true);
            WriteLiteral("</h3>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Panda.App.Models.Receipt.ReceiptDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f18eb52b350424e6dbb66875cef7aca38e2385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewStockDetails), @"mvc.1.0.view", @"/Views/Customer/ViewStockDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\_ViewImports.cshtml"
using CustomerPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\_ViewImports.cshtml"
using CustomerPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f18eb52b350424e6dbb66875cef7aca38e2385", @"/Views/Customer/ViewStockDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03510779d3dea3e9bbe0a0f9864ddeaf8903da9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewStockDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerPortalMVC.Models.StockDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
  
    ViewData["Title"] = "ViewStockDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row \">\r\n        <div class=\"col-md-4\"></div>\r\n        <div class=\"col-md-4\" >\r\n            <div class=\"btn-group\" id=\"myDIV\">\r\n");
            WriteLiteral(@"                <a class=""btn btn-outline-primary active"" href=""/Customer/ViewStockDetails"">Stocks</a>
                <a class=""btn btn-outline-primary"" href=""/Customer/ViewMutualFundDetails"">Mutual Funds</a>
                <a class=""btn btn-outline-primary"" href=""/Customer/ViewNetWorth"">NetWorth</a>
            </div>
        </div>
    </div>
</div>

<center>
    <div class=""col-md-4"">
        <br /><h2 class=""text-success"">Stock Details</h2><hr /><br />
    </div>
</center>

<table class=""table"">
    <thead>
        <tr>
            <th class=""text-white"">
                ");
#nullable restore
#line 33 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.StockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-white\">\r\n                ");
#nullable restore
#line 36 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.StockCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-white\">\r\n                ");
#nullable restore
#line 39 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 49 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 52 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 55 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
           Write(Html.ActionLink("Sell", "SellStock", "Customer", new { id = item.TStockId }, new { @class = "btn btn-success", onclick = "return confirm('Are u sure to sell this Stock')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Portfolio-Management\CustomerPortalMVC\CustomerPortalMVC\CustomerPortalMVC\Views\Customer\ViewStockDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerPortalMVC.Models.StockDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e364703e926c0885060540a014d46219d5530cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewAdminMutualFundDetails), @"mvc.1.0.view", @"/Views/Customer/ViewAdminMutualFundDetails.cshtml")]
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
#line 1 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\_ViewImports.cshtml"
using CustomerPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\_ViewImports.cshtml"
using CustomerPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e364703e926c0885060540a014d46219d5530cc", @"/Views/Customer/ViewAdminMutualFundDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03510779d3dea3e9bbe0a0f9864ddeaf8903da9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewAdminMutualFundDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerPortalMVC.Models.DailyMutualFundNav>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
  
    ViewData["Title"] = "ViewAdminMutualFundDetails";
    Layout = "~/Views/Shared/LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <div class=\"col-md-4\">\r\n        <br /><h2 class=\"text-success\">Available MutualFunds</h2><hr /><br />\r\n    </div>\r\n</center>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-white\">\r\n                ");
#nullable restore
#line 17 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.MutualFundId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-white\">\r\n                ");
#nullable restore
#line 20 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.MutualFundName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-white\">\r\n                ");
#nullable restore
#line 23 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.MutualFundValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 32 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.MutualFundId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 35 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.MutualFundName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 38 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.MutualFundValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-primary\" onclick=\"funstocks()\">Buy</a>\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\MY PC\Desktop\customerportalupdatedmvc\Views\Customer\ViewAdminMutualFundDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerPortalMVC.Models.DailyMutualFundNav>> Html { get; private set; }
    }
}
#pragma warning restore 1591

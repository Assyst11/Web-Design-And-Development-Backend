#pragma checksum "C:\Users\Jafar\Desktop\Layout Demos\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03185e706e7de02578198cb955fa36aee045f40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03185e706e7de02578198cb955fa36aee045f40f", @"/Views/Product/Details.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication10.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jafar\Desktop\Layout Demos\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Product ID</th>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\Jafar\Desktop\Layout Demos\Views\Product\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Product Name</th>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\Jafar\Desktop\Layout Demos\Views\Product\Details.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Product Price</th>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Jafar\Desktop\Layout Demos\Views\Product\Details.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication10.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

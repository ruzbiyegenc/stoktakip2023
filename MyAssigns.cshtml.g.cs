#pragma checksum "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bbff2c680660a5670f269b03aadcba461b4cd7bf97b3cd14f33412715f065832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assign_MyAssigns), @"mvc.1.0.view", @"/Views/Assign/MyAssigns.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\_ViewImports.cshtml"
using StokTakip2023;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\_ViewImports.cshtml"
using StokTakip2023.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\_ViewImports.cshtml"
using BusinessLayer.Abstract;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bbff2c680660a5670f269b03aadcba461b4cd7bf97b3cd14f33412715f065832", @"/Views/Assign/MyAssigns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"97cc8ab97bf729af10d6c3b153a8d6176f672827772e3be0c03f9becb1b45be3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Assign_MyAssigns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.StockAssignment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
  
    ViewData["Title"] = "MyAssigns";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Zimmet Listem</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.AssignmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.IsReturned));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.AssignmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsReturned));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
               Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\ruzbi\OneDrive\Masaüstü\StokTakip2023\StokTakip2023\Views\Assign\MyAssigns.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.StockAssignment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

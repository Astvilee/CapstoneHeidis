#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33bbaf21485c545c44a6287e9d7a0075b8c34be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ReturnedProducts), @"mvc.1.0.view", @"/Views/Admin/ReturnedProducts.cshtml")]
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
#line 1 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\_ViewImports.cshtml"
using Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
using Capstone.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33bbaf21485c545c44a6287e9d7a0075b8c34be5", @"/Views/Admin/ReturnedProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ReturnedProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ReturnedOrderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
  
    ViewData["Title"] = "Inventory";
    List<ReturnedOrderViewModel> ListOfReturn = ViewBag.ListOfReturn;
    List<UserViewModel> Users = ViewBag.Users;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<br />
<div class=""container"">
    <div class=""text-center"">
        <table class=""table""> 
            <thead>
                <tr>
                    <th>
                        Customer Email
                    </th>
                    <th>
                        Product Name
                    </th>
                    <th>
                        Reason for return
                    </th>
                    <th>
                        Quantity
                    </th>
                    <th>
                        Date of return
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                 foreach (var item in ListOfReturn){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 37 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 38 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 39 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                                           Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 40 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 41 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ReturnedProducts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.ReturnedOrderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

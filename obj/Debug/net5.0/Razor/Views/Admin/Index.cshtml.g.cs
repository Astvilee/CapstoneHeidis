#pragma checksum "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d61f8e4ef2073c55495dac8d46037be0011d630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\reden\source\repos\CapstoneHeidis\Views\_ViewImports.cshtml"
using Capstone;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d61f8e4ef2073c55495dac8d46037be0011d630", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""container"">
     <br />
     <br />
     <br />
     <br />
     <br />
    <div>
        <h1>Menu    </h1>
    </div>

    <div class=""row"">

        <div class=""col-6 my-2"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Manage Accounts</h5>
                    <p class=""card-text"">Module that handles creating, reading, editing, deleting accounts</p>
                    <a href=""/Admin/Manageaccount"" class=""btn btn-primary"">Manage Accounts</a>
                </div>
            </div>
        </div>

        <div class=""col-6 my-2"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Manage Orders</h5>
                    <p class=""card-text"">Module that handles changing customer order status for delivery</p>
                    <a href=""/admin/ManageOrder"" class=""btn btn-primary"">Manage Orders</a>
                </div>
            </di");
            WriteLiteral(@"v>
        </div>

        <div class=""col-6 my-2"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Manage Inventory</h5>
                    <p class=""card-text"">Module that handles creating, reading, editing, and deleting products in inventory</p>
                    <a href=""/admin/ManageInventory"" class=""btn btn-primary"">Manage Inventory</a>
                </div>
            </div>
        </div>

        <div class=""col-6 my-2"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Manage Sales</h5>
                    <p class=""card-text"">Generate reports for various audits and logs</p>
                    <a href=""/admin/ManageSales"" class=""btn btn-primary"">Manage Sales</a>
                </div>
            </div>
        </div>

        <div class=""col-6 my-2"">
            <div class=""card"">
                <div class=""card-body"">
                   ");
            WriteLiteral(@" <h5 class=""card-title"">Return Products</h5>
                    <p class=""card-text"">Module for managing return products.</p>
                    <a href=""/admin/ReturnedProducts"" class=""btn btn-primary"">Return Products</a>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

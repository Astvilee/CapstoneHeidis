#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\_ProductCompact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e478b489116744e072dd16dc3cc4de67b23a82ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProductCompact), @"mvc.1.0.view", @"/Views/Home/_ProductCompact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e478b489116744e072dd16dc3cc4de67b23a82ed", @"/Views/Home/_ProductCompact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__ProductCompact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ProductViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <div class=\"row p-2 bg-white border rounded\">\r\n        <div class=\"col-md-3 mt-1\"><img class=\"img-fluid img-responsive rounded product-image\" src=\"https://i.imgur.com/QpjAiHq.jpg\"></div>\r\n        <div class=\"col-md-6 mt-1\">\r\n            <h5>");
#nullable restore
#line 9 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\_ProductCompact.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <div class=""mt-1 mb-1 spec-1""><span>100% cotton</span><span class=""dot""></span><span>Light weight</span><span class=""dot""></span><span>Best finish<br></span></div>
            <div class=""mt-1 mb-1 spec-1""><span>Unique design</span><span class=""dot""></span><span>For men</span><span class=""dot""></span><span>Casual<br></span></div>
            <p class=""text-justify text-truncate para mb-0"">There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.<br><br></p>
        </div>
        <div class=""align-items-center align-content-center col-md-3 border-left mt-1"">
            <div class=""d-flex flex-row align-items-center"">
                <h4 class=""mr-1"">PHP ");
#nullable restore
#line 16 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\_ProductCompact.cshtml"
                                Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
            <h6 class=""text-success"">Free shipping</h6>
            <div class=""d-flex flex-column mt-4"">
                <button class=""btn btn-primary btn-sm"" type=""button"">Add To Cart</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
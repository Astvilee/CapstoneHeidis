#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c465635f15ac719584cb0a4550bceabba999677e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Store), @"mvc.1.0.view", @"/Views/Home/Store.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c465635f15ac719584cb0a4550bceabba999677e", @"/Views/Home/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.StoreViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    h1 {
        font-size: 4rem;
        font-weight: bold;
    }
    .product-title > h4 {
        height: 50px;
        font-size: 18px;
        font-weight: bolder;
    }

    .product-description {
        height: 120px;
    }
    .item-stock {
        font-size:18px;
    }
</style>


<div class=""container"">
    <br />
    <br />
    <br />
    <br />

    <div class=""header row p-5"">
        <div class=""col-8"">
                <h1>HEIDI'S COLLECTION</h1>
                <p>At heidi's we ensure that your water is purified and taste good.</p>
        </div>
        <div class=""col-3 text-right"">
            <a href=""/Cart"">PROCEED TO CART</a>
        </div>
    </div>
    <div class=""row"">
");
#nullable restore
#line 42 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product col-3 border-left border-right mt-5 mb-5 pt-5\">\r\n                <div class=\"featured-img\">\r\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1026, "\"", 1056, 1);
#nullable restore
#line 46 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
WriteAttributeValue("", 1032, Url.Content(item.Image), 1032, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"FloWater Sierra\">\r\n                    <br />\r\n                    <br />\r\n                    <div class=\"product-title\">\r\n                        <h4>");
#nullable restore
#line 50 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                       Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                </div>\r\n                <div class=\"product-button mt-4 pb-5\">\r\n                    <div class=\"product-description\">\r\n                        <span>\r\n                            <p>");
#nullable restore
#line 56 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"product-stock\">\r\n                        <span>\r\n                            <p class=\"item-stock\">Available stocks : ");
#nullable restore
#line 61 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                                                                Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </span>\r\n                    </div>\r\n                    <p><strong>PHP ");
#nullable restore
#line 64 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                              Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                    <div>\r\n");
#nullable restore
#line 66 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                         if (item.Stock >0 )
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2015, "\"", 2031, 1);
#nullable restore
#line 68 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
WriteAttributeValue("", 2023, item.Id, 2023, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <button class=\"addtocart btn btn-info container-fluid\" type=\"submit\">ADD TO CART</button>\n");
#nullable restore
#line 70 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2271, "\"", 2287, 1);
#nullable restore
#line 72 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
WriteAttributeValue("", 2279, item.Id, 2279, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <button class=\"addtocart btn btn-info container-fluid\" type=\"submit\" disabled >ADD TO CART</button>\r\n");
#nullable restore
#line 74 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Store.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function show_toast(item, msg)
        {
            let toastBodyStart = $('<div class=""toast-body""></div>').append('<span class=""toast-message"">'+ item + '</span>' + msg);
            let toastStart = $('<div class=""toast"" data-animation=""true"" data-autohide=""true"" data-delay=""2500""></div>').append(toastBodyStart);
            $('.toast-container').append(toastStart);
            $(toastStart).on('hidden.bs.toast', function () {
                $(toastStart).remove();
            });
            $(toastStart).toast('show');
        }
        $(function () {
            $('.addtocart').on('click', function () {
                var id = $(this).parent().children('input').val();
                $.ajax({
                    type: 'POST',
                    url: ""/Home/AddToCart"",
                    data: { ""id"": id, },
                    dataType: ""json"",
                    success: function (response) {
                        if (response.success) {
            ");
                WriteLiteral(@"                show_toast(response.item,"" was successfully added to your cart!"");
                        }
                        else {
                            window.location = ""/Login""
                        }
                    }
                });
            });
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.StoreViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

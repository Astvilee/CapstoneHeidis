#pragma checksum "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452c08a7ca97bb0094bd3f2da650e817b24749e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\_ViewImports.cshtml"
using Capstone;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452c08a7ca97bb0094bd3f2da650e817b24749e2", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.CartViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
  
    double totalPrice = 0;
    for (int i = 0; i < Model.Cart.Count(); i++)
    {
        totalPrice += Model.Cart.ToList()[i].Price * Model.Cart.ToList()[i].Quantity;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h1 {
        font-size: 4rem;
        font-weight: bold;
    }

    img {
        width: 150px;
        height: 150px;
    }

    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        /* display: none; <- Crashes Chrome on hover */
        -webkit-appearance: none;
        margin: 0; /* <-- Apparently some margin are still there even though it's hidden */
    }

    input[type=number] {
        -moz-appearance: textfield; /* Firefox */
    }

    .quantity {
        pointer-events: none;
        width: 25px;
    }
</style>

<div class=""container p-5"">
    <br />
    <br />
    <br />
    <br />
    <div class=""row"">
        <div class=""col-8"">
            <h1>MY CART</h1>
        </div>
        <div class=""col-3 text-right"">
            <a href=""/Store"">CONTINUE SHOPPING</a>
        </div>
    </div>
    <div class=""row"">
        <table class=""table"">
            <thead>
                <tr>
                    <th class=""te");
            WriteLiteral(@"xt-center"">
                        Product
                    </th>
                    <th class=""text-center"">
                        Description
                    </th>
                    <th class=""text-center"">
                        Price
                    </th>
                    <th class=""text-center"">
                        Unit
                    </th>
                    <th class=""text-center"">
                        Total
                    </th>
                    <th class=""text-center"">
                        Action
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 77 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                 foreach (var item in Model.Cart)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <input type=\"hidden\" class=\"item_id\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2087, "\"", 2103, 1);
#nullable restore
#line 80 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2095, item.Id, 2095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <td style=\"width: 20%;\" class=\"text-center\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2211, "\"", 2241, 1);
#nullable restore
#line 82 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2217, Url.Content(item.Image), 2217, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mx-auto d-block img-fluid\" alt=\"...\">\r\n                        </td>\r\n                        <td style=\"width: 16%;\" class=\"align-middle text-center\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"width: 16%;\" class=\"align-middle text-center\">\r\n                            PHP ");
#nullable restore
#line 88 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                            Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td style=""width: 16%;"" class=""align-middle text-center"">
                            <button class=""subtract-button btn btn-dark"">-</button>
                            <input class=""quantity item_units unit text-center"" type=""number"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 2937, "\"", 2959, 1);
#nullable restore
#line 92 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2945, item.Quantity, 2945, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input class=\"price\" type=\"hidden\" name=\"price\"");
            BeginWriteAttribute("value", " value=\"", 3040, "\"", 3059, 1);
#nullable restore
#line 93 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3048, item.Price, 3048, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <button class=""add-button btn btn-dark"">+</button>
                        </td>
                        <td style=""width: 16%;"" class=""align-middle text-center"">
                            PHP <span class=""total_price"">");
#nullable restore
#line 97 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                                                      Write((item.Price * item.Quantity).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td style=\"width: 16%;\" class=\"align-middle text-center\">\r\n");
#nullable restore
#line 100 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                             using (Html.BeginForm())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3636, "\"", 3652, 1);
#nullable restore
#line 102 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3644, item.Id, 3644, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <button class=\"remove-item btn btn-danger\" type=\"submit\">REMOVE</button>\r\n");
#nullable restore
#line 104 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 107 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <th>TOTAL</th>\r\n                    <th>PHP <span id=\"total_cart_price\">");
#nullable restore
#line 113 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Home\Cart.cshtml"
                                                   Write(totalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></th>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"row justify-content-end\">\r\n        <button class=\"btn btn-info checkout_button\">PROCEED CHECKOUT</button>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function show_toast(msg)
        {
            let toastBodyStart = $('<div class=""toast-body""></div>').append(msg);
            let toastStart = $('<div class=""toast"" data-autohide=""true"" data-delay=""3000""></div>').append(toastBodyStart);
            $('.toast-container').append(toastStart);
            $(toastStart).on('hidden.bs.toast', function () {
                $(toastStart).remove();
                console.log('toast hidden');
            });
            $(toastStart).toast('show');
        }

        function updateTotalCartPrice() {
            let price = 0;
            let productList = $('.total_price');
            for (var i = 0; i < productList.length; i++) {
                price += parseFloat($(productList[i]).html());
            }
            $('#total_cart_price').html(price.toFixed(2));
        }

        $(function () {
            $('.checkout_button').on('click', function () {
                let productList = $('.total_price');
      ");
                WriteLiteral(@"          if (productList.length > 0) {
                    $.ajax({
                        type: 'POST',
                        url: ""/Home/CheckoutOrder"",
                        dataType: ""json"",
                        success: function (response) {
                            if (response.success) {
                                console.log('Order successfully created!');
                                window.location = ""/OrderBeingProcess"";
                            }
                            else {
                                window.location = ""/Login"";
                            }
                        }
                    });
                }
                else
                {
                    show_toast(""Your cart is currently empty, add an item to continue!"");
                }
            });

            $('.add-button').on('click', function () {
                let id = $($(this).parent()).parent().children('.item_id').val();
                let ");
                WriteLiteral(@"unit = $(this).parent().children('.unit');
                let price = $(this).parent().children('.price');
                let total_price = $($(this).parent()).parent().find('span.total_price');
                $.ajax({
                    type: 'POST',
                    url: ""/Home/AddToCart"",
                    data: { ""id"": id, },
                    dataType: ""json"",
                    success: function (response) {
                        if (response.success) {
                            let unit_value = parseInt($(unit).val());
                            $(unit).val(unit_value + 1);
                            $(total_price).html(((unit_value + 1) * parseFloat($(price).val())).toFixed(2));
                            updateTotalCartPrice();
                        }
                        else {
                            window.location = ""/Login""
                        }
                    }
                });

            });

            $('.subtract-button').on(");
                WriteLiteral(@"'click', function () {
                let button = $(this);
                let parent = $($(this).parent()).parent();
                let id = $($(this).parent()).parent().children('.item_id').val();
                let unit = $(this).parent().children('.unit');
                let price = $(this).parent().children('.price');
                let total_price = $($(this).parent()).parent().find('span.total_price');
                $.ajax({
                    type: 'POST',
                    url: ""/Home/SubtractToCart"",
                    data: { ""id"": id, },
                    dataType: ""json"",
                    success: function (response) {
                        if (response.success) {
                            let unit_value = parseInt($(unit).val());
                            $(unit).val(unit_value - 1);
                            console.log($(total_price).html());
                            $(total_price).html(((unit_value - 1) * parseFloat($(price).val())).toFixed(2));
 ");
                WriteLiteral(@"                           if (unit_value == 1) {
                                $(button).attr('disabled', true);
                                $(parent).fadeOut(300, function () {
                                    $(this).remove();
                                    updateTotalCartPrice();
                                    show_toast(""Item removed successfully!"");
                                });
                            }
                            updateTotalCartPrice();
                        }
                        else {
                            window.location = ""/Login""
                        }
                    }
                });
            });

            $('.remove-item').on('click', function () {
                let parent = $($($(this).parent()).parent()).parent();
                let id = $($($(this).parent()).parent()).parent().children('.item_id').val();
                $(this).attr('disabled', true);
                $.ajax({
                ");
                WriteLiteral(@"    type: 'POST',
                    url: ""/Home/RemoveToCart"",
                    data: { ""id"": id, },
                    dataType: ""json"",
                    success: function (response) {
                        if (response.success) {
                            $(parent).fadeOut(300, function () {
                                $(this).remove();
                                updateTotalCartPrice();
                                show_toast(""Item removed successfully!"");
                            });
                        }
                    }
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.CartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

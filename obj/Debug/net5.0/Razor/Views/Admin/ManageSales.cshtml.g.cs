#pragma checksum "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e84088058e49053b1293ab34607e0f398ba6270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageSales), @"mvc.1.0.view", @"/Views/Admin/ManageSales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e84088058e49053b1293ab34607e0f398ba6270", @"/Views/Admin/ManageSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManageSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ManageOrderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
  
    var totalSales = Model.DeliveredOrders.Sum(x => x.ProductOrders.Sum(z => z.Quantity * z.Price));
    var monthlySales = Model.DeliveredOrders.Where(x => DateTime.Parse(x.Date.Replace("DATE: ", "").Replace("TIME: ", "")).Month == DateTime.Today.Month).Sum(x => x.ProductOrders.Sum(z => z.Price * z.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"float-right\">\r\n    <h1><strong>TOTAL SALES</strong></h1>\r\n    <h4>PHP ");
#nullable restore
#line 15 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
       Write(totalSales.ToString("0,000.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    <div class=\"float-left\">\r\n        <h4><strong>MONTHLY SALES ( ");
#nullable restore
#line 26 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                               Write(DateTime.Today.ToString("MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</strong></h4>\r\n        <p>PHP ");
#nullable restore
#line 27 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
          Write(monthlySales.ToString("0,000.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Date and Time
                    </th>
                    <th class=""text-center"">
                        Email
                    </th>
                    <th class=""text-center"">
                        Phone
                    </th>
                    <th class=""text-center"">
                        Address
                    </th>
                    <th class=""text-center"">
                        Units
                    </th>
                    <th class=""text-center"">
                        Total Price
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 54 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                 foreach (var item in Model.DeliveredOrders)
                {
                    var totalUnits = item.ProductOrders.Sum(x => x.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 58 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                           Write(item.Date.Replace("DATE: ", "").Replace("TIME: ", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 59 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                           Write(item.Profile.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 60 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                           Write(item.Profile.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 61 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                           Write(item.Profile.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 62 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                           Write(totalUnits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">PHP ");
#nullable restore
#line 63 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                                               Write(item.Total.ToString("0,000.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td><strong>TOTAL</strong></td>
                    <td>
                        <strong>
                            PHP ");
#nullable restore
#line 74 "C:\Users\i5 9th gen\Desktop\TanginangCapstone\POSCapstone\Views\Admin\ManageSales.cshtml"
                           Write(totalSales.ToString("0,000.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.ManageOrderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

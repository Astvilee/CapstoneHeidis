<<<<<<< HEAD
#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef34fcc214efddc487398059f076675b90304ca"
=======
#pragma checksum "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114e782cadaf07460ea1c4e6a352229f9c6621d5"
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard), @"mvc.1.0.view", @"/Views/Admin/Dashboard.cshtml")]
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
#nullable restore
#line 2 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
using Capstone.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef34fcc214efddc487398059f076675b90304ca", @"/Views/Admin/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ManageOrderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
  

    List<UserViewModel> Users = ViewBag.Users;
    List<ManageInvetoryViewModel> ProductList = ViewBag.Products;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    p{
        font-size : 25px;
    }
    .wrap-content{
        display:grid;
        column-count: 12;
        column-gap: 15px;
    }
    .orders{
        grid-row-start : 1;
        grid-column-start : 1;
        column-gap: 15px;
        grid-column-end : 4;
    }
    .customers{
        grid-row-start: 1;
        grid-column-start: 4;
        column-gap: 15px;
        grid-column-end: 8;
    }
    .inventory {
        grid-row-start: 1;
        grid-column-start: 8;
        column-gap: 15px;
        grid-column-end: 12;
    }
</style>
<br />
<br />
<br />
<br />
");
#nullable restore
<<<<<<< HEAD
#line 41 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
=======
#line 22 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a
  
    var totalorders = @Model.PendingOrders.Count() + @Model.ShippedOrders.Count() + @Model.DeliveredOrders.Count();
    var loweststock = ProductList[0];
    var loweststockname = loweststock.BaseName;
    var loweststockcount = loweststock.Stocks;


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>ADMIN DASHBOARD</h2>\r\n<div class=\"container\">\r\n    <div class=\"wrap-content\">\r\n        <div class=\"orders\">\r\n            <h2>Orders</h2>\r\n            <p>Total Orders : ");
#nullable restore
<<<<<<< HEAD
#line 53 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                         Write(totalorders);
=======
#line 33 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                     Write(totalorders);
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Pending Orders : ");
#nullable restore
<<<<<<< HEAD
#line 54 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                           Write(Model.PendingOrders.Count());
=======
#line 34 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                       Write(Model.PendingOrders.Count());
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Shipped Orders : ");
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                           Write(Model.ShippedOrders.Count());
=======
#line 35 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                       Write(Model.ShippedOrders.Count());
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Delivered Orders: ");
#nullable restore
<<<<<<< HEAD
#line 56 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                            Write(Model.DeliveredOrders.Count());
=======
#line 36 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                        Write(Model.DeliveredOrders.Count());
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <div class=\"customers\">\r\n            <h2>Customers</h2>\r\n            <p>Total registered user : ");
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                                  Write(Users.Count());
=======
#line 43 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                              Write(Users.Count());
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <div class=\"inventory\">\r\n            <h2>Inventory</h2>\r\n            <p>Lowest stock in inventory:  </p>\r\n            <p>Item name : ");
#nullable restore
<<<<<<< HEAD
#line 71 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                      Write(loweststockname);
=======
#line 51 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                  Write(loweststockname);
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Stocks left: ");
#nullable restore
<<<<<<< HEAD
#line 72 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\Dashboard.cshtml"
                       Write(loweststockcount);
=======
#line 52 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Admin\Dashboard.cshtml"
                   Write(loweststockcount);
>>>>>>> fda001f3621aa2d5bf11edd7bdebc9629268a33a

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

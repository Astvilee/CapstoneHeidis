#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d5292ec460379fadd4947830d3ef99c4ea28af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageInventory), @"mvc.1.0.view", @"/Views/Admin/ManageInventory.cshtml")]
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
#line 2 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
using Capstone.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5292ec460379fadd4947830d3ef99c4ea28af4", @"/Views/Admin/ManageInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManageInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ManageInvetoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
  
    ViewData["Title"] = "Inventory";
    List<ManageInvetoryViewModel> ListOfProduct = ViewBag.ListOfProduct;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<br />
<div class=""container"">
    <div class=""modal fade"" id=""UpdateProductModal"" >
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header""></div>
                <h2 class=""modal-title"">Update Product</h2>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5292ec460379fadd4947830d3ef99c4ea28af44368", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"Id\" id=\"id\" />\r\n                        <label>Product Name</label>\r\n                        ");
#nullable restore
#line 21 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                   Write(Html.TextBoxFor(m => m.BaseName,new {@class="form-control",@id="BaseName"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <label>Price</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                   Write(Html.TextBoxFor(m => m.Price,new {@class="form-control",@id="Price"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <label>Stocks</label>\r\n                        ");
#nullable restore
#line 25 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                   Write(Html.TextBoxFor(m => m.Stocks,new {@class="form-control",@id="Stocks"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <div class=""btn-group"">
                        <a href=""#"" id=""btnSave"" class=""btn btn-primary mr-2"">Update</a>
                        <a href=""#"" id=""btnCancel"" class=""btn btn-danger"">Cancel</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Product Name
                    </th>
                    <th>
                        Price
                    </th>
                    <th>
                        Stocks
                    </th>
                    <th class=""text-center"">
                        Action
                    </th>
                </tr>
            </thead>
          <tbody>
");
#nullable restore
#line 57 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
               foreach (var item in ListOfProduct){

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2159, "\"", 2175, 1);
#nullable restore
#line 59 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
WriteAttributeValue("", 2167, item.Id, 2167, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <td>\r\n                          ");
#nullable restore
#line 61 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                     Write(item.BaseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </td>\r\n                      <td>\r\n                          ");
#nullable restore
#line 64 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </td>\r\n                      <td>\r\n                          ");
#nullable restore
#line 67 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
                     Write(item.Stocks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                      </td>
                      <td>
                           <a href=""#"" class=""btn btn-success text-center EditButton"" data-toggle=""modal"" data-target=""#UpdateProductModal"" >Edit</a>
                      </td>
                  </tr>
");
#nullable restore
#line 73 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageInventory.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $("".EditButton"").click(function () {
                var elements = $(this).parent().parent().children();
                console.log(elements);
                $(""#id"").val(elements[0].value);
                $(""#BaseName"").val(elements[1].innerText);
                $(""#Price"").val(elements[2].innerText);
                $(""#Stocks"").val(elements[3].innerText);
            });

            $(""#btnSave"").click(function(){
                var updateDate = $(""#updateForm"").serialize();
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/UpdateInventory"",
                    data: updateDate,
                    success:function(res){
                        console.log(res);

                        window.location.href=""/Admin/ManageInventory"";
                    },  
                     error: function (res) {
                        console.log(res);

                        window.location.");
                WriteLiteral("href = \"/Admin/ManageInventory\";\r\n                    }\r\n                });\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.ManageInvetoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

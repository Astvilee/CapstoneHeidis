#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1663557c3ec01ca22feffd7e6a89ec5ec3f31dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1663557c3ec01ca22feffd7e6a89ec5ec3f31dcb", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.ProfileViewModel>
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
            WriteLiteral("\r\n");
            WriteLiteral(@"<br/>
<br/>
<br/>
<br/>
<br/>
<div class=""modal fade"" id=""UpdateProfile"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header""></div>
            <h2 class=""modal-title"">Update Profile</h2>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1663557c3ec01ca22feffd7e6a89ec5ec3f31dcb3809", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.HiddenFor(m=>m.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.HiddenFor(m=>m.Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label>Email address: </label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.TextBoxFor(m => m.EmailAddress,new {@class="form-control",@id="Email"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label>Phone</label>\r\n                    ");
#nullable restore
#line 22 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.TextBoxFor(m => m.PhoneNumber,new {@class="form-control",@id="Phone"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label>Password</label>\r\n                    ");
#nullable restore
#line 24 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.TextBoxFor(m => m.Password,new {@class="form-control",@id="Password",type="password"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label>Street Address</label>\r\n                    ");
#nullable restore
#line 26 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.TextBoxFor(m => m.StreetAddress,new {@class="form-control",@id="StreetAddress"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label>Barangay</label>\r\n                    ");
#nullable restore
#line 28 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
               Write(Html.TextBoxFor(m => m.Barangay,new {@class="form-control",@id="Barangay"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
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

<div class=""container"">
    <h1>My Profile</h1>
    <p>Email Address: ");
#nullable restore
#line 43 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
                 Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Phone Number: ");
#nullable restore
#line 44 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
                Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n    <p>Address: ");
#nullable restore
#line 45 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
           Write(Model.StreetAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 45 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Home\Profile.cshtml"
                                 Write(Model.Barangay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <button class=\"btn-primary UpdateButton\" data-toggle=\"modal\" data-target=\"#UpdateProfile\">Edit profile.</button>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
          $(""#btnSave"").click(function () {
               var updateDate = $(""#updateForm"").serialize();
                $.ajax({
                    type: ""POST"",
                    url: ""/Home/UpdateInfo"",
                    data: updateDate,
                    success: function (res) {
                        console.log(res);
                        window.location.href = ""/Home/Logout"";
                    },
                    error: function (res) {
                        console.log(res);

                        window.location.href = ""/Home/Logout"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.ProfileViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

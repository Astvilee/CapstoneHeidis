#pragma checksum "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "174206dda30d4e4d49f568fc94ac144e54dd05a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174206dda30d4e4d49f568fc94ac144e54dd05a1", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.LoginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .login-form {
    }

    .error-text {
        color: #ff0000;
    }

    .validation-summary-errors li {
        color: #ff0000;
    }
</style>
    
<div class=""container"">
    <div class=""login-form container-fluid p-5 mx-auto my-5 justify-content-center"">
");
#nullable restore
#line 21 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
         using (Html.BeginForm("LoginUser", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1");
            BeginWriteAttribute("class", " class=\"", 469, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral(">Login</h1>\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"row\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
                   Write(Html.ValidationSummary(false, "", new { @class = "error-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 33 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">                            \r\n                            ");
#nullable restore
#line 36 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control",@data_val = "true", @data_val_required = "Email is required." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">                          \r\n                            ");
#nullable restore
#line 46 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", type = "password",@data_val = "true", @data_val_required = "Password is required."}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            
                        </div>
                    </div>

                </div>
            </div>
            <br />
            <button type=""submit"" class=""btn btn-primary px-5"">Login</button>
            <a class=""btn btn-primary"" t href=""/Home/ForgotPassword"">Forgot password?</a>
");
#nullable restore
#line 56 "C:\Users\reden\source\repos\CapstoneHeidis\Views\Home\Login.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.LoginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

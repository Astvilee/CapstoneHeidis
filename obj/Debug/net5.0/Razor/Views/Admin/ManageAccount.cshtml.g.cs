#pragma checksum "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61338b58bd3815287ea1c7030085cd95871090d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageAccount), @"mvc.1.0.view", @"/Views/Admin/ManageAccount.cshtml")]
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
#line 2 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
using Capstone.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61338b58bd3815287ea1c7030085cd95871090d", @"/Views/Admin/ManageAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129d3f6a7fa42dff58258173de55e0d6be154790", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ManageAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone.ViewModels.UserViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
  
    ViewData["Title"] = "Register";
    List<UserViewModel> ListOfUsers = ViewBag.ListOfUsers;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .register-form {
    }

    .error-text {
        color: #ff0000;
    }

    .validation-summary-errors li {
        color: #ff0000;
    }
</style>
<div class=""container"">
    <div class=""register-form container-fluid p-5 mx-auto my-5 justify-content-center"">
");
#nullable restore
#line 22 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
         using (Html.BeginForm("CreateOrUpdate", "Admin", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1");
            BeginWriteAttribute("class", " class=\"", 565, "\"", 573, 0);
            EndWriteAttribute();
            WriteLiteral(">Manage Account</h1>\r\n            <br />\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 27 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "error-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "error-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 55 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "error-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-3\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.LabelFor(m => m.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row col-md-9\">\r\n                            ");
#nullable restore
#line 66 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.TextBoxFor(m => m.StreetAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 67 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                       Write(Html.ValidationMessageFor(m => m.StreetAddress, "", new { @class = "error-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-3"">
                            <label for=""Street"">Barangay</label>
                        </div>
                        <div class=""row col-md-9"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61338b58bd3815287ea1c7030085cd95871090d10252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 76 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Barangay);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.BarangayList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-3"">
                            <label for=""Street"">Role</label>
                        </div>
                        <div class=""row col-md-9"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61338b58bd3815287ea1c7030085cd95871090d12602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 85 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Role);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 85 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.RoleList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                    </div>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-primary px-5"">CREATE OR UPDATE</button>
            <br />
            <br />
            <br />
            <br />
");
#nullable restore
#line 95 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""row"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th class=""text-center"">
                            ID
                        </th>
                        <th class=""text-center"">
                            Role
                        </th>
                        <th class=""text-center"">
                            Email Address
                        </th>
                        <th class=""text-center"">
                            Phone Number
                        </th>
                        <th class=""text-center"">
                            Address
                        </th>
                        <th class=""text-center"">
                            Action
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 122 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                     foreach (var item in ListOfUsers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"width: 6%;\" class=\"text-center\">\r\n                                ");
#nullable restore
#line 126 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 8%;\" class=\"align-middle text-center\">\r\n                                ");
#nullable restore
#line 129 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                           Write(item.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 15%;\" class=\"align-middle text-center\">\r\n                                ");
#nullable restore
#line 132 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 15%;\" class=\"align-middle text-center\">\r\n                                ");
#nullable restore
#line 135 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 24%;\" class=\"align-middle text-center\">\r\n                                ");
#nullable restore
#line 138 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                            Write($"{item.StreetAddress} {item.Barangay}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 32%;\" class=\"align-middle text-center\">\r\n                                <input type=\"hidden\" class=\"user-id\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 5958, "\"", 5974, 1);
#nullable restore
#line 141 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 5966, item.Id, 5966, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-role\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6062, "\"", 6080, 1);
#nullable restore
#line 142 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6070, item.Role, 6070, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-email\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6169, "\"", 6188, 1);
#nullable restore
#line 143 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6177, item.Email, 6177, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-phone\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6277, "\"", 6296, 1);
#nullable restore
#line 144 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6285, item.Phone, 6285, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-password\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6388, "\"", 6410, 1);
#nullable restore
#line 145 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6396, item.Password, 6396, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-street\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6500, "\"", 6527, 1);
#nullable restore
#line 146 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6508, item.StreetAddress, 6508, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" class=\"user-barangay\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 6619, "\"", 6641, 1);
#nullable restore
#line 147 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
WriteAttributeValue("", 6627, item.Barangay, 6627, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 148 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                                 if (!item.Email.Equals(ViewBag.Email))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button class=\"edit-user btn btn-success\" type=\"submit\"><small>EDIT</small></button>\r\n                                    <button class=\"remove-user btn btn-danger\" type=\"submit\"><small>REMOVE</small></button>\r\n");
#nullable restore
#line 152 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 155 "C:\Users\i5 9th gen\source\repos\HeidisCapstoneProject\Views\Admin\ManageAccount.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function show_toast(msg) {
            let toastBodyStart = $('<div class=""toast-body""></div>').append(msg);
            let toastStart = $('<div class=""toast"" data-autohide=""true"" data-delay=""3000""></div>').append(toastBodyStart);
            $('.toast-container').append(toastStart);
            $(toastStart).on('hidden.bs.toast', function () {
                $(toastStart).remove();
                console.log('toast hidden');
            });
            $(toastStart).toast('show');
        }

        $(function () {
            $('.edit-user').on('click', function () {
                let id = $(this).parent().find('.user-id').val();
                let role = $(this).parent().find('.user-role').val();
                let email = $(this).parent().find('.user-email').val();
                let password = $(this).parent().find('.user-password').val();
                let phone = $(this).parent().find('.user-phone').val();
                let street = $(this).parent()");
                WriteLiteral(@".find('.user-street').val();
                let barangay = $(this).parent().find('.user-barangay').val();
                console.log(id);
                $('#Id').val(id);
                $('#Role').val(role);
                $('#Email').val(email);
                $('#Phone').val(phone.replaceAll(' ', ''));
                $('#Password').val(password);
                $('#StreetAddress').val(street);
                $.ajax({
                    type: 'post',
                    url: ""/admin/getbarangay"",
                    data: { ""barangay"": barangay, ""role"": role },
                    datatype: ""json"",
                    success: function (response) {
                        if (response.success) {
                            $('#Barangay').val(response.barangay).change();
                            $('#Role').val(response.role).change();
                        }
                    }
                });
            });
            $('.remove-user').on('click', function () {
 ");
                WriteLiteral(@"               let parent = $($(this).parent()).parent();
                let id = $(this).parent().find('input').val();
                $(this).attr('disabled', true);
                $.ajax({
                    type: 'post',
                    url: ""/admin/removeuser"",
                    data: { ""id"": id, },
                    datatype: ""json"",
                    success: function (response) {
                        if (response.success) {
                            $(parent).fadeOut(300, function () {
                                $(this).remove();
                                show_toast(""User removed successfully!"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone.ViewModels.UserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

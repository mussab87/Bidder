#pragma checksum "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b0b765ba81dcf3477ffd4b559d7c52d1fa45f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permissions_AddPermission), @"mvc.1.0.view", @"/Views/Permissions/AddPermission.cshtml")]
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
#line 1 "D:\Projects\Bidder\Bidder.DashBoard\Views\_ViewImports.cshtml"
using Bidder.DashBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Bidder\Bidder.DashBoard\Views\_ViewImports.cshtml"
using Bidder.DashBoard.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
using Bidder.DashBoard.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
using Bidder.Data.HelpersAttributes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b0b765ba81dcf3477ffd4b559d7c52d1fa45f9", @"/Views/Permissions/AddPermission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e0334c902f1da49cff4097ce913b9bdea97a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Permissions_AddPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bidder.DashBoard.ViewModels.RoleAccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
  
    ViewBag.Title = "?????????? ????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"widget-content widget-content-area col-12\">\r\n    <h4> ");
#nullable restore
#line 11 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
    Write(_shardLocalizer.GetLocalizedString("ManagePermission"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n");
#nullable restore
#line 13 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
      
        var lang = Convert.ToString(HttpContextAccessor.HttpContext.Request.Cookies["lang"]);
        if (lang == "ar-SA")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"text-muted\" style=\"list-style: none\">\r\n                <li style=\"text-align: center\">");
            WriteLiteral(" <strong style=\"color: red\">");
#nullable restore
#line 18 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                                                                                       Write(Model.Roles.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n            </ul>\r\n");
#nullable restore
#line 20 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"text-muted\" style=\"list-style: none\">\r\n                <li style=\"text-align: center\">");
            WriteLiteral(" <strong style=\"color: red\">");
#nullable restore
#line 24 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                                                                                       Write(Model.Roles.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n            </ul>\r\n");
#nullable restore
#line 26 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n");
#nullable restore
#line 30 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
     using (Html.BeginForm("SaveRolePermission", "Permissions"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
   Write(Html.HiddenFor(m => m.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-2\">\r\n            <div class=\"card-header\">\r\n                <h4>");
#nullable restore
#line 35 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
               Write(_shardLocalizer.GetLocalizedString("RemovePermission"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9""></div>
                    <div class=""col-3"">
                        <a class=""btn btn-primary btn-sm mb-2 btn-block"" id=""selectAllRemovePermission"">");
#nullable restore
#line 41 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                                                                   Write(_shardLocalizer.GetLocalizedString("SelectAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </div>
                </div>
                <div class=""table-responsive mb-4 mt-4"">

                    <table class=""table table-hover non-hover"" id=""removePermission"" style=""width: 100%"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>");
#nullable restore
#line 50 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("EnglishName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 51 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("ArabicName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n\r\n");
#nullable restore
#line 59 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                             foreach (var per in Model.GetPermissions)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <input type=\"checkbox\" name=\"permissionIds\"");
            BeginWriteAttribute("id", " id=\"", 2657, "\"", 2683, 2);
            WriteAttributeValue("", 2662, "PermissionIds_", 2662, 14, true);
#nullable restore
#line 63 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
WriteAttributeValue("", 2676, per.Id, 2676, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2684, "\"", 2699, 1);
#nullable restore
#line 63 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
WriteAttributeValue("", 2692, per.Id, 2692, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                   Write(per.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                   Write(per.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 73 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"card mb-2\">\r\n            <div class=\"card-header\">\r\n                <h4>");
#nullable restore
#line 82 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
               Write(_shardLocalizer.GetLocalizedString("AddPermissionToRole"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9""></div>
                    <div class=""col-3"">
                        <a class=""btn btn-primary btn-sm mb-2 btn-block"" id=""selectAllAddPermissionToRole"">");
#nullable restore
#line 88 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                                                                      Write(_shardLocalizer.GetLocalizedString("SelectAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </div>
                </div>
                <div class=""table-responsive mb-4 mt-4"">
  
                    <table class=""table table-hover non-hover"" id=""addPermissionToRole"" style=""width: 100%"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>");
#nullable restore
#line 97 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("EnglishName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 98 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("ArabicName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 103 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                             foreach (var noR in Model.noGetPermissions)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <input type=\"checkbox\" name=\"permissionIds\"");
            BeginWriteAttribute("id", " id=\"", 4620, "\"", 4646, 2);
            WriteAttributeValue("", 4625, "PermissionIds_", 4625, 14, true);
#nullable restore
#line 107 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
WriteAttributeValue("", 4639, noR.Id, 4639, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4647, "\"", 4662, 1);
#nullable restore
#line 107 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
WriteAttributeValue("", 4655, noR.Id, 4655, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 110 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                   Write(noR.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 113 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                   Write(noR.NameAr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 117 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 123 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group col-md-12\">\r\n            <button type=\"submit\" class=\"btn btn-success\">");
#nullable restore
#line 125 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                     Write(_shardLocalizer.GetLocalizedString("BtnSave"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b0b765ba81dcf3477ffd4b559d7c52d1fa45f917321", async() => {
                WriteLiteral(" ");
#nullable restore
#line 126 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
                                                                            Write(_shardLocalizer.GetLocalizedString("BtnBack"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 128 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\AddPermission.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#selectAllRemovePermission').click(function () {
                var checkboxes = document.getElementsByTagName('input');
                if ($(this).hasClass('allChecked')) {
                    //for (var i = 0; i < checkboxes.length; i++) {
                    //    if (checkboxes[i].type == 'checkbox') {
                    //        checkboxes[i].checked = false;
                    //    }
                    //}
                } else {
                    for (var i = 0; i < checkboxes.length; i++) {
                        if (checkboxes[i].type == 'checkbox') {
                            checkboxes[i].checked = true;
                        }
                    }
                }
                $(this).toggleClass('allChecked');
            });


            $('#selectAllAddPermissionToRole').click(function () {
                var checkboxes = document.getElementsByTagName('input');
                if (");
                WriteLiteral(@"$(this).hasClass('allChecked')) {
                    //for (var i = 0; i < checkboxes.length; i++) {
                    //    if (checkboxes[i].type == 'checkbox') {
                    //        checkboxes[i].checked = false;
                    //    }
                    //}
                } else {
                    for (var i = 0; i < checkboxes.length; i++) {
                        if (checkboxes[i].type == 'checkbox') {
                            checkboxes[i].checked = true;
                        }
                    }
                }
                $(this).toggleClass('allChecked');
            });

        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Bidder.DashBoard.Resources.SharedViewLocalizer _shardLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bidder.DashBoard.ViewModels.RoleAccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

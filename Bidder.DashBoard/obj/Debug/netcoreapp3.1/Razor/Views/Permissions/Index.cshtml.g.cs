#pragma checksum "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b3e179f22663a72c018ebd425a985765b58c34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Permissions_Index), @"mvc.1.0.view", @"/Views/Permissions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b3e179f22663a72c018ebd425a985765b58c34", @"/Views/Permissions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e0334c902f1da49cff4097ce913b9bdea97a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Permissions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bidder.Data.Entities.Permission>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"widget-content widget-content-area col-12\">\r\n    <h4>");
#nullable restore
#line 8 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
   Write(_shardLocalizer.GetLocalizedString("ManagePermission"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b3e179f22663a72c018ebd425a985765b58c344944", async() => {
#nullable restore
#line 10 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                                              Write(_shardLocalizer.GetLocalizedString("BtnCreate"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a href=\"/Permissions/GetAllControllerActionsUpdated\" class=\"btn btn-primary\">");
#nullable restore
#line 11 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                                                                                 Write(_shardLocalizer.GetLocalizedString("CheckPermissions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        <hr />
        <div class=""table-responsive mb-4 mt-4"">
            <table id=""html5-extension"" class=""table table-hover non-hover"" style=""width: 100%"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 18 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                       Write(_shardLocalizer.GetLocalizedString("PermissionArabicName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 22 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                       Write(_shardLocalizer.GetLocalizedString("PermissionEnglishName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                       Write(_shardLocalizer.GetLocalizedString("PermissionController"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 30 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                       Write(_shardLocalizer.GetLocalizedString("PermissionAction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NameAr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Controller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b3e179f22663a72c018ebd425a985765b58c3410560", async() => {
                WriteLiteral(@"
                                    <span class=""icon-container"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit""><path d=""M11 4H4a2 2 0 0 0-2 2v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2v-7""></path><path d=""M18.5 2.5a2.121 2.121 0 0 1 3 3L12 15l-4 1 1-4 9.5-9.5z""></path></svg>
                                    </span>
                                    ");
#nullable restore
#line 57 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("BtnEdit"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a class=\"btn btn-danger btn-sm btn-block\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3152, "\"", 3184, 3);
            WriteAttributeValue("", 3162, "deleteRecord(", 3162, 13, true);
#nullable restore
#line 59 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
WriteAttributeValue("", 3175, item.Id, 3175, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3183, ")", 3183, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""icon-container"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-trash-2""><polyline points=""3 6 5 6 21 6""></polyline><path d=""M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2""></path><line x1=""10"" y1=""11"" x2=""10"" y2=""17""></line><line x1=""14"" y1=""11"" x2=""14"" y2=""17""></line></svg>
                                    </span>
                                
                                    ");
#nullable restore
#line 64 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                               Write(_shardLocalizer.GetLocalizedString("BtnDelete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 68 "D:\Projects\Bidder\Bidder.DashBoard\Views\Permissions\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'.table\').DataTable();\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Bidder.DashBoard.Resources.SharedViewLocalizer _shardLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bidder.Data.Entities.Permission>> Html { get; private set; }
    }
}
#pragma warning restore 1591

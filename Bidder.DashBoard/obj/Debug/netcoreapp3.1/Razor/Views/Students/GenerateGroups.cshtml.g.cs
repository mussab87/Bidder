#pragma checksum "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdee3ae8623b6757ff0d57cc010a269f68c2117e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_GenerateGroups), @"mvc.1.0.view", @"/Views/Students/GenerateGroups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdee3ae8623b6757ff0d57cc010a269f68c2117e", @"/Views/Students/GenerateGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e0334c902f1da49cff4097ce913b9bdea97a88", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_GenerateGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bidder.DashBoard.Dtos.StudentDtos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""widget-content widget-content-area col-12"">
    <div class=""table-responsive mb-4 mt-4"">
        <table id=""html5-extension"" class=""table table-hover non-hover"" style=""width: 100%"">
            <thead>
                <tr>
                    <th>
                        <p>رقم التسجيل</p>
                    </th>
                    <th>
                        <p>إسم المتقدم</p>
                    </th>
                    <th>
                        <p>الهوية الوطنية</p>
                    </th>
                    <th>
                        <p>الوزن</p>
                    </th>
                    <th>
                        <p>الطول</p>
                    </th>
                    <th>
                        <p>مستوى الفحص الطبي</p>
                    </th>

                    <th>
                        السلاح
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 37 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CandidatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MedicalTestLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Weapon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "D:\Projects\Bidder\Bidder.DashBoard\Views\Students\GenerateGroups.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bidder.DashBoard.Dtos.StudentDtos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
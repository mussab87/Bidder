#pragma checksum "D:\Projects\Bidder\Bidder.DashBoard\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a5d6c4e63795ab4db06324bcf993742db6658fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#line 1 "D:\Projects\Bidder\Bidder.DashBoard\Views\_ViewStart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a5d6c4e63795ab4db06324bcf993742db6658fb", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e0334c902f1da49cff4097ce913b9bdea97a88", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\Bidder\Bidder.DashBoard\Views\_ViewStart.cshtml"
  
    var lang=Convert.ToString(HttpContextAccessor.HttpContext.Request.Cookies["lang"]);
    if(lang == null)
    {
        CookieOptions option = new CookieOptions();
        option.Expires = DateTime.Now.AddDays(20);
        HttpContextAccessor.HttpContext.Response.Cookies.Append("lang", "ar-SA", option);
        Layout = "~/Views/Shared/_LayoutAr.cshtml";
    }
    if (lang == "ar-SA")
    {
        Layout = "~/Views/Shared/_LayoutAr.cshtml";
    }
    else
    {
        Layout = "~/Views/Shared/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c51eaac6a190a61707be3304250b767cb51be41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Account_Login), @"mvc.1.0.view", @"/Areas/Identity/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Account/Login.cshtml", typeof(AspNetCore.Areas_Identity_Views_Account_Login))]
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
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\_ViewImports.cshtml"
using app;

#line default
#line hidden
#line 2 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\_ViewImports.cshtml"
using app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c51eaac6a190a61707be3304250b767cb51be41", @"/Areas/Identity/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Areas/Identity/Views/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<app.Areas.Identity.Models.loginUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\Login.cshtml"
  
  Layout = "~/Views/Shared/_layout.cshtml";
  ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(128, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(135, 17, false);
#line 7 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(164, 19, false);
#line 8 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\Login.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(183, 27, true);
            WriteLiteral("</h3>\r\n\r\n<div>\r\n<p>Welcome ");
            EndContext();
            BeginContext(211, 14, false);
#line 11 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Identity\Views\Account\Login.cshtml"
      Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(225, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<app.Areas.Identity.Models.loginUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

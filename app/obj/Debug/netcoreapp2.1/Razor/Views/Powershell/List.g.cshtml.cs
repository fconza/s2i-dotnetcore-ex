#pragma checksum "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Powershell\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15f0f8b4466b83343bd9d396e17e9960954f479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Powershell_List), @"mvc.1.0.view", @"/Views/Powershell/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Powershell/List.cshtml", typeof(AspNetCore.Views_Powershell_List))]
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
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\_ViewImports.cshtml"
using app;

#line default
#line hidden
#line 2 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\_ViewImports.cshtml"
using app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15f0f8b4466b83343bd9d396e17e9960954f479", @"/Views/Powershell/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Powershell_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Powershell\List.cshtml"
  
  ViewData["Title"] = "Powershell";

#line default
#line hidden
            BeginContext(44, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 5 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Powershell\List.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(80, 19, false);
#line 6 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Powershell\List.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 60, true);
            WriteLiteral("</h3>\r\n\r\n<div>\r\n<p>Find following Powershell packages for : ");
            EndContext();
            BeginContext(160, 26, false);
#line 9 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Powershell\List.cshtml"
                                       Write(ViewData["powershellname"]);

#line default
#line hidden
            EndContext();
            BeginContext(186, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
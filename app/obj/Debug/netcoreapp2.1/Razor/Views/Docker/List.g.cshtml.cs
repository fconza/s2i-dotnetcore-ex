#pragma checksum "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1698005494776d72ce9962f4965c22f36190416"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Docker_List), @"mvc.1.0.view", @"/Views/Docker/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Docker/List.cshtml", typeof(AspNetCore.Views_Docker_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1698005494776d72ce9962f4965c22f36190416", @"/Views/Docker/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Docker_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Docker.Models.repoUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
  
  ViewData["Title"] = "Docker";

#line default
#line hidden
            BeginContext(71, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(78, 17, false);
#line 6 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(95, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(107, 19, false);
#line 7 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(126, 54, true);
            WriteLiteral("</h3>\r\n\r\n<div>\r\n<p>Find following Docker images for : ");
            EndContext();
            BeginContext(181, 22, false);
#line 10 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
                                 Write(ViewData["dockername"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 17, true);
            WriteLiteral("</p>\r\n<p>Model : ");
            EndContext();
            BeginContext(221, 5, false);
#line 11 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
      Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(226, 65, true);
            WriteLiteral("</p>\r\n<table style=\"width:50%\">\r\n  <tr>\r\n    <th rowspan=\"2\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 291, "\"", 310, 1);
#line 14 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
WriteAttributeValue("", 297, Model.Avatar, 297, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(311, 65, true);
            WriteLiteral(" alt=\"Avatar Image\" width=\"50\" height=\"50\"></th>\r\n    <td>Name : ");
            EndContext();
            BeginContext(377, 10, false);
#line 15 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(387, 41, true);
            WriteLiteral(" </td>\r\n  </tr>\r\n  <tr>\r\n    <td>Email : ");
            EndContext();
            BeginContext(429, 11, false);
#line 18 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Views\Docker\List.cshtml"
           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(440, 37, true);
            WriteLiteral(" </td>\r\n  </tr>\r\n</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Docker.Models.repoUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
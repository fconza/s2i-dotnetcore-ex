#pragma checksum "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Maven\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4205c4bd8f2976a5f4079367294bf15a6e9851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Maven_Views_Index), @"mvc.1.0.view", @"/Areas/Maven/Views/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Maven/Views/Index.cshtml", typeof(AspNetCore.Areas_Maven_Views_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c4205c4bd8f2976a5f4079367294bf15a6e9851", @"/Areas/Maven/Views/Index.cshtml")]
    public class Areas_Maven_Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Maven\Views\Index.cshtml"
  

  ViewData["Title"] = "Docker";

#line default
#line hidden
            BeginContext(42, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 6 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Maven\Views\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(78, 19, false);
#line 7 "C:\Private\Git_Repo\s2i-dotnetcore-ex\app\Areas\Maven\Views\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 294, true);
            WriteLiteral(@"</h3>

<div>
<p>Test .Net core application</p>
</div>
<div>
  <form action=""/Maven/List"" >
    <label for=""dname"">Maven Packages Name</label>
    <input type=""text"" id=""dname"" name=""mavenname"" placeholder=""maven:latest .."">
    <input type=""submit"" value=""Submit"">
  </form>
</div>
");
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

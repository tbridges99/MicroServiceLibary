#pragma checksum "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ca9972a65fe1069afa52c1330f3f689ff336c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\_ViewImports.cshtml"
using Hackathon;

#line default
#line hidden
#line 2 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\_ViewImports.cshtml"
using Hackathon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ca9972a65fe1069afa52c1330f3f689ff336c5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1280e001f064c3d40730d8c27d96fc536eaf7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "BHHC Service Directory";

#line default
#line hidden
            BeginContext(83, 513, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-3"">
            <h2>Search</h2>
            <div class=""input-group"">
                <input class=""form-control"" type=""text"" id=""search"" name=""search"" placeholder=""enter Search Term(s)"" title=""enter Search Term(s)"">
                <span class=""input-group-btn"">
                    <button class=""btn btn-secondary"">Search</button>
                </span>
            </div>
        </div>
    </div>
    <div class=""row"">
");
            EndContext();
#line 19 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
         foreach (var dto in Model)
        {

#line default
#line hidden
            BeginContext(644, 193, true);
            WriteLiteral("            <div class=\"col-md-3\" style=\"padding-bottom: 6px;\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(838, 8, false);
#line 24 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
                                          Write(dto.Name);

#line default
#line hidden
            EndContext();
            BeginContext(846, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(899, 15, false);
#line 25 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
                                        Write(dto.Description);

#line default
#line hidden
            EndContext();
            BeginContext(914, 30, true);
            WriteLiteral("</p>\r\n                        ");
            EndContext();
            BeginContext(945, 98, false);
#line 26 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
                   Write(Html.ActionLink(dto.DevURL, "Detail", "Home", new { id=dto.Id }, new { @class="btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\eneff\source\repos\MicroServiceLibary\Hackathon\Hackathon\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1128, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServiceDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\__temp\MicroServiceLibary-eneff-work\Hackathon\Hackathon\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea3d05e6333bdcee5501841ede9ca4b4ca48807"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\__temp\MicroServiceLibary-eneff-work\Hackathon\Hackathon\Views\_ViewImports.cshtml"
using Hackathon;

#line default
#line hidden
#line 2 "C:\__temp\MicroServiceLibary-eneff-work\Hackathon\Hackathon\Views\_ViewImports.cshtml"
using Hackathon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea3d05e6333bdcee5501841ede9ca4b4ca48807", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"793605a08a66d7a43a86a8f914b921497e372700", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\__temp\MicroServiceLibary-eneff-work\Hackathon\Hackathon\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail for Service Entry";

#line default
#line hidden
            BeginContext(75, 30, true);
            WriteLiteral("\n<h2>Detail for Service Entry ");
            EndContext();
            BeginContext(106, 10, false);
#line 6 "C:\__temp\MicroServiceLibary-eneff-work\Hackathon\Hackathon\Views\Home\Detail.cshtml"
                        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(116, 3042, true);
            WriteLiteral(@"</h2>

<div class=""row"">
    <div class=""col"">
        <div class=""row"">
            <div class=""col"">Development URL</div>
            <div class=""col"">
                <div class=""input-group"">
                    <input class=""form-control"" type=""text"" id=""devurl"" name=""devurl"" placeholder=""enter Development URL"" title=""enter Development URL"">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">Name</div>
            <div class=""col""><input class=""form-control"" type=""text"" id=""name"" name=""name"" placeholder=""enter Name"" title=""enter Name""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Description</div>
            <div class=""col""><input class=""form-control"" type=""text"" id=""description"" name=""description"" placeholder=""enter Description"" title=""enter Description""></div>
        </div>
        <div class=""row"">
            <div class=""col"">QA Url</div>
            <div class=""col""><input class=""form-control"" type=""text"" ");
            WriteLiteral(@"id=""qaurl"" name=""qaurl"" placeholder=""enter QA URL"" title=""enter QA URL""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Is Legacy</div>
            <div class=""col""><input class=""form-control"" type=""checkbox"" id=""islegacy"" name=""islegacy""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Is Generated</div>
            <div class=""col""><input class=""form-control"" type=""checkbox"" id=""isgenerated"" name=""isgenerated""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Team</div>
            <div class=""col""><input class=""form-control"" type=""text"" id=""team"" name=""team"" placeholder=""enter Team"" title=""enter Team""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Contact</div>
            <div class=""col""><input class=""form-control"" type=""text"" id=""contact"" name=""contact"" placeholder=""enter Contact"" title=""enter Contact""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Email</div>
 ");
            WriteLiteral(@"           <div class=""col""><input class=""form-control"" type=""text"" id=""email"" name=""email"" placeholder=""enter Email"" title=""enter Email""></div>
        </div>
        <div class=""row"">
            <div class=""col"">Current Version</div>
            <div class=""col""><input class=""form-control"" type=""text"" id=""currentversion"" name=""currentversion"" placeholder=""enter Current Version"" title=""enter Current Version""></div>
        </div>
        <div class=""row"">
            <div class=""col"">JWT Required</div>
            <div class=""col""><input class=""form-control"" type=""checkbox"" id=""isjwt"" name=""isjwt""></div>
        </div>
    </div>

    <div class=""col"">
        <div class=""row"">
            <div class=""col"">Keywords</div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <textarea class=""form-control"" type=""textarea"" id=""keywords"" name=""keywords"" placeholder="""" title="""" rows=""18""></textarea>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591

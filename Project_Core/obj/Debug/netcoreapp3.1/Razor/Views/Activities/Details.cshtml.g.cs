#pragma checksum "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c954f3a463d878505be431e723b5c0e281a2170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_Details), @"mvc.1.0.view", @"/Views/Activities/Details.cshtml")]
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
#line 1 "E:\repos\Project_Core\Project_Core\Views\_ViewImports.cshtml"
using Project_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repos\Project_Core\Project_Core\Views\_ViewImports.cshtml"
using Project_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c954f3a463d878505be431e723b5c0e281a2170", @"/Views/Activities/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ac8e866d4afaef93294f4d7a34bd5b7c5eee9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Core.DAL.Models.Activities>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details Activities</h1>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
           Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 32 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
Write(Html.ActionLink(" ", "Edit", "Activities", new { id = Model.Id, }, new { @class = "btn btn-primary btn-sm fas fa-pen-square" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 33 "E:\repos\Project_Core\Project_Core\Views\Activities\Details.cshtml"
Write(Html.ActionLink(" ", "Index", "Activities", null, new { @class = "btn btn-primary fas fa-chevron-circle-left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Core.DAL.Models.Activities> Html { get; private set; }
    }
}
#pragma warning restore 1591

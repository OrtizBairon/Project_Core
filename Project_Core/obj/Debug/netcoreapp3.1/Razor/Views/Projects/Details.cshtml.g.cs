#pragma checksum "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "affef156521286dddd5df123e713a1a65d1d3413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"affef156521286dddd5df123e713a1a65d1d3413", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ac8e866d4afaef93294f4d7a34bd5b7c5eee9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCore.Logica.Models.ViewModel.ProjectsDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 12 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 17 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 22 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.ExpectedCompletionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.ExpectedCompletionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 27 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 32 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n<div class=\"form-group\">\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 40 "E:\repos\Project_Core\Project_Core\Views\Projects\Details.cshtml"
   Write(Html.ActionLink(" ", "Index", "Projects", null, new { @class = "btn btn-primary fas fa-chevron-circle-left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCore.Logica.Models.ViewModel.ProjectsDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

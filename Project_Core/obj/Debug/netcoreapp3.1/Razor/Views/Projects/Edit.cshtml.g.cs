#pragma checksum "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13d3e71237f30906243de1d68b7192f69445f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13d3e71237f30906243de1d68b7192f69445f7a", @"/Views/Projects/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ac8e866d4afaef93294f4d7a34bd5b7c5eee9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCore.Logica.Models.BindingModel.ProjectsEditBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Projects/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f13d3e71237f30906243de1d68b7192f69445f7a4079", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 10 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 14 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 15 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 16 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 24 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.LabelFor(model => model.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.EditorFor(model => model.Details, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 26 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 33 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.LabelFor(model => model.ExpectedCompletionDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 34 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.EditorFor(model => model.ExpectedCompletionDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 35 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.ExpectedCompletionDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-12\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">\r\n                <i class=\"far fa-save\"> </i>\r\n            </button>\r\n            ");
#nullable restore
#line 45 "E:\repos\Project_Core\Project_Core\Views\Projects\Edit.cshtml"
       Write(Html.ActionLink(" ", "Index", "Projects", null, new { @class = "btn btn-primary fas fa-chevron-circle-left" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCore.Logica.Models.BindingModel.ProjectsEditBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716dd7fa3ba009f68069287833b4698dc574f8b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DWThemeplate.Main.Pages.Projects.Pages_Projects_list), @"mvc.1.0.razor-page", @"/Pages/Projects/list.cshtml")]
namespace DWThemeplate.Main.Pages.Projects
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
#line 1 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/_ViewImports.cshtml"
using DWThemeplate.Main;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716dd7fa3ba009f68069287833b4698dc574f8b1", @"/Pages/Projects/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb5fad37c5d0c7684ed1b7ef259b6330ff5463", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<h1> Yoo u can search my Projectss</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716dd7fa3ba009f68069287833b4698dc574f8b13381", async() => {
                WriteLiteral("\n    <div class=\"from-group\">\n        <div class=\"input-group\">\n            <input type=\"search\" class=\"from-control\"");
                BeginWriteAttribute("value", " value=\"", 234, "\"", 242, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"searchTerm\" />\n            <span class=\"input-group-brtn\">\n                <button class=\"btn btn-default\">\n                    <i class=\"fas fa-search\"></i>\n                </button>\n            </span>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table>\n");
#nullable restore
#line 22 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
     foreach (var item in @Model.Projects)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <thead>\n\n            <tr>\n                <th>");
#nullable restore
#line 27 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
               Write(item.ProjectsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <tr>\n\n            <tr>\n                <th>\n\n");
#nullable restore
#line 33 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
                     foreach (var languages in item.Language)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\n                            ");
#nullable restore
#line 36 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
                       Write(languages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </a>\n");
#nullable restore
#line 38 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n            </tr>\n\n            <tr>\n                <th>");
#nullable restore
#line 44 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
               Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            </tr>\n\n            <tr>\n                <th>\n                    <a class=\"btn btn-lg\"\n                       style=\"background-color: blue;\"");
            BeginWriteAttribute("href", "\n                       href=\"", 1132, "\"", 1188, 2);
            WriteAttributeValue("", 1162, "/Projects/details/", 1162, 18, true);
#nullable restore
#line 51 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
WriteAttributeValue("", 1180, item.Id, 1180, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <i class=\"glyphicon glyphicon-zoom-in\"></i>\n                    </a>\n\n                    <a class=\"btn btn-lg\"\n                       style=\"background-color: yellow;\"");
            BeginWriteAttribute("href", "\n                       href=\"", 1383, "\"", 1436, 2);
            WriteAttributeValue("", 1413, "/Projects/edit/", 1413, 15, true);
#nullable restore
#line 57 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
WriteAttributeValue("", 1428, item.Id, 1428, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <i class=\"glyphicon glyphicon-zoom-in\"></i>\n                    </a>\n\n                </th>\n            </tr>\n\n        </thead>\n");
#nullable restore
#line 65 "/home/dzape/Documents/DWThemeplateWebApp/DWThemeplate.Main/Pages/Projects/list.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DWThemeplate.Pages.Projects.listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DWThemeplate.Pages.Projects.listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DWThemeplate.Pages.Projects.listModel>)PageContext?.ViewData;
        public DWThemeplate.Pages.Projects.listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
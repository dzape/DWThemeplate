#pragma checksum "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b4412dac6f97e37325e9248c6a45fe7136d211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DWWebApp.Pages.Projects.Pages_Projects_list), @"mvc.1.0.razor-page", @"/Pages/Projects/list.cshtml")]
namespace DWWebApp.Pages.Projects
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
#line 1 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\_ViewImports.cshtml"
using DWWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b4412dac6f97e37325e9248c6a45fe7136d211", @"/Pages/Projects/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71084b428c644fec467efec57cf68f1723f5c63", @"/Pages/_ViewImports.cshtml")]
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
            WriteLiteral("\r\n<h1> Yoo u can search my Projectss</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61b4412dac6f97e37325e9248c6a45fe7136d2113382", async() => {
                WriteLiteral("\r\n    <div class=\"from-group\">\r\n        <div class=\"input-group\">\r\n            <input type=\"search\" class=\"from-control\"");
                BeginWriteAttribute("value", " value=\"", 216, "\"", 224, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"searchTerm\" />\r\n            <span class=\"input-group-brtn\">\r\n                <button class=\"btn btn-default\">\r\n                    <i class=\"fas fa-search\"></i>\r\n                </button>\r\n            </span>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n<table>\r\n");
#nullable restore
#line 22 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
     foreach (var item in @Model.Projects)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <thead>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 27 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
               Write(item.ProjectsName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <tr>\r\n\r\n            <tr>\r\n                <th>\r\n\r\n");
#nullable restore
#line 33 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
                     foreach (var languages in item.Language)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\r\n                            ");
#nullable restore
#line 36 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
                       Write(languages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 38 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>");
#nullable restore
#line 44 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
               Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>\r\n                    <a class=\"btn btn-lg\"\r\n                       style=\"background-color: blue;\"");
            BeginWriteAttribute("href", "\r\n                       href=\"", 1153, "\"", 1210, 2);
            WriteAttributeValue("", 1184, "/Projects/details/", 1184, 18, true);
#nullable restore
#line 51 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
WriteAttributeValue("", 1202, item.Id, 1202, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"glyphicon glyphicon-zoom-in\"></i>\r\n                    </a>\r\n\r\n                    <a class=\"btn btn-lg\"\r\n                       style=\"background-color: yellow;\"");
            BeginWriteAttribute("href", "\r\n                       href=\"", 1410, "\"", 1464, 2);
            WriteAttributeValue("", 1441, "/Projects/edit/", 1441, 15, true);
#nullable restore
#line 57 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
WriteAttributeValue("", 1456, item.Id, 1456, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"glyphicon glyphicon-zoom-in\"></i>\r\n                    </a>\r\n\r\n                </th>\r\n            </tr>\r\n\r\n        </thead>\r\n");
#nullable restore
#line 65 "E:\Development\Dotnet\DWThemeplate\DWWebApp\Pages\Projects\list.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<listModel>)PageContext?.ViewData;
        public listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
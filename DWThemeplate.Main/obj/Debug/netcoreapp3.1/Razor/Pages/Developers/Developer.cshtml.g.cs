#pragma checksum "/home/dzape/DWThemeplate/DWThemeplate.Main/Pages/Developers/Developer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5efd20db9fdf9691b032eb21fed4b5b412d828fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DWThemeplate.Main.Pages.Developers.Pages_Developers_Developer), @"mvc.1.0.razor-page", @"/Pages/Developers/Developer.cshtml")]
namespace DWThemeplate.Main.Pages.Developers
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
#line 1 "/home/dzape/DWThemeplate/DWThemeplate.Main/Pages/_ViewImports.cshtml"
using DWThemeplate.Main;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5efd20db9fdf9691b032eb21fed4b5b412d828fc", @"/Pages/Developers/Developer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb5fad37c5d0c7684ed1b7ef259b6330ff5463", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Developers_Developer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/dzape/DWThemeplate/DWThemeplate.Main/Pages/Developers/Developer.cshtml"
Write(Model.message);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeveloperModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeveloperModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeveloperModel>)PageContext?.ViewData;
        public DeveloperModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
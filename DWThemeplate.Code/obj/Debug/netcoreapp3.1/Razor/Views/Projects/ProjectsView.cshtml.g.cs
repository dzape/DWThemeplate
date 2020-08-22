#pragma checksum "/home/dzape/DWThemeplate/DWThemeplate.Core/Views/Projects/ProjectsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4bd51af6f4f3ec91c85017257a4bbeac8c3e84f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_ProjectsView), @"mvc.1.0.view", @"/Views/Projects/ProjectsView.cshtml")]
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
#line 1 "/home/dzape/DWThemeplate/DWThemeplate.Core/Views/_ViewImports.cshtml"
using DWThemeplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dzape/DWThemeplate/DWThemeplate.Core/Views/_ViewImports.cshtml"
using DWThemeplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bd51af6f4f3ec91c85017257a4bbeac8c3e84f", @"/Views/Projects/ProjectsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a36d259a02c763acd317743b55dd29a4b6582c2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_ProjectsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul id=\"project-list\"></ul>\n<ul id=\"project-list\">Test\n</ul>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script type=""text/javascript"">
    $(function () {
        $.get('/api/project/').done(function (projects) {
            $.each(projects, function (i, projects) {
                var item = `<li>
                            <strong>${projects.make} ${projects.model}</strong>
                            (£${projects.append})</li>`;
                $('#project-list').append(item);
            });
        });
    });
</script>
");
            }
            );
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
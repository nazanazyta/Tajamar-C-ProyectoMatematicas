#pragma checksum "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb3381f8e5efc7e7bd63fa9e2aa49ed47a5589b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matematicas_CollatzPaco), @"mvc.1.0.view", @"/Views/Matematicas/CollatzPaco.cshtml")]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\_ViewImports.cshtml"
using ProyectoMatematicas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\_ViewImports.cshtml"
using ProyectoMatematicas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb3381f8e5efc7e7bd63fa9e2aa49ed47a5589b", @"/Views/Matematicas/CollatzPaco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7621cb76ff106b7b8ab31904fb03fe56478a294c", @"/Views/_ViewImports.cshtml")]
    public class Views_Matematicas_CollatzPaco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>CollatzPaco</h1>\r\n<br />\r\n");
            WriteLiteral("<div style=\"float: left; padding: 20px\">\r\n    <ul>\r\n");
#nullable restore
#line 9 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
         foreach (int num in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
#nullable restore
#line 12 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
           Write(Html.ActionLink(num.ToString(), "CollatzPaco", "Matematicas", new { numero = num }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 14 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
#nullable restore
#line 17 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
  
    List<int> numeroscollatz = ViewData["collatz"] as List<int>;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"float: left; padding: 20px\">\r\n");
#nullable restore
#line 24 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
     if (numeroscollatz != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 27 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
             foreach (int num in numeroscollatz)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 29 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
               Write(num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 30 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 32 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\CollatzPaco.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
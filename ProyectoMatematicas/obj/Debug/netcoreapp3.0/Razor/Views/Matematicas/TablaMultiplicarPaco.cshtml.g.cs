#pragma checksum "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3927c2439d3b727fd03b157b1a647d833d51b023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matematicas_TablaMultiplicarPaco), @"mvc.1.0.view", @"/Views/Matematicas/TablaMultiplicarPaco.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3927c2439d3b727fd03b157b1a647d833d51b023", @"/Views/Matematicas/TablaMultiplicarPaco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7621cb76ff106b7b8ab31904fb03fe56478a294c", @"/Views/_ViewImports.cshtml")]
    public class Views_Matematicas_TablaMultiplicarPaco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FilaMultiplicar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>TablaMultiplicarPaco</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3927c2439d3b727fd03b157b1a647d833d51b0233744", async() => {
                WriteLiteral("\r\n    <label>Número: </label>\r\n    <input type=\"text\" name=\"numero\" class=\"form-control\" /><br />\r\n    <button type=\"submit\" class=\"btn-info\">Tabla de multiplicar</button>\r\n");
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
            WriteLiteral("\r\n<hr/>\r\n");
#nullable restore
#line 10 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
 if(Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-dark\">\r\n        <thead>\r\n            <tr>\r\n                <th>Operación</th>\r\n                <th>Resultado</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
             foreach (FilaMultiplicar fila in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
                   Write(fila.Operacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
                   Write(fila.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 29 "C:\Users\AlumnoMCSD\source\repos\ProyectoMatematicas\ProyectoMatematicas\Views\Matematicas\TablaMultiplicarPaco.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FilaMultiplicar>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ivan.tapia\source\Examen Prueba\Nomina2\Nomina2\Views\Empleado\_FechasSueldosVP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552766a06ae8cd964a97cb71eb44cd0724230a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado__FechasSueldosVP), @"mvc.1.0.view", @"/Views/Empleado/_FechasSueldosVP.cshtml")]
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
#line 1 "C:\Users\ivan.tapia\source\Examen Prueba\Nomina2\Nomina2\Views\_ViewImports.cshtml"
using Nomina2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivan.tapia\source\Examen Prueba\Nomina2\Nomina2\Views\_ViewImports.cshtml"
using Nomina2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552766a06ae8cd964a97cb71eb44cd0724230a67", @"/Views/Empleado/_FechasSueldosVP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec411e13feb8d1def703967f70f8b83b74b5e152", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado__FechasSueldosVP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <!-- formulario fecha y sueldos -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a673457", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <!-- primer col -->
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""exampleFormControlSelect1"">Tipo de contrato</label>
                <select class=""form-control form-control-lg"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a674010", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a675050", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a676090", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Fecha de Ingreso</label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Fecha de Antiguedad</label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">
                    Fecha de vencimiento de
                    contrato
                </label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Fecha de Planta</");
                WriteLiteral(@"label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">
                    Fecha Antiguedad en el
                    Puesto
                </label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Fecha de Nacimiento</label>
                <input type=""date""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">
                    Fecha Reservada
                </label>
                <input type=""date""
                       class=""form-control""
                       id=""");
                WriteLiteral("exampleInputEmail1\" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlSelect1\">Compañia</label>\r\n                <select class=\"form-control form-control-lg\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a679550", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6710590", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6711631", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlSelect1\">Localidad</label>\r\n                <select class=\"form-control form-control-lg\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6712910", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6713951", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6714992", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlSelect1\">Dirección</label>\r\n                <select class=\"form-control form-control-lg\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6716271", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6717312", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552766a06ae8cd964a97cb71eb44cd0724230a6718353", async() => {
                    WriteLiteral("Large select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
        </div>
        <!-- end primer col -->
        <!-- segundo col  -->
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Subdirección</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Departamento</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Puesto</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Niv");
                WriteLiteral(@"el Tabulador</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Categoria Sueldo</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Turno</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Duración Plaza</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""examp");
                WriteLiteral(@"leInputEmail1"">Clave Registro Patronal</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Centro de Beneficio</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Tipo de Nómina</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Zona Salario Minimo</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
        </div>
    </div>
");
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <h3>Sueldos</h3>
            <hr />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Sueldo Mensual</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Sueldo Diario</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Sueldo Diario Integrado</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
 ");
                WriteLiteral(@"               <label for=""exampleInputEmail1"">Integrado Sin Tope</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Parte Fija</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Parte Variable</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Factor de Integracion</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
        ");
                WriteLiteral(@"    <div class=""form-group"">
                <label for=""exampleInputEmail1"">Variable Bimestre Anterior</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Dias Bimestre Anterior</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Integrado Infonavit</label>
                <input type=""text""
                       class=""form-control""
                       id=""exampleInputEmail1"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

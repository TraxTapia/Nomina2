#pragma checksum "C:\Users\ivan.tapia\source\Examen Prueba\Nomina2\Nomina2\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1d79350b26e5efa35facd015aba9bcebb9d456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1d79350b26e5efa35facd015aba9bcebb9d456", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec411e13feb8d1def703967f70f8b83b74b5e152", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ivan.tapia\source\Examen Prueba\Nomina2\Nomina2\Views\Empleado\Index.cshtml"
  
        var _ListCategory = new List<SelectListItem>();
        if (ViewBag.Select != null)
        {
            _ListCategory = (List<SelectListItem>)ViewBag.Select;
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""#"">Nomina</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">
                        Consulta Empleados
                    </li>
                </ol>
            </nav>
        </div>
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""container"">
                        <div class=""row mt-3"">
                            <div class=""col-md-12"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""text-center"">Juan Pablo segundo</h4>
                                    </div>
                                    <div class=""card-body"">
              ");
            WriteLiteral(@"                          <div class=""container"">
                                            <div class=""row"">
                                                <div class=""col-md-4"">
                                                    <p>Nombre: <b>Juan</b></p>
                                                    <p>Apellidos:<b>Pablo</b></p>
                                                    <p>Apellido materno:<b>segundo</b></p>
                                                </div>
                                                <div class=""col-md-4"">
                                                    <p>Código Empresa: <b>10000</b></p>
                                                    <p>Posición (Plaza):<b>0001</b></p>
                                                    <p>Estatus: <b><span class=""badge badge-success"">Activo</span></b></p>
                                                </div>
                                                <div class=""col-md-4"">
                         ");
            WriteLiteral(@"                           <img style=""width: 150px !important""
                                                         class=""rounded-circle w-100""
                                                         src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgYpOOYgMxD_FO9y7jYv2F_DwMnnVMBj8rWQ&usqp=CAU""
                                                         alt=""..."" />
                                                </div>
                                            </div>
                                            <div class=""row d-flex justify-content-end align-items-center"">
                                                <span><i class=""bx bx-save""></i></span>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-md-12"">
                                                    <nav>
                                                        <div class=""nav nav-tabs"" id");
            WriteLiteral(@"=""nav-tab"" role=""tablist"">
                                                            <a class=""nav-item nav-link active"" id=""nav-ubicacion-tab"" data-toggle=""tab"" href=""#nav-ubicacion"" role=""tab"" aria-controls=""nav-ubicacion"" aria-selected=""true"">Ubicacións</a>
                                                            <a class=""nav-item nav-link"" id=""nav-fiscalesPersonales-tab"" data-toggle=""tab"" href=""#nav-fiscalesPersonales"" role=""tab"" aria-controls=""nav-fiscalesPersonales"" aria-selected=""false"">Fiscales Personales</a>
                                                            <a class=""nav-item nav-link"" id=""nav-fechasSueldos-tab"" data-toggle=""tab"" href=""#nav-fechasSueldos"" role=""tab"" aria-controls=""nav-fechasSueldos"" aria-selected=""false"">Fechas y Suledos </a>
                                                        </div>
                                                    </nav>
                                                    <div class=""tab-content"" id=""nav-tabContent"">
                   ");
            WriteLiteral(@"                                     <div class=""tab-pane fade show active"" id=""nav-ubicacion"" role=""tabpanel"" aria-labelledby=""nav-ubicacion-tab""></div>
                                                        <div class=""tab-pane fade"" id=""nav-fiscalesPersonales"" role=""tabpanel"" aria-labelledby=""nav-fiscalesPersonales-tab"">noooo</div>
                                                        <div class=""tab-pane fade"" id=""nav-fechasSueldos"" role=""tabpanel"" aria-labelledby=""nav-fechasSueldos-tab"">hi</div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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

#pragma checksum "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93ef702052213cc586c73be9f3489dc15609ba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Editar), @"mvc.1.0.view", @"/Views/Empleado/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93ef702052213cc586c73be9f3489dc15609ba9", @"/Views/Empleado/Editar.cshtml")]
    #nullable restore
    public class Views_Empleado_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaWebEmpleado.Models.Empleado>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
  
    ViewData["Title"] = "Editar";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Editar empleado</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
 using (Html.BeginForm("Editar", "Empleado", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <p>\r\n        ");
#nullable restore
#line 11 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                     <p>\r\n        ");
#nullable restore
#line 16 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                     <p>\r\n        ");
#nullable restore
#line 21 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n        ");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n        ");
#nullable restore
#line 31 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.FechaNacimiento, new { type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </p>\r\n                    <p>\r\n        ");
#nullable restore
#line 36 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.LabelFor(model=>model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.TextBoxFor(model=>model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model=>model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </p>\r\n");
            WriteLiteral("                        <input type=\"submit\"  action=\"Editar\" />\r\n");
#nullable restore
#line 45 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
Write(Html.ActionLink("Volver a Index", "Index", "Empleado"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Usuario\OneDrive\Escritorio\Bootcamp C#\Web Api .NET Core\SistemaWebEmpleado\SistemaWebEmpleado\Views\Empleado\Editar.cshtml"
                                                           
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaWebEmpleado.Models.Empleado> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

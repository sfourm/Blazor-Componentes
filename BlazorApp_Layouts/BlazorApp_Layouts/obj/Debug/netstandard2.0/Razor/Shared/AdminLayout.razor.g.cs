#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\Shared\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d97d2ce94c1e4872a4d072df0eabb1e5d41ef44"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Layouts.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using BlazorApp_Layouts;

#line default
#line hidden
#line 7 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\_Imports.razor"
using BlazorApp_Layouts.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<div class=\"row bg-primary text-white\">\r\n            <div class=\"col-sm-12\">\r\n                <h2>Área do Administrador</h2>\r\n            </div>\r\n        </div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-sm-12");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddContent(10, 
#line 12 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\BlazorApp_Layouts\BlazorApp_Layouts\Shared\AdminLayout.razor"
                 Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

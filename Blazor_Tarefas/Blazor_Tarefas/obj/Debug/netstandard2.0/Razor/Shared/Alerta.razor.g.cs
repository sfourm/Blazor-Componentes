#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f154693590192b11d868b3ec52e746053064b0"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Tarefas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#line 7 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#line 8 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Entidades;

#line default
#line hidden
    public partial class Alerta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-danger mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-circle-x mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#line 3 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
             Mensagem

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
       
      [Parameter] public string Mensagem { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

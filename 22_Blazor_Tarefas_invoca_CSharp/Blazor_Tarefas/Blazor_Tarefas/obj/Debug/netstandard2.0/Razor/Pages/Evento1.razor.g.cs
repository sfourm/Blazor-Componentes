#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Pages\Evento1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffff29d315ad0b1de68e0ad95588dea444e198b0"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Tarefas.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#line 7 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#line 8 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Entidades;

#line default
#line hidden
#line 9 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Repositorios;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/evento1")]
    public partial class Evento1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label>Dados de eventos : Pressione a Tecla A para mudar a cor</label>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "background-color:" + " " + (
#line 5 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Pages\Evento1.razor"
                               cor

#line default
#line hidden
            ) + ";" + " padding:" + " 50px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 7 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Pages\Evento1.razor"
                                  e=> TeclaPressionada(e)

#line default
#line hidden
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Pages\Evento1.razor"
       
    private string cor = "red";

    void TeclaPressionada(KeyboardEventArgs args)
    {
        if(args.Key =="A" || args.Key=="a")
        {
            cor = "blue";
            Console.WriteLine("A tecla A/a foi pressionada");
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

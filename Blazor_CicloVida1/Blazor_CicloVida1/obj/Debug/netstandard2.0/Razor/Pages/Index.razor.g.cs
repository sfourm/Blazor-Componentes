#pragma checksum "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d453ed70194dcd4211fcef7217c41f15a8c3faa1"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_CicloVida1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Blazor_CicloVida1;

#line default
#line hidden
#line 7 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\_Imports.razor"
using Blazor_CicloVida1.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#line 4 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\Pages\Index.razor"
     Titulo

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, "Fui renderizado as ");
            __builder.AddContent(5, 
#line 5 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\Pages\Index.razor"
                        HoraRenderizacao

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\_blazor\Blazor_CicloVida1\Blazor_CicloVida1\Pages\Index.razor"
      
    private string Titulo { get; set; }
    private string HoraRenderizacao { get; set; }

    protected override void OnInitialized()
    {
        HoraRenderizacao = DateTime.Now.ToLongTimeString();
        Console.WriteLine($"Iniciação do Componente : às {HoraRenderizacao}");
        Titulo = "OLá Blazor";
    }

    protected override void OnParametersSet()
    {
        HoraRenderizacao = DateTime.Now.ToLongTimeString();
        Console.WriteLine($"Executei OnParameterSet : às {HoraRenderizacao} ");
        Console.WriteLine(" --> Recebimento dos parâmetros do componente Pai");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        HoraRenderizacao = DateTime.Now.ToLongTimeString();
        Console.WriteLine($"Executei OnAfterRender : Primeira vez = {firstRender}");
        Console.WriteLine($" --> Término da renderização do componente : às {HoraRenderizacao}");
    }

    public void Dispose()
    {
        HoraRenderizacao = DateTime.Now.ToLongTimeString();
        Console.WriteLine($" --> Liberação do componente : às {HoraRenderizacao}");
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9519a8025b202bec4f0bd487a5bf178bb3192aa6"
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
    public partial class Tarefas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#line 3 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
     Titulo

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Ação</th>\r\n            <th>Data</th>\r\n            <th>Descriçao</th>\r\n            <th>Concluida</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n        ");
            __Blazor.Blazor_Tarefas.Shared.Tarefas.TypeInference.CreateListaGenerica_0(__builder, 9, 10, 
#line 15 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                  tarefas

#line default
#line hidden
            , 11, (tarefa) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Blazor_Tarefas.Shared.TarefaIndividual>(13);
                __builder2.AddAttribute(14, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor_Tarefas.Entidades.Tarefa>(
#line 17 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                        tarefa

#line default
#line hidden
                ));
                __builder2.AddAttribute(15, "RemoverTarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazor_Tarefas.Entidades.Tarefa>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazor_Tarefas.Entidades.Tarefa>(this, 
#line 17 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                                               RemoveTarefa

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<Blazor_Tarefas.Shared.Confirma>(20);
            __builder.AddAttribute(21, "onCancela", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 23 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                        CancelaConfirmacao

#line default
#line hidden
            )));
            __builder.AddAttribute(22, "onConfirma", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 24 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                      RemoverTarefaConfirmacao

#line default
#line hidden
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.AddMarkupContent(25, "<div>Deseja Excluir esta tarefa ?</div>\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(26, (__value) => {
#line 23 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                confirmacao = (Blazor_Tarefas.Shared.Confirma)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n");
#line 28 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
 if (tarefas != null)
{

#line default
#line hidden
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.AddMarkupContent(32, "<label>Tarefa</label>\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "Text");
            __builder.AddAttribute(35, "placeholder", "Informe a tarefa");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 32 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                                                 novaTarefa

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
                                                  AdicionarNovaTarefa

#line default
#line hidden
            ));
            __builder.AddContent(42, "Registrar Tarefa");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#line 35 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 37 "C:\Users\samue\Documents\GitHub\Blazor - Componentes\Blazor-Componentes\22_Blazor_Tarefas_invoca_CSharp\Blazor_Tarefas\Blazor_Tarefas\Shared\Tarefas.razor"
      

    [Parameter] public List<Tarefa> tarefas { get; set; }
    [Parameter] public string Titulo { get; set; }

    private string novaTarefa = "";

    //instancia do componente Confirma 
    Confirma confirmacao;

    Tarefa tarefaRemover;

    private void RemoveTarefa(Tarefa tarefa)
    {
        //confirmacao.Exibir();
        //tarefaRemover = tarefa;
        //var resultado =
        //    await js.InvokeAsync<bool>("confirm", "Excluir Tarefa ?");

        var resultado = ((IJSInProcessRuntime)js).Invoke<bool>("confirm", "Excluir esta tarefa ?");

        if(resultado)
        {
            tarefas.Remove(tarefa);
            //await js.InvokeVoidAsync("alert", "Tarefa excluida com sucesso");
            //await js.InvokeAsync<object>("MostraAlerta", "Ok, tarefa excluida !!!");
        }
    }

    void RemoverTarefaConfirmacao()
    {
        tarefas.Remove(tarefaRemover);
        tarefaRemover = null;
        confirmacao.Ocultar();
    }

    void CancelaConfirmacao()
    {
        confirmacao.Ocultar();
        tarefaRemover = null;
    }

    static int totalTarefas = 0;
    async void AdicionarNovaTarefa()
    {
        if (!string.IsNullOrWhiteSpace(novaTarefa))
        {
            tarefas.Add(new Tarefa
            {
                DataCriacao = DateTime.Now,
                Descricao = novaTarefa,
                ID = Guid.NewGuid()
            });
            novaTarefa = "";
            totalTarefas = tarefas.Count();

            //await js.InvokeVoidAsync("getTotalTarefas");
            await js.InvokeAsync<int>("getTotalTarefasInstancia", DotNetObjectReference.Create(this));


        }
    }

    [JSInvokable]
    public Task<int> ObterTotalTarefasInstancia()
    {
        return Task.FromResult(totalTarefas);
    }

    [JSInvokable]
    public static Task<int> ObterTotalTarefas()
    {
        return Task.FromResult(totalTarefas);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.Blazor_Tarefas.Shared.Tarefas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListaGenerica_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::Blazor_Tarefas.Shared.ListaGenerica<Titem>>(seq);
        __builder.AddAttribute(__seq0, "ListaItem", __arg0);
        __builder.AddAttribute(__seq1, "Lista", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

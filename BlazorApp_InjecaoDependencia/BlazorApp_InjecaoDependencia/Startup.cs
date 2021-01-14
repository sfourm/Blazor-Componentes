using BlazorApp_InjecaoDependencia.Servicos;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp_InjecaoDependencia
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServicoSingleton>();
            services.AddScoped<ServicoScoped>();
            services.AddTransient<ServicoTransient>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

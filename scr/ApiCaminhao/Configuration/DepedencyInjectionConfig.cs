using Business.Interfaces;
using Business.Notificacoes;
using Business.Services;
using c;
using Data.Repository;
using Microsoft.Extensions.Options;

namespace ApiCaminhao.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            services.AddScoped<INotificador, Notificador>();


            return services;
        }
    }
}

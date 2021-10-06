using Microsoft.Extensions.DependencyInjection;
using SisEscola.Cadastro.Domain.Models.Interfaces;
using SisEscola.Cadastro.Domain.Notificacoes;
using SisEscola.Cadastro.Domain.Notificacoes.Interfaces;
using SisEscola.Cadastro.Domain.Services;
using SisEscola.Cadastro.Domain.Services.Interfaces;
using SisEscola.Cadastro.Infra.Data.Context;
using SisEscola.Cadastro.Infra.Data.Repository;

namespace SisEscola.Cadastro.Infra.CrossCutting.ModuleInjection
{
    public static class InjectionServices
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<SisEscolaDbContext>();

            return services;
        }
    }
}

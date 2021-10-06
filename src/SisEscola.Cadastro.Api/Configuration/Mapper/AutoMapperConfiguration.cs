using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SisEscola.Cadastro.Api.Models;
using SisEscola.Cadastro.Domain.Models;

namespace SisEscola.Cadastro.Api.Configuration.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<AlunoViewModel, Aluno>().ReverseMap();
            CreateMap<ResponsavelViewModel, Responsavel>().ReverseMap();
            CreateMap<ParentescoViewModel, Parentesco>().ReverseMap();
            CreateMap<SegmentoViewModel, Segmento>().ReverseMap();
        }
    }

    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new AutoMapperConfiguration());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SisEscola.Cadastro.Api.Models;
using SisEscola.Cadastro.Domain.Models;
using SisEscola.Cadastro.Domain.Notificacoes.Interfaces;
using SisEscola.Cadastro.Domain.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/alunos")]
    public class AlunosController : MainController
    {
        private readonly IAlunoService _alunoService;
        private readonly IMapper _mapper;

        public AlunosController(IAlunoService alunoService,
                                IMapper mapper,
                                INotificador notificador) : base(notificador)
        {
            _alunoService = alunoService;
            _mapper = mapper;
        }

        [HttpPost("listar-alunos-filtro")]
        public async Task<IEnumerable<AlunoViewModel>> ListarAlunosPorFiltro(FiltroViewModel filtroViewModel)
        {
            return _mapper.Map<IEnumerable<AlunoViewModel>>(await _alunoService.ObterAlunosComFiltro(tipoFiltro: filtroViewModel.TipoFiltro.ToString(),
                                                                                                     consulta: filtroViewModel.Consulta));

        }

        [HttpGet("listar-alunos")]
        public async Task<IEnumerable<AlunoViewModel>> ListarAlunos()
        {
            return _mapper.Map<IEnumerable<AlunoViewModel>>(await _alunoService.ObterAlunos());
        }


        [HttpGet("listar-responsaveis")]
        public async Task<IEnumerable<ResponsavelViewModel>> ListarResponsaveis()
        {
            return _mapper.Map<IEnumerable<ResponsavelViewModel>>(await _alunoService.ObterResponsaveis());
        }

        [HttpPost]
        public async Task<ActionResult<AlunoViewModel>> CadastrarAluno(AlunoViewModel alunoViewModel)
        {
            return CustomResponse(_mapper.Map<AlunoViewModel>(await _alunoService.Adicionar(_mapper.Map<Aluno>(alunoViewModel))));

        }

    }
}

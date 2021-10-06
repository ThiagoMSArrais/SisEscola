using SisEscola.Cadastro.Domain.Models;
using SisEscola.Cadastro.Domain.Models.Interfaces;
using SisEscola.Cadastro.Domain.Notificacoes.Interfaces;
using SisEscola.Cadastro.Domain.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Domain.Services
{
    public class AlunoService : BaseService, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository,
                            INotificador notificador) : base(notificador)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<Aluno> Adicionar(Aluno aluno)
        {
            if (!aluno.EhValido())
                Notificar(aluno.ValidationResult);

            return await _alunoRepository.Adicionar(aluno);
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _alunoRepository.ObterAlunos();
        }

        public async Task<IEnumerable<Aluno>> ObterAlunosComFiltro(string tipoFiltro, string consulta)
        {
            return await _alunoRepository.ObterAlunosComFiltro(tipoFiltro, consulta);
        }

        public async Task<IEnumerable<Responsavel>> ObterResponsaveis()
        {
            return await _alunoRepository.ObterResponsaveis();
        }
    }
}

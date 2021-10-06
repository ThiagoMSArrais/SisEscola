using SisEscola.Cadastro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Domain.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<Aluno> Adicionar(Aluno aluno);
        Task<IEnumerable<Aluno>> ObterAlunos();
        Task<IEnumerable<Responsavel>> ObterResponsaveis();
        Task<IEnumerable<Aluno>> ObterAlunosComFiltro(string tipoFiltro, string consulta);
    }
}

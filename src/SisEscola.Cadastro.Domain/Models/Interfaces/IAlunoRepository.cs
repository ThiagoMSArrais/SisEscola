using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Domain.Models.Interfaces
{
    public interface IAlunoRepository
    {
        Task<Aluno> Adicionar(Aluno aluno);
        Task<IEnumerable<Aluno>> ObterAlunos();
        Task<IEnumerable<Responsavel>> ObterResponsaveis();
    }
}

using Microsoft.EntityFrameworkCore;
using SisEscola.Cadastro.Domain.Models;
using SisEscola.Cadastro.Domain.Models.Interfaces;
using SisEscola.Cadastro.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Infra.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly SisEscolaDbContext _sisEscolaDbContext;

        public AlunoRepository(SisEscolaDbContext sisEscolaDbContext)
        {
            _sisEscolaDbContext = sisEscolaDbContext;
        }

        public async Task<Aluno> Adicionar(Aluno aluno)
        {
            await _sisEscolaDbContext.AddAsync(aluno);
            await _sisEscolaDbContext.SaveChangesAsync();

            return aluno;
        }

        public async Task<IEnumerable<Aluno>> ObterAlunos()
        {
            return await _sisEscolaDbContext.Alunos.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Aluno>> ObterAlunosComFiltro(string tipoFiltro, string consulta)
        {
            return await _sisEscolaDbContext.Alunos.Where(e => e.GetType().GetProperty(tipoFiltro).GetValue(tipoFiltro).ToString() == consulta).ToListAsync(); ;
        }

        public async Task<IEnumerable<Responsavel>> ObterResponsaveis()
        {
            return await _sisEscolaDbContext.Responsaveis.ToListAsync();
        }
    }
}

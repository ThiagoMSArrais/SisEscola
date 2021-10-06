using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using SisEscola.Cadastro.Domain.Models;

namespace SisEscola.Cadastro.Infra.Data.Context
{
    public class SisEscolaDbContext : DbContext
    {
        public SisEscolaDbContext(DbContextOptions<SisEscolaDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SisEscolaDbContext).Assembly);
        }
    }
}

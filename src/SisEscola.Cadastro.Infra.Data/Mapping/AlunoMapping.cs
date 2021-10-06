using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisEscola.Cadastro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEscola.Cadastro.Infra.Data.Mapping
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable(name: "Alunos", schema: "dbo");

            builder.HasKey(e => e.IdAluno);

            builder.Property(e => e.Nome)
                .HasColumnType("NVARCHAR(90)")
                .IsRequired();

            builder.Property(e => e.DataNascimento)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(e => e.Segmento)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(e => e.FotoPerfil)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("NVARCHAR(150)");

            builder.HasMany(e => e.Responsaveis)
                .WithOne(e => e.Aluno)
                .HasForeignKey(e => e.IdResponsavel);
        }
    }
}

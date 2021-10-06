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
    public class ResponsavelMapping : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.ToTable(name: "Responsaveis", schema: "dbo");

            builder.HasKey(e => e.IdResponsavel);

            builder.Property(e => e.Nome)
                .HasColumnType("NVARCHAR(90)")
                .IsRequired();

            builder.Property(e => e.DataNascimento)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(e => e.Parentesco)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(e => e.Telefone)
                .HasColumnType("NVARCHAR(12)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("NVARCHAR(150)")
                .IsRequired();
        }
    }
}

using System;

namespace SisEscola.Cadastro.Api.Models
{
    public class ResponsavelViewModel
    {
        public ResponsavelViewModel()
        {
            IdResponsavel = Guid.NewGuid();
        }

        public Guid IdResponsavel { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ParentescoViewModel Parentesco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual Guid IdAluno { get; set; }
        public virtual AlunoViewModel Aluno { get; set; }
    }
}

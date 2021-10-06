using System;

namespace SisEscola.Cadastro.Api.Models
{
    public class ResponsavelViewModel
    {
        public ResponsavelViewModel()
        {
            IdResponsavel = Guid.NewGuid();
        }

        public Guid IdResponsavel { get; private set; }
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public ParentescoViewModel Parentesco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public virtual Guid IdAluno { get; set; }
        public virtual AlunoViewModel Aluno { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SisEscola.Cadastro.Api.Models
{
    public class AlunoViewModel
    {
        public AlunoViewModel()
        {
            IdAluno = Guid.NewGuid();
        }

        public Guid IdAluno { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public SegmentoViewModel Segmento { get; private set; }
        public string FotoPerfil { get; private set; }
        public string Email { get; private set; }
        public ICollection<ResponsavelViewModel> Responsaveis { get; private set; }
    }
}

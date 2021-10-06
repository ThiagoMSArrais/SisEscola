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

        public Guid IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public SegmentoViewModel Segmento { get; set; }
        public string FotoPerfil { get; set; }
        public string Email { get; set; }
        public ICollection<ResponsavelViewModel> Responsaveis { get; set; }
    }
}

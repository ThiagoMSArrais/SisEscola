using System;
using System.Collections.Generic;

namespace SisEscola.Cadastro.Domain.Models
{
    public class Aluno
    {
        public Guid IdAluno { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Segmento Segmento { get; private set; }
        public string FotoPerfil { get; private set; }
        public string Email { get; private set; }
        public ICollection<Responsavel> Responsaveis { get; private set; }
    }
}

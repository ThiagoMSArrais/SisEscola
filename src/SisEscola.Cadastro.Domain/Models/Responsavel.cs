using System;

namespace SisEscola.Cadastro.Domain.Models
{
    public class Responsavel
    {
        public Guid IdResponsavel { get; private set; }
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public Parentesco Parentesco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
    }
}

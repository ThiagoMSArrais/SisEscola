using FluentValidation;
using SisEscola.Core.Models;
using System;

namespace SisEscola.Cadastro.Domain.Models
{
    public class Responsavel : Entity<Responsavel>
    {
        public Guid IdResponsavel { get; private set; }
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public Parentesco Parentesco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public virtual Guid IdAluno { get; set; }
        public virtual Aluno Aluno { get; set; }

        #region Validações

        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        private void Validar()
        {
            ValidarNome();
            ValidarDataNascimento();
            ValidarParentesco();
            ValidarTelefone();
            ValidarEmail();

            ValidationResult = Validate(this);
        }

        private void ValidarNome()
        {
            RuleFor(e => e.Nome)
                .NotEmpty().WithMessage("Informe o nome do responsável.")
                .Length(3, 90).WithMessage("O nome do responsável de ter entre 3 a 90 caracteres.");
        }

        private void ValidarDataNascimento()
        {
            RuleFor(e => e.DataNascimento)
                .NotEmpty().WithMessage("Informe a data de nascimento do responsável.");
        }

        private void ValidarParentesco()
        {
            RuleFor(e => e.Parentesco)
                .IsInEnum().WithMessage("Informe o parentesco correto.");
        }

        private void ValidarTelefone()
        {
            RuleFor(e => e.Telefone)
                .NotEmpty().WithMessage("Informe o número de telefone do responsável.")
                .Length(12, 12).WithMessage("Informe o número do telefone no formato correto.");
        }

        private void ValidarEmail()
        {
            RuleFor(e => e.Email)
                .NotEmpty().WithMessage("Informe um e-mail do responsável.")
                .EmailAddress().WithMessage("Informe um e-mail válido.");
        }

        #endregion
    }
}
